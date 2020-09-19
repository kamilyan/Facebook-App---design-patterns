using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace UserFeaturesLogic
{
    public class SortPostsByDate : IPostSorter
    {
        public void SortPosts(List<Post> i_ListOfPosts)
        {
            i_ListOfPosts.Sort((leftPost, rightPost) => DateTime.Compare((DateTime)leftPost.CreatedTime, (DateTime)rightPost.CreatedTime));
        }
    }
}
