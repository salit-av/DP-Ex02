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
        private FeatureFacade m_FeatureFacade;
        private bool m_IsUserGuessedPostYear = false;
        private bool m_IsUserGuessedFriendBirthday = false;

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

                        buttonLogin.Text = $"Logged in as {m_User.Name}";
                        buttonLogin.BackColor = Color.LightGreen;
                        enableButtonsAfterLogin();
                    }));
                }
            }
        }

        private void enableButtonsAfterLogin()
        {
            comboBoxNumberOfPostPeriodsOfTime.Enabled = true;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            buttonBirthdayCountdown.Enabled = true;
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
            buttonNumberOfPostInPeriodOfTime.Enabled = false;
            comboBoxNumberOfPostPeriodsOfTime.Enabled = false;
        }

        private void buttonBirthdayCounter_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                TimeSpan timeSpan = m_FeatureFacade.GetTimeUntilNextBirthday();
                UpdateUIAfterBirthdayCalculation(timeSpan);
            }).Start();
        }

        private void UpdateUIAfterBirthdayCalculation(TimeSpan timeSpan)
        {
            Invoke(new Action(() =>
            {
                labelBirthdayCountdown.Visible = true;
                labelBirthdayCountdown.Text = $"Time until next birthday: {timeSpan.Days} days, {timeSpan.Hours} hours, {timeSpan.Minutes} minutes.";

                if (!m_IsUserGuessedFriendBirthday)
                {
                    showGuessBirthdayMonth();
                    m_IsUserGuessedFriendBirthday = true;
                }
            }));
        }


        private void showGuessBirthdayMonth()
        {
            m_FriendToGuess = m_FeatureFacade.GetRandomFriend();
            labelFriendName.Text = (m_FriendToGuess == null) ? "No friends exists!" : m_FriendToGuess.Name;
            visibleFormObjectsOfGuessFriendBirthdayMonth();
        }

        private void visibleFormObjectsOfGuessFriendBirthdayMonth()
        {
            comboBoxGuessBirthdayMonth.Visible = true;
            buttonGuessBirthdayMonth.Visible = true;
            buttonNewBirthdayGuess.Visible = true;
            labelInDevelopment.Visible = true;
            labelGuessFriendBirthday.Visible = true;
            labelFriendName.Visible = true;
        }
        private void buttonNumberOfPostInPeriodOfTime_Click(object sender, EventArgs e)
        {
            string selectedPeriodOption = comboBoxNumberOfPostPeriodsOfTime.SelectedItem.ToString();
            labelPleaseWait.Visible = true;
            labelPleaseWait.Text = "Please wait...";
            CountPostsInBackground(selectedPeriodOption);
        }

        private void CountPostsInBackground(string selectedPeriodOption)
        {
            new Thread(() =>
            {
                int postCount = m_FeatureFacade.CountPostsInPeriod(selectedPeriodOption);
                UpdateUIAfterCountingPosts(postCount);
            }).Start();
        }

        private void UpdateUIAfterCountingPosts(int postCount)
        {
            Invoke(new Action(() =>
            {
                labelNumberOfPostsInPeriodOfTime.Visible = true;
                labelNumberOfPostsInPeriodOfTime.Text = $"{postCount} posts found";
                labelPleaseWait.Visible = false;

                if (!m_IsUserGuessedPostYear)
                {
                    showGuessPostYear();
                    m_IsUserGuessedPostYear = true;
                }
            }));
        }

        private void showGuessPostYear()
        {
            m_PostToGuess = m_FeatureFacade.GetRandomPost();
            visibleObejctsOfGuessPostYear();

            labelSelectedPost.Text = (m_PostToGuess == null) ? "No posts exists!" : m_PostToGuess.Message;
            labelSelectedPost.ForeColor = Color.Black;
        }

        private void visibleObejctsOfGuessPostYear()
        {
            labelGuessPost.Visible = true;
            comboBoxGuessPostYear.Visible = true;
            buttonGuessYear.Visible = true;
            buttonNewPostGuess.Visible = true;
            labelSelectedPost.Visible = true;
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
            if (m_PostToGuess != null)
            {
                string selectedYearOption = comboBoxGuessPostYear.SelectedItem.ToString();
                if (selectedYearOption == m_PostToGuess.CreatedTime.Value.Year.ToString())
                {
                    labelSelectedPost.Text = "YOUR GUESS IS CORRECT!!!";
                    labelSelectedPost.ForeColor = Color.PaleGreen;
                }
                else
                {
                    labelSelectedPost.Text = "your guess is wrong";
                    labelSelectedPost.ForeColor = Color.Red;
                }
            }
        }

        private void buttonNewPostGuess_Click(object sender, EventArgs e)
        {
            m_PostToGuess = m_FeatureFacade.GetRandomPost();
            labelSelectedPost.ForeColor = Color.Black;
            labelSelectedPost.Text = (m_PostToGuess == null) ? "No posts exists!" : m_PostToGuess.Message;
        }

        private void buttonNewBirthdayGuess_Click(object sender, EventArgs e)
        {
            m_FriendToGuess = m_FeatureFacade.GetRandomFriend();
            labelFriendName.ForeColor = Color.Black;
            labelFriendName.Text = (m_FriendToGuess == null) ? "No friends exists!" : m_FriendToGuess.Name;
        }

        private void buttonGuessBirthdayMonth_Click(object sender, EventArgs e)
        {
            if (m_FriendToGuess != null)
            {
                int selectedMonthNumber = m_FeatureFacade.ConvertMonthStringToInt(comboBoxGuessBirthdayMonth.SelectedItem.ToString());
                BirthdayFeature friendBirthday = FeatureFactory.CreateBirthdayFeature(m_FriendToGuess.Birthday);

                if (selectedMonthNumber == friendBirthday.GetBirthdayMonth())
                {
                    labelFriendName.Text = "YOUR GUESS IS CORRECT!!!";
                    labelFriendName.ForeColor = Color.PaleGreen;
                }
                else
                {
                    labelFriendName.Text = "your guess is wrong";
                    labelFriendName.ForeColor = Color.Red;
                }
            }
        }
    }
}