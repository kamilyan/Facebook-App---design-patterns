namespace UserInterface
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label updateTimeLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label imageAlbumLabel;
            System.Windows.Forms.Label updateTimeLabel1;
            System.Windows.Forms.Label label15;
            this.UserProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.LoginOrDisconnectPictureBox = new System.Windows.Forms.PictureBox();
            this.BasicUserInfoTextBox = new System.Windows.Forms.TextBox();
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.rememberUserCheckBox = new System.Windows.Forms.CheckBox();
            this.searchFeature = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PostOrderPanel = new System.Windows.Forms.Panel();
            this.SortingByDateBtn = new System.Windows.Forms.RadioButton();
            this.MostCommentsRadioButton = new System.Windows.Forms.RadioButton();
            this.MostLikedPostsRadioBUtton = new System.Windows.Forms.RadioButton();
            this.PostOrderLabel = new System.Windows.Forms.Label();
            this.txtBoxfilteredPosts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PostsTextBox = new System.Windows.Forms.TextBox();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.userPostslabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFindFriendData = new System.Windows.Forms.Button();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.upDownMaxAge = new System.Windows.Forms.NumericUpDown();
            this.upDownMinAge = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.friendsListBoxSameStarSign = new System.Windows.Forms.ListBox();
            this.friendsListBoxdifferentStarSign = new System.Windows.Forms.ListBox();
            this.txtBoxStarSignName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.friendsWithDifferentStarSign = new System.Windows.Forms.Label();
            this.friendsWithTheSameStarSign = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxStarSignContent = new System.Windows.Forms.TextBox();
            this.profilePicture = new System.Windows.Forms.Label();
            this.pictureBoxFriendProfilePicture = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PostsUpdate = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createdTimeTextBox1 = new System.Windows.Forms.TextBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.updateTimeTextBox1 = new System.Windows.Forms.TextBox();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.albumListBox = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createdTimeTextBox = new System.Windows.Forms.TextBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.updateTimeTextBox = new System.Windows.Forms.TextBox();
            this.PostUpdateBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            messageLabel = new System.Windows.Forms.Label();
            updateTimeLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            imageAlbumLabel = new System.Windows.Forms.Label();
            updateTimeLabel1 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginOrDisconnectPictureBox)).BeginInit();
            this.searchFeature.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PostOrderPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMaxAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfilePicture)).BeginInit();
            this.PostsUpdate.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            messageLabel.ForeColor = System.Drawing.Color.Lime;
            messageLabel.Location = new System.Drawing.Point(6, 95);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(68, 16);
            messageLabel.TabIndex = 4;
            messageLabel.Text = "Message:";
            // 
            // updateTimeLabel
            // 
            updateTimeLabel.AutoSize = true;
            updateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            updateTimeLabel.ForeColor = System.Drawing.Color.Lime;
            updateTimeLabel.Location = new System.Drawing.Point(6, 67);
            updateTimeLabel.Name = "updateTimeLabel";
            updateTimeLabel.Size = new System.Drawing.Size(90, 16);
            updateTimeLabel.TabIndex = 6;
            updateTimeLabel.Text = "Update Time:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            createdTimeLabel.ForeColor = System.Drawing.Color.Lime;
            createdTimeLabel.Location = new System.Drawing.Point(4, 37);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(93, 16);
            createdTimeLabel.TabIndex = 7;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            descriptionLabel.ForeColor = System.Drawing.Color.Lime;
            descriptionLabel.Location = new System.Drawing.Point(2, 42);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(79, 16);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // imageAlbumLabel
            // 
            imageAlbumLabel.AutoSize = true;
            imageAlbumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            imageAlbumLabel.ForeColor = System.Drawing.Color.Lime;
            imageAlbumLabel.Location = new System.Drawing.Point(2, 94);
            imageAlbumLabel.Name = "imageAlbumLabel";
            imageAlbumLabel.Size = new System.Drawing.Size(90, 16);
            imageAlbumLabel.TabIndex = 4;
            imageAlbumLabel.Text = "Image Album:";
            // 
            // updateTimeLabel1
            // 
            updateTimeLabel1.AutoSize = true;
            updateTimeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            updateTimeLabel1.ForeColor = System.Drawing.Color.Lime;
            updateTimeLabel1.Location = new System.Drawing.Point(2, 68);
            updateTimeLabel1.Name = "updateTimeLabel1";
            updateTimeLabel1.Size = new System.Drawing.Size(90, 16);
            updateTimeLabel1.TabIndex = 6;
            updateTimeLabel1.Text = "Update Time:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            label15.ForeColor = System.Drawing.Color.Lime;
            label15.Location = new System.Drawing.Point(2, 17);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(93, 16);
            label15.TabIndex = 8;
            label15.Text = "Created Time:";
            // 
            // UserProfilePictureBox
            // 
            this.UserProfilePictureBox.Location = new System.Drawing.Point(4, 52);
            this.UserProfilePictureBox.Name = "UserProfilePictureBox";
            this.UserProfilePictureBox.Size = new System.Drawing.Size(150, 118);
            this.UserProfilePictureBox.TabIndex = 1;
            this.UserProfilePictureBox.TabStop = false;
            // 
            // LoginOrDisconnectPictureBox
            // 
            this.LoginOrDisconnectPictureBox.Location = new System.Drawing.Point(4, 11);
            this.LoginOrDisconnectPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoginOrDisconnectPictureBox.Name = "LoginOrDisconnectPictureBox";
            this.LoginOrDisconnectPictureBox.Size = new System.Drawing.Size(150, 41);
            this.LoginOrDisconnectPictureBox.TabIndex = 2;
            this.LoginOrDisconnectPictureBox.TabStop = false;
            this.LoginOrDisconnectPictureBox.Click += new System.EventHandler(this.LoginOrDisconnectPictureBox_Click);
            // 
            // BasicUserInfoTextBox
            // 
            this.BasicUserInfoTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BasicUserInfoTextBox.Location = new System.Drawing.Point(154, 52);
            this.BasicUserInfoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BasicUserInfoTextBox.Multiline = true;
            this.BasicUserInfoTextBox.Name = "BasicUserInfoTextBox";
            this.BasicUserInfoTextBox.ReadOnly = true;
            this.BasicUserInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BasicUserInfoTextBox.Size = new System.Drawing.Size(151, 118);
            this.BasicUserInfoTextBox.TabIndex = 3;
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userInfoLabel.ForeColor = System.Drawing.Color.Blue;
            this.userInfoLabel.Location = new System.Drawing.Point(154, 32);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(151, 20);
            this.userInfoLabel.TabIndex = 6;
            this.userInfoLabel.Text = "User basic info";
            this.userInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rememberUserCheckBox
            // 
            this.rememberUserCheckBox.AutoSize = true;
            this.rememberUserCheckBox.ForeColor = System.Drawing.Color.Black;
            this.rememberUserCheckBox.Location = new System.Drawing.Point(154, 11);
            this.rememberUserCheckBox.Name = "rememberUserCheckBox";
            this.rememberUserCheckBox.Size = new System.Drawing.Size(95, 17);
            this.rememberUserCheckBox.TabIndex = 15;
            this.rememberUserCheckBox.Text = "Remember Me";
            this.rememberUserCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchFeature
            // 
            this.searchFeature.Controls.Add(this.tabPage1);
            this.searchFeature.Controls.Add(this.tabPage2);
            this.searchFeature.Controls.Add(this.PostsUpdate);
            this.searchFeature.Location = new System.Drawing.Point(4, 176);
            this.searchFeature.Name = "searchFeature";
            this.searchFeature.SelectedIndex = 0;
            this.searchFeature.Size = new System.Drawing.Size(834, 470);
            this.searchFeature.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage1.Controls.Add(this.PostOrderPanel);
            this.tabPage1.Controls.Add(this.txtBoxfilteredPosts);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.PostsTextBox);
            this.tabPage1.Controls.Add(this.txtBoxSearch);
            this.tabPage1.Controls.Add(this.searchBtn);
            this.tabPage1.Controls.Add(this.dateEnd);
            this.tabPage1.Controls.Add(this.dateStart);
            this.tabPage1.Controls.Add(this.userPostslabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.Color.Blue;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PostFinder";
            // 
            // PostOrderPanel
            // 
            this.PostOrderPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PostOrderPanel.Controls.Add(this.SortingByDateBtn);
            this.PostOrderPanel.Controls.Add(this.MostCommentsRadioButton);
            this.PostOrderPanel.Controls.Add(this.MostLikedPostsRadioBUtton);
            this.PostOrderPanel.Controls.Add(this.PostOrderLabel);
            this.PostOrderPanel.Location = new System.Drawing.Point(700, 61);
            this.PostOrderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.PostOrderPanel.Name = "PostOrderPanel";
            this.PostOrderPanel.Size = new System.Drawing.Size(123, 113);
            this.PostOrderPanel.TabIndex = 38;
            // 
            // SortingByDateBtn
            // 
            this.SortingByDateBtn.AutoSize = true;
            this.SortingByDateBtn.Checked = true;
            this.SortingByDateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortingByDateBtn.Location = new System.Drawing.Point(4, 81);
            this.SortingByDateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SortingByDateBtn.Name = "SortingByDateBtn";
            this.SortingByDateBtn.Size = new System.Drawing.Size(63, 17);
            this.SortingByDateBtn.TabIndex = 4;
            this.SortingByDateBtn.TabStop = true;
            this.SortingByDateBtn.Text = "By Date";
            this.SortingByDateBtn.UseVisualStyleBackColor = true;
            // 
            // MostCommentsRadioButton
            // 
            this.MostCommentsRadioButton.AutoSize = true;
            this.MostCommentsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostCommentsRadioButton.Location = new System.Drawing.Point(4, 55);
            this.MostCommentsRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.MostCommentsRadioButton.Name = "MostCommentsRadioButton";
            this.MostCommentsRadioButton.Size = new System.Drawing.Size(98, 17);
            this.MostCommentsRadioButton.TabIndex = 3;
            this.MostCommentsRadioButton.TabStop = true;
            this.MostCommentsRadioButton.Text = "Most comments";
            this.MostCommentsRadioButton.UseVisualStyleBackColor = true;
            // 
            // MostLikedPostsRadioBUtton
            // 
            this.MostLikedPostsRadioBUtton.AutoSize = true;
            this.MostLikedPostsRadioBUtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostLikedPostsRadioBUtton.Location = new System.Drawing.Point(4, 32);
            this.MostLikedPostsRadioBUtton.Margin = new System.Windows.Forms.Padding(2);
            this.MostLikedPostsRadioBUtton.Name = "MostLikedPostsRadioBUtton";
            this.MostLikedPostsRadioBUtton.Size = new System.Drawing.Size(71, 17);
            this.MostLikedPostsRadioBUtton.TabIndex = 2;
            this.MostLikedPostsRadioBUtton.TabStop = true;
            this.MostLikedPostsRadioBUtton.Text = "Most likes";
            this.MostLikedPostsRadioBUtton.UseVisualStyleBackColor = true;
            // 
            // PostOrderLabel
            // 
            this.PostOrderLabel.AutoSize = true;
            this.PostOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostOrderLabel.Location = new System.Drawing.Point(16, 2);
            this.PostOrderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PostOrderLabel.Name = "PostOrderLabel";
            this.PostOrderLabel.Size = new System.Drawing.Size(104, 15);
            this.PostOrderLabel.TabIndex = 0;
            this.PostOrderLabel.Text = "Order Posts by:";
            // 
            // txtBoxfilteredPosts
            // 
            this.txtBoxfilteredPosts.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxfilteredPosts.Location = new System.Drawing.Point(292, 231);
            this.txtBoxfilteredPosts.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxfilteredPosts.Multiline = true;
            this.txtBoxfilteredPosts.Name = "txtBoxfilteredPosts";
            this.txtBoxfilteredPosts.ReadOnly = true;
            this.txtBoxfilteredPosts.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxfilteredPosts.Size = new System.Drawing.Size(519, 182);
            this.txtBoxfilteredPosts.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(281, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(542, 213);
            this.label8.TabIndex = 35;
            this.label8.Text = "My filtered posts";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Magenta;
            this.label6.Location = new System.Drawing.Point(501, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Magenta;
            this.label5.Location = new System.Drawing.Point(297, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Choose time range to find which posts was created ";
            // 
            // PostsTextBox
            // 
            this.PostsTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.PostsTextBox.Location = new System.Drawing.Point(16, 61);
            this.PostsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PostsTextBox.Multiline = true;
            this.PostsTextBox.Name = "PostsTextBox";
            this.PostsTextBox.ReadOnly = true;
            this.PostsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PostsTextBox.Size = new System.Drawing.Size(248, 352);
            this.PostsTextBox.TabIndex = 30;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(390, 139);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(182, 20);
            this.txtBoxSearch.TabIndex = 28;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.searchBtn.Location = new System.Drawing.Point(578, 126);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(104, 41);
            this.searchBtn.TabIndex = 27;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchFilteredPosts_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(504, 96);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(180, 20);
            this.dateEnd.TabIndex = 25;
            // 
            // dateStart
            // 
            this.dateStart.AccessibleDescription = string.Empty;
            this.dateStart.Location = new System.Drawing.Point(297, 96);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(183, 20);
            this.dateStart.TabIndex = 24;
            this.dateStart.Value = new System.DateTime(2017, 6, 15, 0, 0, 0, 0);
            // 
            // userPostslabel
            // 
            this.userPostslabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userPostslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userPostslabel.Location = new System.Drawing.Point(6, 43);
            this.userPostslabel.Name = "userPostslabel";
            this.userPostslabel.Size = new System.Drawing.Size(268, 379);
            this.userPostslabel.TabIndex = 31;
            this.userPostslabel.Text = "My original posts";
            this.userPostslabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.userPostslabel.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(304, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = " type a sentence";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage2.Controls.Add(this.btnFindFriendData);
            this.tabPage2.Controls.Add(this.checkBoxFemale);
            this.tabPage2.Controls.Add(this.checkBoxMale);
            this.tabPage2.Controls.Add(this.upDownMaxAge);
            this.tabPage2.Controls.Add(this.upDownMinAge);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.friendsListBoxSameStarSign);
            this.tabPage2.Controls.Add(this.friendsListBoxdifferentStarSign);
            this.tabPage2.Controls.Add(this.txtBoxStarSignName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.friendsWithDifferentStarSign);
            this.tabPage2.Controls.Add(this.friendsWithTheSameStarSign);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtBoxStarSignContent);
            this.tabPage2.Controls.Add(this.profilePicture);
            this.tabPage2.Controls.Add(this.pictureBoxFriendProfilePicture);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.ForeColor = System.Drawing.Color.Blue;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "StarSignFinder";
            // 
            // btnFindFriendData
            // 
            this.btnFindFriendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFindFriendData.Location = new System.Drawing.Point(318, 371);
            this.btnFindFriendData.Name = "btnFindFriendData";
            this.btnFindFriendData.Size = new System.Drawing.Size(133, 36);
            this.btnFindFriendData.TabIndex = 61;
            this.btnFindFriendData.Text = "Find";
            this.btnFindFriendData.UseVisualStyleBackColor = true;
            this.btnFindFriendData.Click += new System.EventHandler(this.btnFindFriendData_Click);
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Checked = true;
            this.checkBoxFemale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxFemale.ForeColor = System.Drawing.Color.Magenta;
            this.checkBoxFemale.Location = new System.Drawing.Point(139, 311);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(79, 20);
            this.checkBoxFemale.TabIndex = 59;
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Checked = true;
            this.checkBoxMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxMale.ForeColor = System.Drawing.Color.Lime;
            this.checkBoxMale.Location = new System.Drawing.Point(49, 311);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(61, 20);
            this.checkBoxMale.TabIndex = 58;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            // 
            // upDownMaxAge
            // 
            this.upDownMaxAge.Location = new System.Drawing.Point(164, 410);
            this.upDownMaxAge.Name = "upDownMaxAge";
            this.upDownMaxAge.Size = new System.Drawing.Size(72, 20);
            this.upDownMaxAge.TabIndex = 57;
            this.upDownMaxAge.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // upDownMinAge
            // 
            this.upDownMinAge.Location = new System.Drawing.Point(47, 410);
            this.upDownMinAge.Name = "upDownMinAge";
            this.upDownMinAge.Size = new System.Drawing.Size(70, 20);
            this.upDownMinAge.TabIndex = 56;
            this.upDownMinAge.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(161, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 55;
            this.label12.Text = "Max age";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(44, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Min age";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(29, 363);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 79);
            this.label10.TabIndex = 51;
            this.label10.Text = "Select friends by age range";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(29, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 50);
            this.label9.TabIndex = 50;
            this.label9.Text = "Select friends by gender";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // friendsListBoxSameStarSign
            // 
            this.friendsListBoxSameStarSign.FormattingEnabled = true;
            this.friendsListBoxSameStarSign.Location = new System.Drawing.Point(163, 107);
            this.friendsListBoxSameStarSign.Name = "friendsListBoxSameStarSign";
            this.friendsListBoxSameStarSign.Size = new System.Drawing.Size(121, 160);
            this.friendsListBoxSameStarSign.TabIndex = 47;
            this.friendsListBoxSameStarSign.SelectedIndexChanged += new System.EventHandler(this.friendsBoxWithTheSameStarSign_SelectedIndexChanged);
            // 
            // friendsListBoxdifferentStarSign
            // 
            this.friendsListBoxdifferentStarSign.FormattingEnabled = true;
            this.friendsListBoxdifferentStarSign.Location = new System.Drawing.Point(11, 107);
            this.friendsListBoxdifferentStarSign.Name = "friendsListBoxdifferentStarSign";
            this.friendsListBoxdifferentStarSign.Size = new System.Drawing.Size(117, 160);
            this.friendsListBoxdifferentStarSign.TabIndex = 46;
            this.friendsListBoxdifferentStarSign.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.friendsBoxWtihDifferentStarSign_MouseDoubleClick);
            // 
            // txtBoxStarSignName
            // 
            this.txtBoxStarSignName.Location = new System.Drawing.Point(331, 95);
            this.txtBoxStarSignName.Name = "txtBoxStarSignName";
            this.txtBoxStarSignName.ReadOnly = true;
            this.txtBoxStarSignName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStarSignName.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(328, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 51);
            this.label2.TabIndex = 48;
            this.label2.Text = "My friend zodiac sign is:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // friendsWithDifferentStarSign
            // 
            this.friendsWithDifferentStarSign.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.friendsWithDifferentStarSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.friendsWithDifferentStarSign.ForeColor = System.Drawing.Color.Blue;
            this.friendsWithDifferentStarSign.Location = new System.Drawing.Point(6, 41);
            this.friendsWithDifferentStarSign.Name = "friendsWithDifferentStarSign";
            this.friendsWithDifferentStarSign.Size = new System.Drawing.Size(128, 237);
            this.friendsWithDifferentStarSign.TabIndex = 42;
            this.friendsWithDifferentStarSign.Text = "Friends with \r\ndifferent zodiac sign";
            this.friendsWithDifferentStarSign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // friendsWithTheSameStarSign
            // 
            this.friendsWithTheSameStarSign.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.friendsWithTheSameStarSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.friendsWithTheSameStarSign.ForeColor = System.Drawing.Color.Blue;
            this.friendsWithTheSameStarSign.Location = new System.Drawing.Point(160, 41);
            this.friendsWithTheSameStarSign.Name = "friendsWithTheSameStarSign";
            this.friendsWithTheSameStarSign.Size = new System.Drawing.Size(132, 237);
            this.friendsWithTheSameStarSign.TabIndex = 41;
            this.friendsWithTheSameStarSign.Text = "Friends with\r\nthe same\r\nzodiac sign\r\nas yours";
            this.friendsWithTheSameStarSign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(315, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "About the zodiac sign:";
            // 
            // txtBoxStarSignContent
            // 
            this.txtBoxStarSignContent.Location = new System.Drawing.Point(318, 206);
            this.txtBoxStarSignContent.Multiline = true;
            this.txtBoxStarSignContent.Name = "txtBoxStarSignContent";
            this.txtBoxStarSignContent.Size = new System.Drawing.Size(348, 114);
            this.txtBoxStarSignContent.TabIndex = 39;
            // 
            // profilePicture
            // 
            this.profilePicture.AutoSize = true;
            this.profilePicture.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.profilePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.profilePicture.Location = new System.Drawing.Point(497, 19);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(170, 16);
            this.profilePicture.TabIndex = 38;
            this.profilePicture.Text = "My friend profile picture";
            // 
            // pictureBoxFriendProfilePicture
            // 
            this.pictureBoxFriendProfilePicture.Location = new System.Drawing.Point(525, 41);
            this.pictureBoxFriendProfilePicture.Name = "pictureBoxFriendProfilePicture";
            this.pictureBoxFriendProfilePicture.Size = new System.Drawing.Size(120, 130);
            this.pictureBoxFriendProfilePicture.TabIndex = 36;
            this.pictureBoxFriendProfilePicture.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 438);
            this.label7.TabIndex = 40;
            this.label7.Text = "Click on a friend from the lists\r\nto find his zodiac sign";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PostsUpdate
            // 
            this.PostsUpdate.AutoScroll = true;
            this.PostsUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PostsUpdate.Controls.Add(this.label16);
            this.PostsUpdate.Controls.Add(this.panel2);
            this.PostsUpdate.Controls.Add(this.label14);
            this.PostsUpdate.Controls.Add(this.albumListBox);
            this.PostsUpdate.Controls.Add(this.label13);
            this.PostsUpdate.Controls.Add(this.panel1);
            this.PostsUpdate.Controls.Add(this.PostUpdateBox);
            this.PostsUpdate.Location = new System.Drawing.Point(4, 22);
            this.PostsUpdate.Name = "PostsUpdate";
            this.PostsUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.PostsUpdate.Size = new System.Drawing.Size(826, 365);
            this.PostsUpdate.TabIndex = 2;
            this.PostsUpdate.Text = "ViewDetailedPostsAndAlbums";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label16.Location = new System.Drawing.Point(300, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(172, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "User Info in detailed";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(label15);
            this.panel2.Controls.Add(this.createdTimeTextBox1);
            this.panel2.Controls.Add(descriptionLabel);
            this.panel2.Controls.Add(this.descriptionTextBox);
            this.panel2.Controls.Add(imageAlbumLabel);
            this.panel2.Controls.Add(updateTimeLabel1);
            this.panel2.Controls.Add(this.updateTimeTextBox1);
            this.panel2.Controls.Add(this.imageAlbumPictureBox);
            this.panel2.Location = new System.Drawing.Point(245, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 191);
            this.panel2.TabIndex = 7;
            // 
            // createdTimeTextBox1
            // 
            this.createdTimeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true));
            this.createdTimeTextBox1.Location = new System.Drawing.Point(103, 16);
            this.createdTimeTextBox1.Name = "createdTimeTextBox1";
            this.createdTimeTextBox1.Size = new System.Drawing.Size(316, 20);
            this.createdTimeTextBox1.TabIndex = 1;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(103, 42);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(316, 20);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // updateTimeTextBox1
            // 
            this.updateTimeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "UpdateTime", true));
            this.updateTimeTextBox1.Location = new System.Drawing.Point(103, 68);
            this.updateTimeTextBox1.Name = "updateTimeTextBox1";
            this.updateTimeTextBox1.Size = new System.Drawing.Size(316, 20);
            this.updateTimeTextBox1.TabIndex = 7;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(185, 94);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(119, 92);
            this.imageAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAlbumPictureBox.TabIndex = 5;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(15, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "All user albums:";
            // 
            // albumListBox
            // 
            this.albumListBox.DataSource = this.albumBindingSource;
            this.albumListBox.DisplayMember = "Name";
            this.albumListBox.FormattingEnabled = true;
            this.albumListBox.Location = new System.Drawing.Point(15, 263);
            this.albumListBox.Name = "albumListBox";
            this.albumListBox.Size = new System.Drawing.Size(175, 186);
            this.albumListBox.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(15, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "All to users posts:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(this.createdTimeTextBox);
            this.panel1.Controls.Add(messageLabel);
            this.panel1.Controls.Add(this.messageTextBox);
            this.panel1.Controls.Add(updateTimeLabel);
            this.panel1.Controls.Add(this.updateTimeTextBox);
            this.panel1.Location = new System.Drawing.Point(245, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 186);
            this.panel1.TabIndex = 2;
            // 
            // createdTimeTextBox
            // 
            this.createdTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "CreatedTime", true));
            this.createdTimeTextBox.Location = new System.Drawing.Point(103, 37);
            this.createdTimeTextBox.Name = "createdTimeTextBox";
            this.createdTimeTextBox.Size = new System.Drawing.Size(316, 20);
            this.createdTimeTextBox.TabIndex = 8;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(103, 94);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(316, 76);
            this.messageTextBox.TabIndex = 5;
            // 
            // updateTimeTextBox
            // 
            this.updateTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "UpdateTime", true));
            this.updateTimeTextBox.Location = new System.Drawing.Point(103, 66);
            this.updateTimeTextBox.Name = "updateTimeTextBox";
            this.updateTimeTextBox.Size = new System.Drawing.Size(316, 20);
            this.updateTimeTextBox.TabIndex = 7;
            // 
            // PostUpdateBox
            // 
            this.PostUpdateBox.DataSource = this.postBindingSource;
            this.PostUpdateBox.DisplayMember = "Message";
            this.PostUpdateBox.FormattingEnabled = true;
            this.PostUpdateBox.Location = new System.Drawing.Point(15, 46);
            this.PostUpdateBox.Name = "PostUpdateBox";
            this.PostUpdateBox.Size = new System.Drawing.Size(190, 186);
            this.PostUpdateBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(886, 671);
            this.Controls.Add(this.searchFeature);
            this.Controls.Add(this.rememberUserCheckBox);
            this.Controls.Add(this.userInfoLabel);
            this.Controls.Add(this.BasicUserInfoTextBox);
            this.Controls.Add(this.LoginOrDisconnectPictureBox);
            this.Controls.Add(this.UserProfilePictureBox);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginOrDisconnectPictureBox)).EndInit();
            this.searchFeature.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.PostOrderPanel.ResumeLayout(false);
            this.PostOrderPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMaxAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriendProfilePicture)).EndInit();
            this.PostsUpdate.ResumeLayout(false);
            this.PostsUpdate.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox UserProfilePictureBox;
        private System.Windows.Forms.PictureBox LoginOrDisconnectPictureBox;
        private System.Windows.Forms.TextBox BasicUserInfoTextBox;
        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.CheckBox rememberUserCheckBox;
        private System.Windows.Forms.TabControl searchFeature;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox PostsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox txtBoxfilteredPosts;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label friendsWithDifferentStarSign;
        private System.Windows.Forms.Label friendsWithTheSameStarSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxStarSignContent;
        private System.Windows.Forms.Label profilePicture;
        private System.Windows.Forms.PictureBox pictureBoxFriendProfilePicture;
        private System.Windows.Forms.ListBox friendsListBoxSameStarSign;
        private System.Windows.Forms.ListBox friendsListBoxdifferentStarSign;
        private System.Windows.Forms.TextBox txtBoxStarSignName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label userPostslabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown upDownMinAge;
        private System.Windows.Forms.NumericUpDown upDownMaxAge;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.Button btnFindFriendData;
        private System.Windows.Forms.TabPage PostsUpdate;
        private System.Windows.Forms.ListBox PostUpdateBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox createdTimeTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox updateTimeTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.ListBox albumListBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox createdTimeTextBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox updateTimeTextBox1;
        private System.Windows.Forms.PictureBox imageAlbumPictureBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel PostOrderPanel;
        private System.Windows.Forms.RadioButton SortingByDateBtn;
        private System.Windows.Forms.RadioButton MostCommentsRadioButton;
        private System.Windows.Forms.RadioButton MostLikedPostsRadioBUtton;
        private System.Windows.Forms.Label PostOrderLabel;
    }
}
