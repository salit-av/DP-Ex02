using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class GuessFriendBirthdayMonthStrategy : IGuessStrategy
    {
        private User friendToGuess;
        private readonly RandomSelector randomSelector;

        public GuessFriendBirthdayMonthStrategy(RandomSelector randomSelector)
        {
            this.randomSelector = randomSelector;
            UpdateTarget();
        }

        public bool Guess(string guess)
        {
            MonthConverter monthConverter = FeatureFactory.CreateMonthConverter();
            int selectedMonthNumber = monthConverter.GetMonthNumber(guess);
            BirthdayFeature friendBirthday = FeatureFactory.CreateBirthdayFeature(friendToGuess.Birthday);
            return selectedMonthNumber == friendBirthday.GetBirthdayMonth();
        }

        public string GetGuessingTargetInfo()
        {
            return friendToGuess == null ? "No friends exist!" : friendToGuess.Name;
        }

        public void UpdateTarget()
        {
            friendToGuess = randomSelector.GetRandomFriend();
        }
        public void UpdateUI(FormMain form)
        {
            form.visibleFormObjectsOfGuessFriendBirthdayMonth();
            form.labelFriendName.Text = GetGuessingTargetInfo();
        }
    }

}
