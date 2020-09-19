using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace UserFeaturesLogic
{
    public interface IPostSorter
    {
        void SortPosts(List<Post> i_ListOfPosts);
    }
}