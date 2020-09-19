using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace UserFeaturesLogic
{
    internal class NewUser
    {
        private List<INewUserObserver> m_NewUserObservers;

        public User User { get; set; }

        public NewUser()
        {
           m_NewUserObservers = new List<INewUserObserver>();
        }

        public void AttachObserver(INewUserObserver i_INewUserObserver)
        {
            m_NewUserObservers.Add(i_INewUserObserver);
        }

        public void DetachObserver(INewUserObserver i_INewUserObserver)
        {
            m_NewUserObservers.Remove(i_INewUserObserver);
        }

        public void DoWhenNewUserLoggedIn(User i_NewLoggedInUser)
        {
            User = i_NewLoggedInUser;
            notifyNewUserObservers();
        }

        private void notifyNewUserObservers()
        {
            foreach (INewUserObserver observer in m_NewUserObservers)
            {
                observer.UserStateChanged(User);
            }
        }
    }
}
