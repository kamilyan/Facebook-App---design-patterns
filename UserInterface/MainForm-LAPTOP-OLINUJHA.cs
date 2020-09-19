using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A20_Ex01_Ben_200400216_Maor_204686042
{
    public partial class MainForm : Form
    {
        private FacebookWrapper.ObjectModel.User m_LoggedInUser;
        private string m_FaceBookAnonymousURL= "https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_640.png";
        private string m_LoginToFaceBookRequestURL = "https://pngimage.net/wp-content/uploads/2018/06/login-with-facebook-button-png-transparent-2.png";
        private bool LoggedUser = false;
        private string m_AppID = "731666954002581";
        private StringBuilder m_UserBasicInfoSB;
        public MainForm()
        {
            InitializeComponent();
            UserProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserProfilePictureBox.ImageLocation = m_FaceBookAnonymousURL;
            LoginOrDisconnectPictureBox.ImageLocation = m_LoginToFaceBookRequestURL;
            LoginOrDisconnectPictureBox.SizeMode= PictureBoxSizeMode.StretchImage; ;
  
         

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void OnButtonLogInClicked(object sender, EventArgs e)
        {

        }

        private void OnUserProfilePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginOrDisconnectPictureBox_Click(object sender, EventArgs e)
        {
            FacebookWrapper.LoginResult loginResult;
            if (LoggedUser == false)
            {

                loginResult = FacebookWrapper.FacebookService.Login(m_AppID, Epermission.user_posts.ToString());
                m_LoggedInUser = loginResult.LoggedInUser;
                FacebookWrapper.ObjectModel.FacebookObjectCollection<FacebookWrapper.ObjectModel.Post> facebookPosts=m_LoggedInUser.Posts;
                LoggedUser = true;
        

                displayUserPosts(facebookPosts);
                displayProfilePicAndconnectionLogo();
                showBasicInfo();

            }
            else if(LoggedUser == true)
            {
                FacebookWrapper.FacebookService.Logout(logOutFromFacebook);
            }
        }
        private void displayUserPosts(FacebookWrapper.ObjectModel.FacebookObjectCollection<FacebookWrapper.ObjectModel.Post> i_PostsCollection)
        {
            string postAsString = "";
            foreach(FacebookWrapper.ObjectModel.Post post in i_PostsCollection)
            {
                post.Message.ToString();
                postAsString = String.Format("Time: {0}\r\nCreated by: {1}\r\nPost: {2}\r\n\r\n"
, post.CreatedTime,post.Name,post.Message);
                PostsTextBox.AppendText(postAsString);

            }

        }
        private void displayProfilePicAndconnectionLogo()
        {
            UserProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserProfilePictureBox.ImageLocation = m_LoggedInUser.PictureLargeURL;// large for a better quality picture
                                                                                 //LoginOrDisconnectPictureBox.ImageLocation=//TODO add a disconnection logo

        }

        private void showBasicInfo()
        {
            m_UserBasicInfoSB = new StringBuilder();
            m_UserBasicInfoSB.AppendFormat("First Name: {0}\r\nLast Name: {1}\r\nGender: {2}\r\nAge: {3}"
, m_LoggedInUser.FirstName, m_LoggedInUser.LastName, m_LoggedInUser.Gender, m_LoggedInUser.Birthday);//couldnt use the @"" properly
            BasicUserInfoTextBox.Text = m_UserBasicInfoSB.ToString();
            BasicUserInfoTextBox.Visible = true;

        }
        private void logOutFromFacebook()
        {
            LoggedUser = false;
            UserProfilePictureBox.ImageLocation = m_FaceBookAnonymousURL;
            LoginOrDisconnectPictureBox.ImageLocation = m_LoginToFaceBookRequestURL;
            BasicUserInfoTextBox.Visible = false;
            BasicUserInfoTextBox.Text = "";
            PostsTextBox.Text = "";

        }
        private enum Epermission
        {
            email,
           groups,
            _access_member_info,
            publish_to_groups,
            user_age_range,
            user_birthday,
            user_events,
            user_friends,
            user_gender,
            user_hometown,
            user_likes,
            user_link,
            user_location,
            user_photos,
            user_posts,
            user_videos,
        }
    }
}
