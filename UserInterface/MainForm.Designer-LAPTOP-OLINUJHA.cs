namespace A20_Ex01_Ben_200400216_Maor_204686042
{
    partial class MainForm
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
            this.UserProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.LoginOrDisconnectPictureBox = new System.Windows.Forms.PictureBox();
            this.BasicUserInfoTextBox = new System.Windows.Forms.TextBox();
            this.PostsTextBox = new System.Windows.Forms.TextBox();
            this.PostsLabel = new System.Windows.Forms.Label();
            this.UserDetailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginOrDisconnectPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserProfilePictureBox
            // 
            this.UserProfilePictureBox.Location = new System.Drawing.Point(40, 80);
            this.UserProfilePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserProfilePictureBox.Name = "UserProfilePictureBox";
            this.UserProfilePictureBox.Size = new System.Drawing.Size(200, 200);
            this.UserProfilePictureBox.TabIndex = 1;
            this.UserProfilePictureBox.TabStop = false;
            this.UserProfilePictureBox.Click += new System.EventHandler(this.OnUserProfilePictureBox1_Click);
            // 
            // LoginOrDisconnectPictureBox
            // 
            this.LoginOrDisconnectPictureBox.Location = new System.Drawing.Point(40, 30);
            this.LoginOrDisconnectPictureBox.Name = "LoginOrDisconnectPictureBox";
            this.LoginOrDisconnectPictureBox.Size = new System.Drawing.Size(200, 50);
            this.LoginOrDisconnectPictureBox.TabIndex = 2;
            this.LoginOrDisconnectPictureBox.TabStop = false;
            this.LoginOrDisconnectPictureBox.Click += new System.EventHandler(this.LoginOrDisconnectPictureBox_Click);
            // 
            // BasicUserInfoTextBox
            // 
            this.BasicUserInfoTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BasicUserInfoTextBox.Location = new System.Drawing.Point(240, 80);
            this.BasicUserInfoTextBox.Multiline = true;
            this.BasicUserInfoTextBox.Name = "BasicUserInfoTextBox";
            this.BasicUserInfoTextBox.ReadOnly = true;
            this.BasicUserInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BasicUserInfoTextBox.Size = new System.Drawing.Size(200, 200);
            this.BasicUserInfoTextBox.TabIndex = 3;
            this.BasicUserInfoTextBox.Visible = false;
            // 
            // PostsTextBox
            // 
            this.PostsTextBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PostsTextBox.Location = new System.Drawing.Point(40, 310);
            this.PostsTextBox.Multiline = true;
            this.PostsTextBox.Name = "PostsTextBox";
            this.PostsTextBox.ReadOnly = true;
            this.PostsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PostsTextBox.Size = new System.Drawing.Size(400, 400);
            this.PostsTextBox.TabIndex = 4;
            // 
            // PostsLabel
            // 
            this.PostsLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PostsLabel.Location = new System.Drawing.Point(40, 280);
            this.PostsLabel.Name = "PostsLabel";
            this.PostsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PostsLabel.Size = new System.Drawing.Size(400, 30);
            this.PostsLabel.TabIndex = 5;
            this.PostsLabel.Text = "Posts";
            this.PostsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserDetailsLabel
            // 
            this.UserDetailsLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UserDetailsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserDetailsLabel.Location = new System.Drawing.Point(240, 30);
            this.UserDetailsLabel.Name = "UserDetailsLabel";
            this.UserDetailsLabel.Size = new System.Drawing.Size(200, 250);
            this.UserDetailsLabel.TabIndex = 6;
            this.UserDetailsLabel.Text = "User details";
            this.UserDetailsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1312, 753);
            this.Controls.Add(this.UserDetailsLabel);
            this.Controls.Add(this.PostsLabel);
            this.Controls.Add(this.PostsTextBox);
            this.Controls.Add(this.BasicUserInfoTextBox);
            this.Controls.Add(this.LoginOrDisconnectPictureBox);
            this.Controls.Add(this.UserProfilePictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginOrDisconnectPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox UserProfilePictureBox;
        private System.Windows.Forms.PictureBox LoginOrDisconnectPictureBox;
        private System.Windows.Forms.TextBox BasicUserInfoTextBox;
        private System.Windows.Forms.TextBox PostsTextBox;
        private System.Windows.Forms.Label PostsLabel;
        private System.Windows.Forms.Label UserDetailsLabel;
    }
}

