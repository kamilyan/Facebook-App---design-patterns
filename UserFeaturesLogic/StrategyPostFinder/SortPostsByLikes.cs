using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace UserFeaturesLogic
{
    public class SortPostsByLikes : IPostSorter
    {
        public void SortPosts(List<Post> i_ListOfPosts)
        {
            i_ListOfPosts.Sort((leftPost, rightPost) => leftPost.LikedBy.Count.CompareTo(rightPost.LikedBy.Count));
        }
    }
}
