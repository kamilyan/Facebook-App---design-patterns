using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using UserFeaturesLogic;

namespace UserFeaturesLogic.PostFinder
{
    internal class PostFinderCacheProxy : IPostFinder, INewUserObserver
    {
        private const int k_MaxSpanDays = 7;
        private PostFinder m_PostsFinder;
        private NewUser m_NewLoggedInUser;
        private List<string> m_UserFilteredPost;

        private Tuple<DateTime, DateTime, IPostSorter, string> m_LastUserRequirements;

        public PostFinderCacheProxy(NewUser i_NewLoggedInUser)
        {
            m_NewLoggedInUser = i_NewLoggedInUser;
            m_NewLoggedInUser.AttachObserver(this as INewUserObserver);
        }

        public void UserStateChanged(User I_NewUser)
        {
            m_NewLoggedInUser.User = I_NewUser;
            m_PostsFinder = null;
        }

        public List<string> GetFilteredPosts(DateTime i_DateStartTime, DateTime i_DateEndTime, IPostSorter i_Strategy, string i_FilterBySTR)
        {
            if (m_PostsFinder == null)
            {
                m_PostsFinder = new PostFinder(m_NewLoggedInUser.User);
                setRequierements(i_DateStartTime, i_DateEndTime, i_Strategy, i_FilterBySTR);
            }

            bool isOldPostsCache = checkIfItsOldCachePosts(i_DateEndTime);
            bool wasUserRequirementsChanged = checkIfRequirementsHaveChanged(i_DateStartTime, i_DateEndTime, i_Strategy, i_FilterBySTR);

            if (isOldPostsCache || wasUserRequirementsChanged)
            {
                setRequierements(i_DateStartTime, i_DateEndTime, i_Strategy, i_FilterBySTR);
                m_UserFilteredPost = m_PostsFinder.GetFilteredPosts(i_DateStartTime, i_DateEndTime, i_Strategy, i_FilterBySTR);
            }

            return m_UserFilteredPost;
        }

        private bool checkIfRequirementsHaveChanged(DateTime i_DateStartTime, DateTime i_DateEndTime, IPostSorter i_Strategy, string i_FilterBySTR)
        {
           return 
            m_LastUserRequirements.Item1 != i_DateStartTime ||
            m_LastUserRequirements.Item2 != i_DateEndTime ||
            m_LastUserRequirements.Item3 != i_Strategy ||
            m_LastUserRequirements.Item4 != i_FilterBySTR;
        }

        private bool checkIfItsOldCachePosts(DateTime i_DateEndTime)
        {
            return (DateTime.Now - i_DateEndTime).Days <= k_MaxSpanDays;
        }

        private void setRequierements(DateTime i_DateStartTime, DateTime i_DateEndTime, IPostSorter i_Strategy, string i_FilterBySTR)
        {
            m_LastUserRequirements = Tuple.Create(i_DateStartTime, i_DateEndTime, i_Strategy, i_FilterBySTR);
        }
    }
}
