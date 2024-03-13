using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    

    internal partial class FormMain : Form
    {
        private User m_User;
        private RandomSelector m_RandomSelector;
        private PostAnalyzer m_PostAnalyzer;
        private IGuessStrategy m_GuessStrategy;
        private Post m_PostToGuess;
        private User m_FriendToGuess;
        private bool m_IsUserGuessedPostYear = false;
        private bool m_IsUserGuessedFriendBirthday = false;

        internal FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (FacebookAuthenticationManager.Instance.m_LoggedInUser == null)
            {
                if (FacebookAuthenticationManager.Instance.Login("749307766594184", "email", "public_profile", "user_posts", "user_birthday", "user_friends"))
                {
                    m_User = FacebookAuthenticationManager.Instance.m_LoggedInUser;

                    m_RandomSelector = FeatureFactory.CreateRandomSelector(m_User);
                    m_PostAnalyzer = FeatureFactory.CreatePostAnalyzer(m_User);
                    buttonLogin.Text = $"Logged in as {m_User.Name}";
                    buttonLogin.BackColor = Color.LightGreen;
                    enableButtonsAfterLogin();
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
            FacebookAuthenticationManager.Instance.Logout();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            disableButtonsAfterLogout();
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
            BirthdayFeature birthdayFeature = FeatureFactory.CreateBirthdayFeature(m_User.Birthday);
            TimeSpan timeSpan = birthdayFeature.TimeToBirhtday();

            labelBirthdayCountdown.Visible = true;
            labelBirthdayCountdown.Text = $"Time until next birthday: {timeSpan.Days} days, {timeSpan.Hours} hours, {timeSpan.Minutes} minutes.";

            if (!m_IsUserGuessedFriendBirthday)
            {
                showGuessBirthdayMonth();
                m_IsUserGuessedFriendBirthday = true;
            }
        }

        private void showGuessBirthdayMonth()
        {
            m_GuessStrategy = new GuessFriendBirthdayMonthStrategy(m_RandomSelector);
            updateUIForCurrentGuess();
        }

        private void updateUIForCurrentGuess()
        {
            if (m_GuessStrategy is GuessPostYearStrategy)
            {
                // Make post year guessing UI elements visible and update related text
                visibleObjectsOfGuessPostYear();
                labelSelectedPost.Text = m_GuessStrategy.GetGuessingTargetInfo(); // Assuming labelSelectedPost is for posts
            }
            else if (m_GuessStrategy is GuessFriendBirthdayMonthStrategy)
            {
                // Make birthday month guessing UI elements visible and update related text
                visibleFormObjectsOfGuessFriendBirthdayMonth();
                labelFriendName.Text = m_GuessStrategy.GetGuessingTargetInfo(); // Assuming labelFriendName is for friends
            }
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

            labelNumberOfPostsInPeriodOfTime.Visible = true;
            labelNumberOfPostsInPeriodOfTime.Text = $"{m_PostAnalyzer.CountPostsInPeriod(selectedPeriodOption)} posts found";

            labelPleaseWait.Visible = false;

            if (!m_IsUserGuessedPostYear)
            {
                showGuessPostYear();
                m_IsUserGuessedPostYear = true;
            }
        }

        private void showGuessPostYear()
        {
            m_GuessStrategy = new GuessPostYearStrategy(m_RandomSelector);
            updateUIForCurrentGuess();
        }

        private void updatePostToGuessUI()
        {
            // Check if the guessing strategy is for guessing post year and if the target post is set
            if (m_GuessStrategy is GuessPostYearStrategy && m_GuessStrategy.GetGuessingTargetInfo() != null)
            {
                // Update the UI with the post's message or a placeholder text if the message is empty
                labelSelectedPost.Text = m_GuessStrategy.GetGuessingTargetInfo();

                // Reset the text color to default in case it was changed to indicate a correct or incorrect guess previously
                labelSelectedPost.ForeColor = Color.Black;

                // Make sure the guess button is enabled only if there is a post to guess
                buttonGuessYear.Enabled = true;
            }
            else
            {
                // No post available for guessing
                labelSelectedPost.Text = "No posts exist!";
                labelSelectedPost.ForeColor = Color.Red;

                // Disable the guess button as there is no post to guess
                buttonGuessYear.Enabled = false;
            }

            // Reset the selection in the comboBox to force the user to choose again for a new guess
            comboBoxGuessPostYear.SelectedIndex = -1;
        }


        private void visibleObjectsOfGuessPostYear()
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
            string selectedYearOption = comboBoxGuessPostYear.SelectedItem.ToString();
            if (m_GuessStrategy.Guess(selectedYearOption))
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


        private void buttonNewPostGuess_Click(object sender, EventArgs e)
        {
            //m_GuessStrategy.UpdateTarget(); // Refresh the target for guessing.
            updateGuessStrategy(GuessType.GuessPostYear);
            updatePostToGuessUI();
        }

        private void buttonNewBirthdayGuess_Click(object sender, EventArgs e)
        {
            m_GuessStrategy.UpdateTarget(); // Make sure your strategy has the UpdateTarget method public or accessible.
            updateFriendToGuessUI();
        }

        private void updateGuessStrategy(GuessType guessType)
        {
            switch (guessType)
            {
                case GuessType.GuessPostYear:
                    m_GuessStrategy = new GuessPostYearStrategy(m_RandomSelector);
                    break;
                case GuessType.GuessFriendBirthday:
                    m_GuessStrategy = new GuessFriendBirthdayMonthStrategy(m_RandomSelector);
                    break;
                default:
                    throw new NotImplementedException($"Not implemented guess type: {guessType}");
            }
            m_GuessStrategy.UpdateTarget();
            m_GuessStrategy.UpdateUI(this); // Assuming UpdateUI is a method you've implemented as part of IGuessStrategy
        }

        private void updateFriendToGuessUI()
        {
            // Update UI elements with the new friend's name for guessing
            labelFriendName.Text = m_GuessStrategy.GetGuessingTargetInfo();
            labelFriendName.ForeColor = Color.Black; // Reset text color in case it was changed to indicate correct/incorrect guess
        }

        private void buttonGuessBirthdayMonth_Click(object sender, EventArgs e)
        {
            // Perform the guess and provide feedback
            string selectedMonth = comboBoxGuessBirthdayMonth.SelectedItem.ToString();
            if (m_GuessStrategy.Guess(selectedMonth))
            {
                labelFriendName.Text = "YOUR GUESS IS CORRECT!!!";
                labelFriendName.ForeColor = Color.PaleGreen;
            }
            else
            {
                labelFriendName.Text = "Your guess is wrong.";
                labelFriendName.ForeColor = Color.Red;
            }
        }
    }
}