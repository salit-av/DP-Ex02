namespace BasicFacebookFeatures
{
    public enum GuessType
    {
        GuessPostYear,
        GuessFriendBirthday
    }

    public interface IGuessStrategy
    {
        bool Guess(string guess);
        string GetGuessingTargetInfo();
        void UpdateTarget();
        void UpdateUI(FormMain form); // New method to update the UI according to the strategy
    }
}