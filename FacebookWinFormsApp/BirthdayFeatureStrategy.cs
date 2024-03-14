using System;

namespace BasicFacebookFeatures
{
    // Define interfaces for each feature's strategy
    public interface IBirthdayCountdownStrategy
    {
        TimeSpan GetTimeUntilNextBirthday(string birthday);
    }

    // Implement concrete strategies
    public class SimpleBirthdayCountdownStrategy : IBirthdayCountdownStrategy
    {
        public TimeSpan GetTimeUntilNextBirthday(string birthday)
        {
            // Implement simple countdown logic
            return CalculateTimeUntilNextBirthday(birthday);
        }

        private TimeSpan CalculateTimeUntilNextBirthday(string birthday)
        {
            // Parse the birthday string
            string[] birthdayDivide = birthday.Split('/');

            if (birthdayDivide.Length == 2 || birthdayDivide.Length == 3)
            {
                int month = int.Parse(birthdayDivide[0]);
                int day = int.Parse(birthdayDivide[1]);

                // Calculate next birthday
                DateTime nextBirthday;
                if (month == 2 && day == 29)
                {
                    nextBirthday = new DateTime(DateTime.Now.Year, month, 28).AddYears(1);
                }
                else
                {
                    nextBirthday = new DateTime(DateTime.Now.Year, month, day);
                    if (nextBirthday < DateTime.Now)
                    {
                        nextBirthday = nextBirthday.AddYears(1);
                    }
                }

                return nextBirthday - DateTime.Now;
            }

            throw new ArgumentException("Invalid birthday format.");
        }
    }
}
