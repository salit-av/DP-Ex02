using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{ 
    public class GuessPostYearStrategy : IGuessStrategy
    {
        private Post postToGuess;
        private readonly RandomSelector randomSelector;

        public GuessPostYearStrategy(RandomSelector randomSelector)
        {
            this.randomSelector = randomSelector;
            UpdateTarget();
        }

        public bool Guess(string guess)
        {
            return postToGuess != null && guess == postToGuess.CreatedTime.Value.Year.ToString();
        }

        public string GetGuessingTargetInfo()
        {
            return postToGuess == null ? "No posts exist!" : postToGuess.Message;
        }

        public void UpdateTarget()
        {
            postToGuess = randomSelector.GetRandomPost();
        }
    }
}