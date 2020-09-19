using System;
using System.Collections.Generic;
using System.Globalization;
using FacebookWrapper.ObjectModel;
using UserFeaturesLogic.Types;

namespace UserFeaturesLogic
{
    internal class StarSignFinder : INewUserObserver
    {
        private NewUser m_NewLoggedInUser;
        private StarSignCache m_StarSignDetails;
        private List<User> m_UserFriends; 

        public List<string> FriendWithTheSameStarSign { get; private set; }

        public List<string> FriendWithDefferintStarSign { get; private set; }

        public Dictionary<string, eZodiacSigns> FriendsStarSigns { get; private set; }

        public Dictionary<string, string> FriendsProfilePicture { get; private set; }

        public StarSignFinder(NewUser i_NewLoggedInUser)
        {
            m_NewLoggedInUser = i_NewLoggedInUser;
            m_UserFriends = new List<User>();
            m_NewLoggedInUser.AttachObserver(this as INewUserObserver);
            FriendWithTheSameStarSign = new List<string>();
            FriendWithDefferintStarSign = new List<string>();
            FriendsStarSigns = new Dictionary<string, eZodiacSigns>();
            FriendsProfilePicture = new Dictionary<string, string>();
            m_StarSignDetails = StarSignCache.StarSignsInstance;
        }

        public void UserStateChanged(User I_NewUser)
        {
            m_NewLoggedInUser.User = I_NewUser;
            getUserFriends(m_NewLoggedInUser.User);
        }

        private void getUserFriends(User I_NewUser)
        {
            foreach (User friend in I_NewUser.Friends)
            {
                m_UserFriends.Add(friend);
            }
        }

        public void ArrangeFriendsByStarSign(int i_MinAge, int i_MaxAge, eGenders i_SelectedGender)
        {
            DateTime userBirthday = DateTime.ParseExact(m_NewLoggedInUser.User.Birthday, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            DateTime friendBirthday;
            eZodiacSigns userStarSign = m_StarSignDetails.GetZodiacSign(userBirthday);
            eZodiacSigns friendStarSign;

            clearAllDataCache();

            foreach (User friend in m_UserFriends)
            {
                friendBirthday = DateTime.ParseExact(friend.Birthday, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                friendStarSign = m_StarSignDetails.GetZodiacSign(friendBirthday);

                if (userStarSign.Equals(friendStarSign))
                {
                    if (isFriendRequiredByUser(friend.Gender.ToString(), friendBirthday, i_SelectedGender, i_MinAge, i_MaxAge))
                    {
                        addFriendToSameStarSignListBox(friend.Name, friendStarSign, friend.PictureLargeURL);
                    }
                }
                else
                {
                    if (isFriendRequiredByUser(friend.Gender.ToString(), friendBirthday, i_SelectedGender, i_MinAge, i_MaxAge))
                    {
                        addFriendToDifferentStarSignListBox(friend.Name, friendStarSign, friend.PictureLargeURL);
                    }
                }
            }
        }

        public Dictionary<eZodiacSigns, string> GetStarSignContentInfo()
        {
            return m_StarSignDetails.StarSignContentInfo;
        }

        private bool chosenGender(string i_FriendGender, eGenders i_SelectedGender)
        {
            string userChosenGender = i_SelectedGender.ToString().ToLower();
            bool hasChosenGender = userChosenGender.Equals(i_FriendGender) || eGenders.Both.Equals(i_SelectedGender);

            return hasChosenGender;
        }

        private bool chosenFriendByARangeOfAge(DateTime i_FriendBirthday, int i_MinAge, int i_MaxAge)
        {
            int friendAge = getFriendAge(i_FriendBirthday);
            bool wasAgeCosen = (friendAge >= i_MinAge) && (friendAge <= i_MaxAge);

            return wasAgeCosen;
        }

        private int getFriendAge(DateTime i_FriendBirthday)
        {
            DateTime todayDate = DateTime.Today;
            int age = todayDate.Year - i_FriendBirthday.Year;

            if (todayDate < i_FriendBirthday.AddYears(age))
            {
                age--;
            }

            return age;
        }

        private void clearAllDataCache()
        {
            FriendWithTheSameStarSign.Clear();
            FriendWithDefferintStarSign.Clear();
            FriendsStarSigns.Clear();
            FriendsProfilePicture.Clear();
        }

        private bool isFriendRequiredByUser(string i_FriendGender, DateTime i_FriendBirthday, eGenders i_SelectedGender, int i_MinAge, int i_MaxAge)
        {
            bool friendIsRequired = chosenGender(i_FriendGender, i_SelectedGender) && chosenFriendByARangeOfAge(i_FriendBirthday, i_MinAge, i_MaxAge);
            return friendIsRequired;
        }

        private void saveFriendStarSignAndProfilePicture(string i_FriendName, eZodiacSigns i_FriendStarSign, string i_FriendPicture)
        {
            FriendsStarSigns.Add(i_FriendName, i_FriendStarSign);
            FriendsProfilePicture.Add(i_FriendName, i_FriendPicture);
        }

        private void addFriendToSameStarSignListBox(string i_FriendName, eZodiacSigns i_FriendStarSign, string i_FriendPicture)
        {
            FriendWithTheSameStarSign.Add(i_FriendName);
            saveFriendStarSignAndProfilePicture(i_FriendName, i_FriendStarSign, i_FriendPicture);
        }

        private void addFriendToDifferentStarSignListBox(string i_FriendName, eZodiacSigns i_FriendStarSign, string i_FriendPicture)
        {
            FriendWithDefferintStarSign.Add(i_FriendName);
            saveFriendStarSignAndProfilePicture(i_FriendName, i_FriendStarSign, i_FriendPicture);
        }
    }
}
