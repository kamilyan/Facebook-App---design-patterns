using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using UserFeaturesLogic;
using UserFeaturesLogic.Types;

namespace UserInterface
{
    public partial class MainForm : Form
    {
        private const int k_ServiceLimit = 10;
        private readonly string r_FaceBookAnonymousURL = @"https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_640.png";
        private readonly string r_FaceBookLogOutIconURL = @"https://icon-library.net/images/free-logout-icon/free-logout-icon-7.jpg";
        private readonly string r_LoginToFaceBookRequestURL = @"https://pngimage.net/wp-content/uploads/2018/06/login-with-facebook-button-png-transparent-2.png";
        private readonly string r_AppID = "731666954002581";
        private LogicOpaqueFacade m_ClientFacade;
        private AppSettings m_AppSettings;
        private bool v_IsUserConnectedToFB;
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private IIterator m_FacebookPosts;

        public MainForm()
        {
            InitializeComponent();
            initializeSetupForm();
            initializeStartupImages();
        }

        protected override void OnShown(EventArgs e)
        {
            setUserSettings();
            base.OnShown(e);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            saveUserSettings();     
        }

        private void saveUserSettings()
        {
            try
            {
                m_AppSettings.LastWindowSize = this.Size;
                m_AppSettings.LastWindowLocation = this.Location;
                m_AppSettings.RemeberUser = this.rememberUserCheckBox.Checked;

                if (this.rememberUserCheckBox.Checked && v_IsUserConnectedToFB == true)
                {
                    m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
                }
                else
                {
                    m_AppSettings.LastAccessToken = null;
                    m_AppSettings.RemeberUser = false;
                }

                m_AppSettings.SaveToFile();
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to save user settings");
            }
        }

        private void setUserSettings()
        {
            try
            {
                FacebookService.s_CollectionLimit = k_ServiceLimit;

                if (m_AppSettings.RemeberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
                {
                    m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                    LoginOrDisconnectPictureBox.ImageLocation = r_FaceBookLogOutIconURL;
                    new Thread(fetchLoggedInUser).Start();
                    v_IsUserConnectedToFB = true;
                }
                else
                {
                    rememberUserCheckBox.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to set user settings");
            }
        }

        private void initializeSetupForm()
        {
            try
            {
                m_AppSettings = AppSettings.LoadFromFile();
                this.StartPosition = FormStartPosition.Manual;
                this.Size = m_AppSettings.LastWindowSize;
                this.Location = m_AppSettings.LastWindowLocation;
                this.rememberUserCheckBox.Checked = m_AppSettings.RemeberUser;
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to setup form");
            }
        }

        private void initializeStartupImages()
        {
            try
            {
                UserProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                UserProfilePictureBox.ImageLocation = r_FaceBookAnonymousURL;
                LoginOrDisconnectPictureBox.ImageLocation = r_LoginToFaceBookRequestURL;
                LoginOrDisconnectPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to to initialize Image");
            }    
        }

        private void fetchLoggedInUser()
        {
            try
            {
                setInputValuesInLogic();
                populateUIFromFacebookData();
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to fetch data");
            }
        }

        private void setInputValuesInLogic()
        {      
            if(m_ClientFacade == null)
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                m_ClientFacade = new LogicOpaqueFacade();
                m_ClientFacade.DoWhenNewUserLoggedIn(m_LoginResult.LoggedInUser);
            }

            setStarSignFinder();
        }

        private void setStarSignFinder()
        {
            eGenders selectedGender = findSelectedGender();
            int minSelectedAge = Convert.ToInt32(upDownMinAge.Value);
            int maxSelectedAge = Convert.ToInt32(upDownMaxAge.Value);

            m_ClientFacade.SetStarSignFinder(selectedGender, minSelectedAge, maxSelectedAge);
        }

        private void LoginOrDisconnectPictureBox_Click(object sender, EventArgs e)
        {
            LoginAndLogoutSetUp();
        }

        private void LoginAndLogoutSetUp()
        {
            if (!v_IsUserConnectedToFB)
            {
                loginSetUpForm(); 
            }
            else
            {
                logOutSetUpForm();
            }
        }

        private void logOutSetUpForm()
        {
            try
            {
                FacebookService.Logout(logOutFromFacebook);
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to logout");
            }
        }

        private void loginSetUpForm()
        {
            try
            {
                m_LoginResult = FacebookService.Login(
                    r_AppID,
                    "user_posts",
                    "user_birthday",
                    "user_gender",
                    "user_hometown",
                    "user_friends");

                new Thread(fetchLoggedInUser).Start();
                v_IsUserConnectedToFB = true;
                rememberUserCheckBox.Enabled = true;
                LoginOrDisconnectPictureBox.ImageLocation = r_FaceBookLogOutIconURL;
                LoginOrDisconnectPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                MessageBox.Show("Unable to login");
                FacebookService.Logout(this.Close);
            }
        }

        private void fetchAllUserAlbums()
        {
            var allAlbums = m_LoggedInUser.Albums;

            if (!albumListBox.InvokeRequired)
            {
                albumBindingSource.DataSource = allAlbums;
            }
            else
            {
                albumListBox.Invoke(new Action(() => albumBindingSource.DataSource = allAlbums));
            }
        }

        private void fetchAllUserPosts()
        {
            var allPosts = m_LoggedInUser.Posts;

            if (!PostUpdateBox.InvokeRequired)
            {
                postBindingSource.DataSource = allPosts;
            }
            else
            {
                PostUpdateBox.Invoke(new Action(() => postBindingSource.DataSource = allPosts));
            }
        }

        private void fetchUserProfilePicture()
        {
            UserProfilePictureBox.Invoke(new Action(() => UserProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage));
            UserProfilePictureBox.Invoke(new Action(() => UserProfilePictureBox.ImageLocation = m_LoggedInUser.PictureLargeURL));
        }

        private void fetchBasicUserInfo()
        {
            BasicUserInfoTextBox.Invoke(new Action(() => BasicUserInfoTextBox.Text = m_ClientFacade.GetBasicUserInfo()));
        }

        private void populateUIFromFacebookData()
        {
            new Thread(fetchUserProfilePicture).Start();
            new Thread(fetchBasicUserInfo).Start();
            new Thread(fetchUserPosts).Start();
            new Thread(fetchFriendsToListBox).Start();
            new Thread(fetchAllUserPosts).Start();
            new Thread(fetchAllUserAlbums).Start();
        }

        private void logOutFromFacebook()
        {
            v_IsUserConnectedToFB = false;
            m_AppSettings.LastAccessToken = null;
            UserProfilePictureBox.Invoke(new Action(() => UserProfilePictureBox.ImageLocation = r_FaceBookAnonymousURL));
            LoginOrDisconnectPictureBox.Invoke(new Action(() => LoginOrDisconnectPictureBox.ImageLocation = r_LoginToFaceBookRequestURL));
            clearAllUserData();
        }

        private void clearAllUserData()
        {
            clearBasicUserInfo();
            clearPostFinderInfo();
            clearStarSignFinderInfo();
        }

        private void clearBasicUserInfo()
        {
            BasicUserInfoTextBox.Invoke(new Action(() => BasicUserInfoTextBox.Text = string.Empty));
        }

        private void clearPostFinderInfo()
        {
            PostsTextBox.Invoke(new Action(() => PostsTextBox.Text = string.Empty));
            rememberUserCheckBox.Invoke(new Action(() => rememberUserCheckBox.Enabled = false));
            clearFilteredPostsTextBox();
        }

        private void fetchUserPosts()
        {
            try
            {
                m_FacebookPosts = m_ClientFacade.GetUserPosts();
                string postAsString = string.Empty;
                while(m_FacebookPosts.MoveNext())
                {
                    var userPosts = m_FacebookPosts.Current as Post;
                    postAsString = string.Format(
                        "Time: {0}\r\nCreated by: {1}\r\nPost: {2}\r\n\r\n",
                        userPosts.CreatedTime,
                        userPosts.Name,
                        userPosts.Message);
                    PostsTextBox.Invoke(new Action(() => PostsTextBox.AppendText(postAsString)));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You are not permitted to get this information");
            }
        }

        private void fetchFriendsToListBox()
        {
            try
            {
                foreach (string friendName in m_ClientFacade.GetFriendWithTheSameStarSign())
                {
                    friendsListBoxSameStarSign.Invoke(new Action(() => friendsListBoxSameStarSign.Items.Add(friendName)));
                }

                foreach (string friendName in m_ClientFacade.GetFriendWithDefferintStarSign())
                {
                    friendsListBoxdifferentStarSign.Invoke(new Action(() => friendsListBoxdifferentStarSign.Items.Add(friendName)));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable: Couldn't get friends");
            }
        }

        private void displayFilteredPost()
        {
            IPostSorter strategy;

            if(MostLikedPostsRadioBUtton.Checked)
            {
                strategy = new SortPostsByLikes();
            }
            else if(MostCommentsRadioButton.Checked)
            {
                strategy = new SortPostsByComments();
            }
            else
            {
                strategy = new SortPostsByDate();
            }

            foreach (string post in m_ClientFacade.GetFilteredPosts(txtBoxSearch.Text, dateStart.Value, dateEnd.Value, strategy))
            {
                txtBoxfilteredPosts.Invoke(new Action(() => txtBoxfilteredPosts.AppendText(post)));
            }
        }

        private void searchFilteredPosts_Click(object sender, EventArgs e)
        {
            new Thread(resetFilteredUserPosts).Start();
        }

        private void resetFilteredUserPosts()
        {
            try
            {
                setInputValuesInLogic();
                clearFilteredPostsTextBox();
                displayFilteredPost();
            }
            catch (Exception e)
            { 
                MessageBox.Show(e.GetBaseException().ToString());
            }
        }

        private void displayFriendsStarSignResults()
        {
            try
            {
                displayDescripitonOfStarSign();
                displayFriendProfilePicture();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to get friends results");
            }
        }

        private void clearFilteredPostsTextBox()
        {
            txtBoxfilteredPosts.Invoke(new Action(() => txtBoxfilteredPosts.Clear()));
        }

        private void displayFriendProfilePicture()
        {
            string friendName = friendsListBoxdifferentStarSign.GetItemText(friendsListBoxdifferentStarSign.SelectedItem);
            string friendPic = m_ClientFacade.GetFriendsProfilePicture()[friendName];
            pictureBoxFriendProfilePicture.Invoke(new Action(() => pictureBoxFriendProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage));
            pictureBoxFriendProfilePicture.Invoke(new Action(() => pictureBoxFriendProfilePicture.ImageLocation = friendPic));
        }

        private void displayDescripitonOfStarSign()
        {
            string friendName = friendsListBoxdifferentStarSign.GetItemText(friendsListBoxdifferentStarSign.SelectedItem);
            eZodiacSigns starSignName = m_ClientFacade.GetFriendsStarSigns()[friendName];
            string friendStarSign = m_ClientFacade.GetStarSignContentInfo()[starSignName];
            clearDisplayFriendsDetails();
            txtBoxStarSignContent.Invoke(new Action(() => txtBoxStarSignContent.AppendText(friendStarSign)));
            txtBoxStarSignName.Invoke(new Action(() => txtBoxStarSignName.AppendText(starSignName.ToString())));
        }

        private void friendsBoxWtihDifferentStarSign_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            displayFriendsStarSignResults();
        }

        private void clearDisplayFriendsDetails()
        {
            txtBoxStarSignContent.Clear();
            txtBoxStarSignName.Clear();
            pictureBoxFriendProfilePicture.Image = null;
        }

        private void clearStarSignFinderInfo()
        {
            friendsListBoxdifferentStarSign.Items.Clear();
            friendsListBoxSameStarSign.Items.Clear();
            clearDisplayFriendsDetails();
        }

        private void findFriendStarSignFinderData()
        {
            try
            {
                clearStarSignFinderInfo();
                new Thread(fetchLoggedInUser).Start();
            }
            catch(Exception)
            {
                MessageBox.Show("Unable: Couldn't achieve any friend data");
            }
        }

        private void friendsBoxWithTheSameStarSign_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayFriendsStarSignResults();
        }

        private void btnFindFriendData_Click(object sender, EventArgs e)
        {
            findFriendStarSignFinderData();
        }

        private eGenders findSelectedGender()
        {
            eGenders selectedGender;

            if (checkBoxFemale.Checked && !checkBoxMale.Checked)
            {
                selectedGender = eGenders.Female;
            }
            else if (checkBoxMale.Checked && !checkBoxFemale.Checked)
            {
                selectedGender = eGenders.Male;
            }
            else if (checkBoxMale.Checked && checkBoxFemale.Checked)
            {
                selectedGender = eGenders.Both;
            }
            else
            {
                selectedGender = eGenders.NoSet;
            }

            return selectedGender;
        }
    }
}