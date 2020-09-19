using System.Collections.Generic;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace UserFeaturesLogic
{
    internal class BasicFacebookFeatures : INewUserObserver
    {
        private NewUser m_NewLoggedInUser;

        public List<Post> UserPosts { get; private set;  }

        public BasicFacebookFeatures(NewUser i_NewLoggedInUser)
        {
            m_NewLoggedInUser = i_NewLoggedInUser;
            UserPosts = new List<Post>();
            m_NewLoggedInUser.AttachObserver(this as INewUserObserver);
        }

        public string GetBasicUserInfo()
        {
            StringBuilder userBasicInfo = new StringBuilder();
            userBasicInfo.AppendFormat(
                "First Name: {0}\r\nLast Name: {1}\r\nGender: {2}\r\nBirthday: {3}\r\n",
                m_NewLoggedInUser.User.FirstName,
                m_NewLoggedInUser.User.LastName,
                m_NewLoggedInUser.User.Gender,
                m_NewLoggedInUser.User.Birthday);

            if (m_NewLoggedInUser.User.Hometown != null)
            {
                userBasicInfo.AppendFormat(
                    "From: {0}\r\n",
                    m_NewLoggedInUser.User.Hometown.Location.State);
            }

            return userBasicInfo.ToString();
        }

        public void UserStateChanged(User I_NewUser)
        {
            m_NewLoggedInUser.User = I_NewUser;
            getUserPosts();
        }

        private void getUserPosts()
        {
            foreach (Post post in m_NewLoggedInUser.User.Posts)
            {
                if (post.Message != null)
                {
                    UserPosts.Add(post);
                }
            }
        }
    }
}