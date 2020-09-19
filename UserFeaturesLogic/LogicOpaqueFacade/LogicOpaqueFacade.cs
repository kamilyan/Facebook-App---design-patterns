using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;
using UserFeaturesLogic.PostFinder;
using UserFeaturesLogic.Types;

namespace UserFeaturesLogic
{
    public class LogicOpaqueFacade
    {
        private BasicFacebookFeatures m_BasicUserInfo;
        private IPostFinder m_PostFinder;
        private StarSignFinder m_StarSignFinder;
        private NewUser m_NewLoggedInUser;
        private IAggregate m_UserPosts;

        public LogicOpaqueFacade()
        {
            m_NewLoggedInUser = new NewUser();
            m_BasicUserInfo = new BasicFacebookFeatures(m_NewLoggedInUser);
            m_PostFinder = new PostFinderCacheProxy(m_NewLoggedInUser);
            m_StarSignFinder = new StarSignFinder(m_NewLoggedInUser);
        }

        public void DoWhenNewUserLoggedIn(User i_NewLoggedInUser)
        {
            m_NewLoggedInUser.DoWhenNewUserLoggedIn(i_NewLoggedInUser);
        }

        public List<string> GetFilteredPosts(string i_FilterByASentence, DateTime i_Start, DateTime i_End, IPostSorter i_Strategy)
        {
            return m_PostFinder.GetFilteredPosts(i_Start, i_End, i_Strategy, i_FilterByASentence);
        }

        public List<string> GetFriendWithTheSameStarSign()
        {
            return m_StarSignFinder.FriendWithTheSameStarSign;
        }

        public List<string> GetFriendWithDefferintStarSign()
        {
            return m_StarSignFinder.FriendWithDefferintStarSign;
        }

        public Dictionary<string, eZodiacSigns> GetFriendsStarSigns()
        {
            return m_StarSignFinder.FriendsStarSigns;
        }

        public Dictionary<eZodiacSigns, string> GetStarSignContentInfo()
        {
            return m_StarSignFinder.GetStarSignContentInfo();
        }

        public string GetBasicUserInfo()
        {
            return m_BasicUserInfo.GetBasicUserInfo();
        }

        public IIterator GetUserPosts()
        {
            m_UserPosts = new Posts(m_BasicUserInfo);

            return m_UserPosts.CreateIterator();
        }

        public Dictionary<string, string> GetFriendsProfilePicture()
        {
            return m_StarSignFinder.FriendsProfilePicture;
        }

        public void SetStarSignFinder(eGenders i_SelectedGender, int i_MinAge, int i_MaxAge)
        {
            m_StarSignFinder.ArrangeFriendsByStarSign(i_MinAge, i_MaxAge, i_SelectedGender);
        }
    }
} 
