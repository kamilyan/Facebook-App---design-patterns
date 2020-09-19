using System;
using System.Collections.Generic;
using UserFeaturesLogic;

namespace UserFeaturesLogic
{
    internal interface IPostFinder
    {
        List<string> GetFilteredPosts(DateTime i_DateStartTime, DateTime i_DateEndTime, IPostSorter i_Strategy, string i_FilterBySTR);
    }
}