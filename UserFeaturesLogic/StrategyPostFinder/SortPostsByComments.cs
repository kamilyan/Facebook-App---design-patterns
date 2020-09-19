using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace UserFeaturesLogic
{
    public class SortPostsByComments : IPostSorter
    {
        public void SortPosts(List<Post> i_ListOfPosts)
        {
            i_ListOfPosts.Sort((leftPost, rightPost) => leftPost.Comments.Count.CompareTo(rightPost.Comments.Count));
        }
    }
}
