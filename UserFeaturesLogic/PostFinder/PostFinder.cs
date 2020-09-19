using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using UserFeaturesLogic;

namespace UserFeaturesLogic.PostFinder
{
    internal class PostFinder : IPostFinder
    {
        private User m_LoggedInUser;
        private List<Post> m_UserFilteredPost;
        private List<Post> m_UserOriginalPosts;

        public PostFinder(User i_User)
        {
            m_LoggedInUser = i_User;
            m_UserFilteredPost = new List<Post>();
            m_UserOriginalPosts = new List<Post>();
            getUserOriginalPosts();
        }

        private void getUserOriginalPosts()
        {
            foreach(Post post in m_LoggedInUser.Posts)
            {
                m_UserOriginalPosts.Add(post);
            }
        }

        public List<string> GetFilteredPosts(DateTime i_DateStartTime, DateTime i_DateEndTime, IPostSorter i_Strategy, string i_FilterBySTR)
        {
            m_UserFilteredPost.Clear();
            filterPostByRangeOfDate(i_DateStartTime, i_DateEndTime);
            filterPostByASentence(i_FilterBySTR);                  
            i_Strategy.SortPosts(m_UserFilteredPost);           
            List<string> userContentPosts = getUserContentPosts();

            return userContentPosts;
        }

        private void filterPostByRangeOfDate(DateTime i_DateStartTime, DateTime i_DateEndTime)
        {
            foreach (Post post in m_UserOriginalPosts)
            {
                if (i_DateStartTime <= post.CreatedTime && i_DateEndTime >= post.CreatedTime)
                {
                    m_UserFilteredPost.Add(post);
                }
            }
        }

        private void filterPostByASentence(string i_FilterBySTR)
        {
            List<Post> newFilteredPosts = new List<Post>();

            foreach (Post post in m_UserFilteredPost)
            {
                if (string.IsNullOrEmpty(post.Message) == false && post.Message.Contains(i_FilterBySTR))
                {
                    newFilteredPosts.Add(post);
                }
            }

            m_UserFilteredPost = newFilteredPosts;
        }

        private List<string> getUserContentPosts()
        {
            List<string> filteredUserPosts = new List<string>();

            foreach (Post post in m_UserFilteredPost)
            {
                post.Message.ToString();
                string filteredPost = string.Format(
                    "Time: {0}\r\nCreated by: {1}\r\nPost: {2}\r\nNumber of likes:{3}\r\nNumber of Comments:{4}\r\n\r\n",
                    post.CreatedTime,
                    post.From.Name,
                    post.Message,
                    post.LikedBy.Count,
                    post.Comments.Count);

                filteredUserPosts.Add(filteredPost);
            }

            return filteredUserPosts;
        }
    }
}
