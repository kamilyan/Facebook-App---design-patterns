using FacebookWrapper.ObjectModel;

namespace UserFeaturesLogic
{
    internal interface INewUserObserver
    {
        void UserStateChanged(User I_NewUser);
    }
}
