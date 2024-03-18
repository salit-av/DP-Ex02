namespace BasicFacebookFeatures
{
    internal partial class FormMain
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
            this.tabPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelBirthdayTitle = new System.Windows.Forms.Label();
            this.buttonBirthdayCountdown = new System.Windows.Forms.Button();
            this.labelBirthdayCountdown = new System.Windows.Forms.Label();
            this.labelBirthdayExplain = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelIsPostGuessCorrect = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowPostsList = new System.Windows.Forms.Button();
            this.labelGuessPost = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxGuessPostYear = new System.Windows.Forms.ComboBox();
            this.listBoxPhotos = new System.Windows.Forms.ListBox();
            this.buttonNewPostGuess = new System.Windows.Forms.Button();
            this.buttonGuessYear = new System.Windows.Forms.Button();
            this.labelWinFormTitle = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelBirthday = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNewBirthdayGuess = new System.Windows.Forms.Button();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.buttonGuessBirthdayMonth = new System.Windows.Forms.Button();
            this.comboBoxGuessBirthdayMonth = new System.Windows.Forms.ComboBox();
            this.labelGuessFriendBirthday = new System.Windows.Forms.Label();
            this.panelPostsData = new System.Windows.Forms.Panel();
            this.labelPleaseWait = new System.Windows.Forms.Label();
            this.labelNumberOfPostExplain = new System.Windows.Forms.Label();
            this.labelPostsDataTitle = new System.Windows.Forms.Label();
            this.buttonNumberOfPostInPeriodOfTime = new System.Windows.Forms.Button();
            this.labelNumberOfPostsInPeriodOfTime = new System.Windows.Forms.Label();
            this.comboBoxNumberOfPostPeriodsOfTime = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.panelBirthday.SuspendLayout();
            this.panelPostsData.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.AutoScroll = true;
            this.tabPage.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage.Controls.Add(this.panel3);
            this.tabPage.Controls.Add(this.panel2);
            this.tabPage.Controls.Add(this.labelWinFormTitle);
            this.tabPage.Controls.Add(this.buttonLogout);
            this.tabPage.Controls.Add(this.buttonLogin);
            this.tabPage.Controls.Add(this.panelBirthday);
            this.tabPage.Controls.Add(this.panelPostsData);
            this.tabPage.Location = new System.Drawing.Point(4, 27);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(1187, 676);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "FacebookWinFormsApp";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.labelBirthdayTitle);
            this.panel3.Controls.Add(this.buttonBirthdayCountdown);
            this.panel3.Controls.Add(this.labelBirthdayCountdown);
            this.panel3.Controls.Add(this.labelBirthdayExplain);
            this.panel3.Location = new System.Drawing.Point(18, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 168);
            this.panel3.TabIndex = 67;
            // 
            // labelBirthdayTitle
            // 
            this.labelBirthdayTitle.AutoSize = true;
            this.labelBirthdayTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdayTitle.Location = new System.Drawing.Point(116, 11);
            this.labelBirthdayTitle.Name = "labelBirthdayTitle";
            this.labelBirthdayTitle.Size = new System.Drawing.Size(234, 31);
            this.labelBirthdayTitle.TabIndex = 56;
            this.labelBirthdayTitle.Text = "Birthday Counter";
            // 
            // buttonBirthdayCountdown
            // 
            this.buttonBirthdayCountdown.Enabled = false;
            this.buttonBirthdayCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBirthdayCountdown.Location = new System.Drawing.Point(180, 82);
            this.buttonBirthdayCountdown.Name = "buttonBirthdayCountdown";
            this.buttonBirthdayCountdown.Size = new System.Drawing.Size(101, 37);
            this.buttonBirthdayCountdown.TabIndex = 60;
            this.buttonBirthdayCountdown.Text = "Find out!";
            this.buttonBirthdayCountdown.UseVisualStyleBackColor = true;
            this.buttonBirthdayCountdown.Click += new System.EventHandler(this.buttonBirthdayCounter_Click);
            // 
            // labelBirthdayCountdown
            // 
            this.labelBirthdayCountdown.AutoSize = true;
            this.labelBirthdayCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdayCountdown.Location = new System.Drawing.Point(27, 133);
            this.labelBirthdayCountdown.Name = "labelBirthdayCountdown";
            this.labelBirthdayCountdown.Size = new System.Drawing.Size(422, 17);
            this.labelBirthdayCountdown.TabIndex = 59;
            this.labelBirthdayCountdown.Text = "Time until next birthday: 000 days, 00 hours, 00 minutes.";
            this.labelBirthdayCountdown.Visible = false;
            // 
            // labelBirthdayExplain
            // 
            this.labelBirthdayExplain.AutoSize = true;
            this.labelBirthdayExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdayExplain.Location = new System.Drawing.Point(92, 52);
            this.labelBirthdayExplain.Name = "labelBirthdayExplain";
            this.labelBirthdayExplain.Size = new System.Drawing.Size(267, 18);
            this.labelBirthdayExplain.TabIndex = 60;
            this.labelBirthdayExplain.Text = " Find out your birthday countdown!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.labelIsPostGuessCorrect);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonShowPostsList);
            this.panel2.Controls.Add(this.labelGuessPost);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.comboBoxGuessPostYear);
            this.panel2.Controls.Add(this.listBoxPhotos);
            this.panel2.Controls.Add(this.buttonNewPostGuess);
            this.panel2.Controls.Add(this.buttonGuessYear);
            this.panel2.Location = new System.Drawing.Point(525, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 558);
            this.panel2.TabIndex = 66;
            // 
            // labelIsPostGuessCorrect
            // 
            this.labelIsPostGuessCorrect.ForeColor = System.Drawing.Color.Black;
            this.labelIsPostGuessCorrect.Location = new System.Drawing.Point(212, 512);
            this.labelIsPostGuessCorrect.Name = "labelIsPostGuessCorrect";
            this.labelIsPostGuessCorrect.Size = new System.Drawing.Size(273, 39);
            this.labelIsPostGuessCorrect.TabIndex = 68;
            this.labelIsPostGuessCorrect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 31);
            this.label2.TabIndex = 70;
            this.label2.Text = "Posts Guesses";
            // 
            // buttonShowPostsList
            // 
            this.buttonShowPostsList.Enabled = false;
            this.buttonShowPostsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowPostsList.Location = new System.Drawing.Point(380, 117);
            this.buttonShowPostsList.Name = "buttonShowPostsList";
            this.buttonShowPostsList.Size = new System.Drawing.Size(204, 37);
            this.buttonShowPostsList.TabIndex = 67;
            this.buttonShowPostsList.Text = "Click for posts list";
            this.buttonShowPostsList.UseVisualStyleBackColor = true;
            this.buttonShowPostsList.Click += new System.EventHandler(this.buttonShowPostsList_Click);
            // 
            // labelGuessPost
            // 
            this.labelGuessPost.AutoSize = true;
            this.labelGuessPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuessPost.Location = new System.Drawing.Point(135, 70);
            this.labelGuessPost.Name = "labelGuessPost";
            this.labelGuessPost.Size = new System.Drawing.Size(399, 18);
            this.labelGuessPost.TabIndex = 65;
            this.labelGuessPost.Text = "Will you dare to guess when you published a post?  ";
            this.labelGuessPost.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.messageTextBox);
            this.panel1.Location = new System.Drawing.Point(19, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 256);
            this.panel1.TabIndex = 68;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(0, 0);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(291, 256);
            this.messageTextBox.TabIndex = 1;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // comboBoxGuessPostYear
            // 
            this.comboBoxGuessPostYear.Enabled = false;
            this.comboBoxGuessPostYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGuessPostYear.FormattingEnabled = true;
            this.comboBoxGuessPostYear.Items.AddRange(new object[] {
            "2024",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014"});
            this.comboBoxGuessPostYear.Location = new System.Drawing.Point(157, 466);
            this.comboBoxGuessPostYear.Name = "comboBoxGuessPostYear";
            this.comboBoxGuessPostYear.Size = new System.Drawing.Size(112, 26);
            this.comboBoxGuessPostYear.TabIndex = 66;
            this.comboBoxGuessPostYear.Text = "Select Year";
            this.comboBoxGuessPostYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxGuessPostYear_SelectedIndexChanged);
            // 
            // listBoxPhotos
            // 
            this.listBoxPhotos.DataSource = this.postBindingSource;
            this.listBoxPhotos.DisplayMember = "Message";
            this.listBoxPhotos.FormattingEnabled = true;
            this.listBoxPhotos.ItemHeight = 18;
            this.listBoxPhotos.Location = new System.Drawing.Point(333, 173);
            this.listBoxPhotos.Name = "listBoxPhotos";
            this.listBoxPhotos.Size = new System.Drawing.Size(294, 256);
            this.listBoxPhotos.TabIndex = 66;
            this.listBoxPhotos.SelectedIndexChanged += new System.EventHandler(this.listBoxPhotos_SelectedIndexChanged);
            // 
            // buttonNewPostGuess
            // 
            this.buttonNewPostGuess.Enabled = false;
            this.buttonNewPostGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewPostGuess.Location = new System.Drawing.Point(65, 117);
            this.buttonNewPostGuess.Name = "buttonNewPostGuess";
            this.buttonNewPostGuess.Size = new System.Drawing.Size(204, 37);
            this.buttonNewPostGuess.TabIndex = 70;
            this.buttonNewPostGuess.Text = "Click for Random Post";
            this.buttonNewPostGuess.UseVisualStyleBackColor = true;
            this.buttonNewPostGuess.Click += new System.EventHandler(this.buttonNewPostGuess_Click);
            // 
            // buttonGuessYear
            // 
            this.buttonGuessYear.Enabled = false;
            this.buttonGuessYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuessYear.Location = new System.Drawing.Point(396, 460);
            this.buttonGuessYear.Name = "buttonGuessYear";
            this.buttonGuessYear.Size = new System.Drawing.Size(138, 37);
            this.buttonGuessYear.TabIndex = 67;
            this.buttonGuessYear.Text = "Check Yourself";
            this.buttonGuessYear.UseVisualStyleBackColor = true;
            this.buttonGuessYear.Click += new System.EventHandler(this.buttonGuessYear_Click);
            // 
            // labelWinFormTitle
            // 
            this.labelWinFormTitle.AutoSize = true;
            this.labelWinFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinFormTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelWinFormTitle.Location = new System.Drawing.Point(173, 28);
            this.labelWinFormTitle.Name = "labelWinFormTitle";
            this.labelWinFormTitle.Size = new System.Drawing.Size(994, 46);
            this.labelWinFormTitle.TabIndex = 63;
            this.labelWinFormTitle.Text = "WELCOME TO FACEBOOK DATA AND GUESSES!";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 63);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(148, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(148, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panelBirthday
            // 
            this.panelBirthday.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelBirthday.Controls.Add(this.label1);
            this.panelBirthday.Controls.Add(this.buttonNewBirthdayGuess);
            this.panelBirthday.Controls.Add(this.labelFriendName);
            this.panelBirthday.Controls.Add(this.buttonGuessBirthdayMonth);
            this.panelBirthday.Controls.Add(this.comboBoxGuessBirthdayMonth);
            this.panelBirthday.Controls.Add(this.labelGuessFriendBirthday);
            this.panelBirthday.Location = new System.Drawing.Point(18, 476);
            this.panelBirthday.Name = "panelBirthday";
            this.panelBirthday.Size = new System.Drawing.Size(484, 193);
            this.panelBirthday.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 61;
            this.label1.Text = "Birthday Guesses";
            // 
            // buttonNewBirthdayGuess
            // 
            this.buttonNewBirthdayGuess.Enabled = false;
            this.buttonNewBirthdayGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewBirthdayGuess.Location = new System.Drawing.Point(331, 138);
            this.buttonNewBirthdayGuess.Name = "buttonNewBirthdayGuess";
            this.buttonNewBirthdayGuess.Size = new System.Drawing.Size(118, 37);
            this.buttonNewBirthdayGuess.TabIndex = 71;
            this.buttonNewBirthdayGuess.Text = "New Guess";
            this.buttonNewBirthdayGuess.UseVisualStyleBackColor = true;
            this.buttonNewBirthdayGuess.Click += new System.EventHandler(this.buttonNewBirthdayGuess_Click);
            // 
            // labelFriendName
            // 
            this.labelFriendName.ForeColor = System.Drawing.Color.Black;
            this.labelFriendName.Location = new System.Drawing.Point(60, 95);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(324, 36);
            this.labelFriendName.TabIndex = 69;
            this.labelFriendName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelFriendName.UseWaitCursor = true;
            // 
            // buttonGuessBirthdayMonth
            // 
            this.buttonGuessBirthdayMonth.Enabled = false;
            this.buttonGuessBirthdayMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuessBirthdayMonth.Location = new System.Drawing.Point(163, 138);
            this.buttonGuessBirthdayMonth.Name = "buttonGuessBirthdayMonth";
            this.buttonGuessBirthdayMonth.Size = new System.Drawing.Size(139, 37);
            this.buttonGuessBirthdayMonth.TabIndex = 69;
            this.buttonGuessBirthdayMonth.Text = "Check Yourself";
            this.buttonGuessBirthdayMonth.UseVisualStyleBackColor = true;
            this.buttonGuessBirthdayMonth.Click += new System.EventHandler(this.buttonGuessBirthdayMonth_Click);
            // 
            // comboBoxGuessBirthdayMonth
            // 
            this.comboBoxGuessBirthdayMonth.Enabled = false;
            this.comboBoxGuessBirthdayMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGuessBirthdayMonth.FormattingEnabled = true;
            this.comboBoxGuessBirthdayMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxGuessBirthdayMonth.Location = new System.Drawing.Point(13, 144);
            this.comboBoxGuessBirthdayMonth.Name = "comboBoxGuessBirthdayMonth";
            this.comboBoxGuessBirthdayMonth.Size = new System.Drawing.Size(121, 26);
            this.comboBoxGuessBirthdayMonth.TabIndex = 69;
            this.comboBoxGuessBirthdayMonth.Text = "Select Month";
            this.comboBoxGuessBirthdayMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxGuessBirthdayMonth_SelectedIndexChanged);
            // 
            // labelGuessFriendBirthday
            // 
            this.labelGuessFriendBirthday.AutoSize = true;
            this.labelGuessFriendBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuessFriendBirthday.ForeColor = System.Drawing.Color.Black;
            this.labelGuessFriendBirthday.Location = new System.Drawing.Point(46, 57);
            this.labelGuessFriendBirthday.Name = "labelGuessFriendBirthday";
            this.labelGuessFriendBirthday.Size = new System.Drawing.Size(386, 18);
            this.labelGuessFriendBirthday.TabIndex = 69;
            this.labelGuessFriendBirthday.Text = "Will you dare to guess your friend birthday month?";
            // 
            // panelPostsData
            // 
            this.panelPostsData.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelPostsData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPostsData.Controls.Add(this.labelPleaseWait);
            this.panelPostsData.Controls.Add(this.labelNumberOfPostExplain);
            this.panelPostsData.Controls.Add(this.labelPostsDataTitle);
            this.panelPostsData.Controls.Add(this.buttonNumberOfPostInPeriodOfTime);
            this.panelPostsData.Controls.Add(this.labelNumberOfPostsInPeriodOfTime);
            this.panelPostsData.Controls.Add(this.comboBoxNumberOfPostPeriodsOfTime);
            this.panelPostsData.Location = new System.Drawing.Point(18, 111);
            this.panelPostsData.Name = "panelPostsData";
            this.panelPostsData.Size = new System.Drawing.Size(484, 169);
            this.panelPostsData.TabIndex = 65;
            // 
            // labelPleaseWait
            // 
            this.labelPleaseWait.AutoSize = true;
            this.labelPleaseWait.Location = new System.Drawing.Point(176, 133);
            this.labelPleaseWait.Name = "labelPleaseWait";
            this.labelPleaseWait.Size = new System.Drawing.Size(95, 18);
            this.labelPleaseWait.TabIndex = 69;
            this.labelPleaseWait.Text = "Please wait...";
            this.labelPleaseWait.Visible = false;
            // 
            // labelNumberOfPostExplain
            // 
            this.labelNumberOfPostExplain.AutoSize = true;
            this.labelNumberOfPostExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfPostExplain.Location = new System.Drawing.Point(33, 52);
            this.labelNumberOfPostExplain.Name = "labelNumberOfPostExplain";
            this.labelNumberOfPostExplain.Size = new System.Drawing.Size(415, 18);
            this.labelNumberOfPostExplain.TabIndex = 63;
            this.labelNumberOfPostExplain.Text = "Find out how many post you post at the selected time ";
            // 
            // labelPostsDataTitle
            // 
            this.labelPostsDataTitle.AutoSize = true;
            this.labelPostsDataTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostsDataTitle.Location = new System.Drawing.Point(156, 12);
            this.labelPostsDataTitle.Name = "labelPostsDataTitle";
            this.labelPostsDataTitle.Size = new System.Drawing.Size(153, 31);
            this.labelPostsDataTitle.TabIndex = 57;
            this.labelPostsDataTitle.Text = "Posts data";
            // 
            // buttonNumberOfPostInPeriodOfTime
            // 
            this.buttonNumberOfPostInPeriodOfTime.Enabled = false;
            this.buttonNumberOfPostInPeriodOfTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumberOfPostInPeriodOfTime.Location = new System.Drawing.Point(271, 82);
            this.buttonNumberOfPostInPeriodOfTime.Name = "buttonNumberOfPostInPeriodOfTime";
            this.buttonNumberOfPostInPeriodOfTime.Size = new System.Drawing.Size(101, 37);
            this.buttonNumberOfPostInPeriodOfTime.TabIndex = 58;
            this.buttonNumberOfPostInPeriodOfTime.Text = "Find out!";
            this.buttonNumberOfPostInPeriodOfTime.UseVisualStyleBackColor = true;
            this.buttonNumberOfPostInPeriodOfTime.Click += new System.EventHandler(this.buttonNumberOfPostInPeriodOfTime_Click);
            // 
            // labelNumberOfPostsInPeriodOfTime
            // 
            this.labelNumberOfPostsInPeriodOfTime.AutoSize = true;
            this.labelNumberOfPostsInPeriodOfTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfPostsInPeriodOfTime.Location = new System.Drawing.Point(115, 122);
            this.labelNumberOfPostsInPeriodOfTime.Name = "labelNumberOfPostsInPeriodOfTime";
            this.labelNumberOfPostsInPeriodOfTime.Size = new System.Drawing.Size(213, 31);
            this.labelNumberOfPostsInPeriodOfTime.TabIndex = 61;
            this.labelNumberOfPostsInPeriodOfTime.Text = "Number of posts";
            this.labelNumberOfPostsInPeriodOfTime.Visible = false;
            // 
            // comboBoxNumberOfPostPeriodsOfTime
            // 
            this.comboBoxNumberOfPostPeriodsOfTime.Enabled = false;
            this.comboBoxNumberOfPostPeriodsOfTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNumberOfPostPeriodsOfTime.FormattingEnabled = true;
            this.comboBoxNumberOfPostPeriodsOfTime.Items.AddRange(new object[] {
            "This Month",
            "Last 3 Months",
            "Last 12 Months",
            "Last Five Years",
            "Last Ten Years"});
            this.comboBoxNumberOfPostPeriodsOfTime.Location = new System.Drawing.Point(62, 88);
            this.comboBoxNumberOfPostPeriodsOfTime.Name = "comboBoxNumberOfPostPeriodsOfTime";
            this.comboBoxNumberOfPostPeriodsOfTime.Size = new System.Drawing.Size(158, 26);
            this.comboBoxNumberOfPostPeriodsOfTime.TabIndex = 62;
            this.comboBoxNumberOfPostPeriodsOfTime.Text = "Select Period";
            this.comboBoxNumberOfPostPeriodsOfTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatistical_SelectedIndexChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1195, 707);
            this.tabControl.TabIndex = 54;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 707);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacebookWinFormsApp";
            this.tabPage.ResumeLayout(false);
            this.tabPage.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.panelBirthday.ResumeLayout(false);
            this.panelBirthday.PerformLayout();
            this.panelPostsData.ResumeLayout(false);
            this.panelPostsData.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label labelBirthdayTitle;
        private System.Windows.Forms.Button buttonNumberOfPostInPeriodOfTime;
        private System.Windows.Forms.Label labelPostsDataTitle;
        private System.Windows.Forms.Label labelBirthdayCountdown;
        private System.Windows.Forms.Button buttonBirthdayCountdown;
        private System.Windows.Forms.Label labelNumberOfPostsInPeriodOfTime;
        private System.Windows.Forms.ComboBox comboBoxNumberOfPostPeriodsOfTime;
        private System.Windows.Forms.Label labelWinFormTitle;
        private System.Windows.Forms.Panel panelPostsData;
        private System.Windows.Forms.Panel panelBirthday;
        private System.Windows.Forms.Label labelBirthdayExplain;
        private System.Windows.Forms.Label labelNumberOfPostExplain;
        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.Button buttonGuessBirthdayMonth;
        private System.Windows.Forms.ComboBox comboBoxGuessBirthdayMonth;
        private System.Windows.Forms.Label labelGuessFriendBirthday;
        private System.Windows.Forms.Label labelIsPostGuessCorrect;
        private System.Windows.Forms.Button buttonGuessYear;
        private System.Windows.Forms.ComboBox comboBoxGuessPostYear;
        private System.Windows.Forms.Label labelGuessPost;
        private System.Windows.Forms.Label labelPleaseWait;
        private System.Windows.Forms.Button buttonNewPostGuess;
        private System.Windows.Forms.Button buttonNewBirthdayGuess;
        private System.Windows.Forms.ListBox listBoxPhotos;
        private System.Windows.Forms.Button buttonShowPostsList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox messageTextBox;
    }
}