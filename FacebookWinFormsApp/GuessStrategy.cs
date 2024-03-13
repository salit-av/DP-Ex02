using System;
using System.Globalization;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    interface IGuessStrategy
    {
        bool IsGuessCorrect(object itemToGuess, object guess);
    }

    class GuessPostYearStrategy : IGuessStrategy
    {
        public bool IsGuessCorrect(object itemToGuess, object guess)
        {
            Post postToGuess = itemToGuess as Post;

            // Parse the guess string into an integer
            if (int.TryParse(guess as string, out int guessedYear))
            {
                if (postToGuess != null && postToGuess.CreatedTime.HasValue)
                {
                    return postToGuess.CreatedTime.Value.Year == guessedYear;
                }
            }

            return false;
        }
    }

    class GuessBirthdayMonthStrategy : IGuessStrategy
    {
        public bool IsGuessCorrect(object itemToGuess, object guess)
        {
            User friendToGuess = itemToGuess as User;
            int guessedMonth = (int)guess;

            if (friendToGuess != null && !string.IsNullOrWhiteSpace(friendToGuess.Birthday))
            {
                DateTime birthdayDate = DateTime.ParseExact(friendToGuess.Birthday, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                
                return birthdayDate.Month == guessedMonth;
            }

            return false;
        }
    }
}