using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace BasicFacebookFeatures
{
    internal partial class FormMain : Form
    {
        private User m_User;
        private User m_FriendToGuess;
        private Post m_PostToGuess;
        private bool m_IsPostToGuessFromList;
        private FeatureFacade m_FeatureFacade;

        internal FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Thread loginThread = new Thread(loginProcess);
            loginThread.Start();
        }

        private void loginProcess()
        {
            if (FacebookAuthenticationManager.Instance.m_LoggedInUser == null)
            {
                bool isLoggedIn = FacebookAuthenticationManager.Instance.Login("749307766594184", "email", "public_profile", "user_posts", "user_birthday", "user_friends");
                if (isLoggedIn)
                {
                    Invoke(new Action(() =>
                    {
                        m_User = FacebookAuthenticationManager.Instance.m_LoggedInUser;
                        IBirthdayCountdownStrategy birthdayCountdownStrategy = new SimpleBirthdayCountdownStrategy();
                        IPostAnalyzerStrategy postAnalyzerStrategy = new SimplePostAnalyzerStrategy();
                        m_FeatureFacade = new FeatureFacade(m_User, birthdayCountdownStrategy, postAnalyzerStrategy);

                        initRandomFriendAndPost();

                        buttonLogin.Text = $"Logged in as {m_User.Name}";
                        buttonLogin.BackColor = Color.LightGreen;
                        enableButtonsAfterLogin();
                    }));
                }
            }
        }

        private void initRandomFriendAndPost()
        {
            new Thread(() =>
            {
                Invoke(new Action(() =>
                {
                    showGuessBirthdayMonth();
                }));
            }).Start();

            new Thread(() =>
            {
                Invoke(new Action(() =>
                {
                    showGuessPostYear();
                }));
            }).Start();
        }

        private void enableButtonsAfterLogin()
        {
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            buttonBirthdayCountdown.Enabled = true;
            buttonNewBirthdayGuess.Enabled = true;
            buttonNewPostGuess.Enabled = true;
            buttonShowPostsList.Enabled = true;
            comboBoxNumberOfPostPeriodsOfTime.Enabled = true;
            comboBoxGuessBirthdayMonth.Enabled = true;
            comboBoxGuessPostYear.Enabled = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                FacebookAuthenticationManager.Instance.Logout();

                Invoke(new Action(() =>
                {
                    buttonLogin.Text = "Login";
                    buttonLogin.BackColor = buttonLogout.BackColor;
                    disableButtonsAfterLogout();
                }));
            }).Start();
        }

        private void disableButtonsAfterLogout()
        {
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            buttonBirthdayCountdown.Enabled = false;
            buttonNewBirthdayGuess.Enabled = false;
            buttonNewPostGuess.Enabled = false;
            buttonShowPostsList.Enabled = false;
            comboBoxNumberOfPostPeriodsOfTime.Enabled = false;
            comboBoxGuessBirthdayMonth.Enabled = false;
            comboBoxGuessPostYear.Enabled = false;
        }

        private void buttonBirthdayCounter_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                TimeSpan timeSpan = m_FeatureFacade.GetTimeUntilNextBirthday();
                updateUIAfterBirthdayCalculation(timeSpan);
            }).Start();
        }

        private void updateUIAfterBirthdayCalculation(TimeSpan i_TimeSpan)
        {
            Invoke(new Action(() =>
            {
                labelBirthdayCountdown.Visible = true;
                labelBirthdayCountdown.Text = $"Time until next birthday: {i_TimeSpan.Days} days, {i_TimeSpan.Hours} hours, {i_TimeSpan.Minutes} minutes.";
            }));
        }

        private void showGuessBirthdayMonth()
        {
            m_FriendToGuess = m_FeatureFacade.GetRandomFriend();
            labelFriendName.Text = (m_FriendToGuess == null) ? "No friends exists!" : m_FriendToGuess.Name;
        }

        private void buttonNumberOfPostInPeriodOfTime_Click(object sender, EventArgs e)
        {
            string selectedPeriodOption = comboBoxNumberOfPostPeriodsOfTime.SelectedItem.ToString();
            labelPleaseWait.Visible = true;
            labelPleaseWait.Text = "Please wait...";
            countPostsInBackground(selectedPeriodOption);
        }

        private void countPostsInBackground(string selectedPeriodOption)
        {
            new Thread(() =>
            {
                int postCount = m_FeatureFacade.CountPostsInPeriod(selectedPeriodOption);
                updateUIAfterCountingPosts(postCount);
            }).Start();
        }

        private void updateUIAfterCountingPosts(int i_PostCount)
        {
            Invoke(new Action(() =>
            {
                labelNumberOfPostsInPeriodOfTime.Visible = true;
                labelNumberOfPostsInPeriodOfTime.Text = $"{i_PostCount} posts found";
                labelPleaseWait.Visible = false;
            }));
        }

        private void showGuessPostYear()
        {
            m_PostToGuess = m_FeatureFacade.GetRandomPost();
            messageTextBox.Text = (m_PostToGuess == null) ? "No posts exists!" : m_PostToGuess.Message;
            m_IsPostToGuessFromList = false;
        }

        private void comboBoxStatistical_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonNumberOfPostInPeriodOfTime.Enabled = comboBoxNumberOfPostPeriodsOfTime.SelectedIndex != -1;
        }

        private void comboBoxGuessBirthdayMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGuessBirthdayMonth.Enabled = comboBoxGuessBirthdayMonth.SelectedIndex != -1;
        }

        private void comboBoxGuessPostYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGuessYear.Enabled = comboBoxGuessPostYear.SelectedIndex != -1;
        }

        private void buttonGuessYear_Click(object sender, EventArgs e)
        {
            new Thread(processPostGuessYear).Start();
        }

        private void processPostGuessYear()
        {
            checkIsPostToGuessFromList();
            checkYearGuess(getSelectedYearOption());
        }

        private void checkIsPostToGuessFromList()
        {
            if (m_IsPostToGuessFromList)
            {
                m_PostToGuess = postBindingSource.Current as Post;
            }
        }
        
        private string getSelectedYearOption()
        { 
            string selectedYearOption = string.Empty;
        
            Invoke(new Action(() =>
            {
                if (m_PostToGuess != null)
                {
                    selectedYearOption = comboBoxGuessPostYear.SelectedItem.ToString();
                }
            }));

            return selectedYearOption;
        }

        private void checkYearGuess(string i_SelectedYearOption)
        {
            if (m_PostToGuess != null)
            {
                bool isCorrect = i_SelectedYearOption.Equals(m_PostToGuess.CreatedTime.Value.Year.ToString());

                Invoke(new Action(() =>
                {
                    labelIsPostGuessCorrect.Text = isCorrect ? "YOUR GUESS IS CORRECT!!!" : "your guess is wrong";
                    labelIsPostGuessCorrect.ForeColor = isCorrect ? Color.PaleGreen : Color.Red;
                }));
            }
        }

        private void buttonNewPostGuess_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Post postToGuess = m_FeatureFacade.GetRandomPost();
                m_IsPostToGuessFromList = false;

                Invoke(new Action(() =>
                {
                    m_PostToGuess = postToGuess;
                    messageTextBox.Text = (m_PostToGuess == null) ? "No posts exists!" : m_PostToGuess.Message;
                }));
            }).Start();
        }

        private void buttonNewBirthdayGuess_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                User friendToGuess = m_FeatureFacade.GetRandomFriend();

                Invoke(new Action(() =>
                {
                    m_FriendToGuess = friendToGuess;
                    labelFriendName.ForeColor = Color.Black;
                    labelFriendName.Text = (m_FriendToGuess == null) ? "No friends exists!" : m_FriendToGuess.Name;
                }));
            }).Start();
        }

        private void buttonGuessBirthdayMonth_Click(object sender, EventArgs e)
        {
            int selectedMonthNumber = m_FeatureFacade.ConvertMonthStringToInt(comboBoxGuessBirthdayMonth.SelectedItem.ToString());

            if (m_FriendToGuess != null)
            {
                BirthdayFeature friendBirthday = FeatureFactory.CreateBirthdayFeature(m_FriendToGuess.Birthday);
                bool isCorrectGuess = selectedMonthNumber == friendBirthday.GetBirthdayMonth();
                
                Invoke(new Action(() =>
                {
                    labelFriendName.Text = isCorrectGuess ? "YOUR GUESS IS CORRECT!!!" : "your guess is wrong";
                    labelFriendName.ForeColor = isCorrectGuess ? Color.PaleGreen : Color.Red;
                }));
            }
        }

        private void buttonShowPostsList_Click(object sender, EventArgs e)
        {
            postBindingSource.DataSource = m_User.Posts;
        }

        private void listBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_IsPostToGuessFromList = true;
        }
    }
}