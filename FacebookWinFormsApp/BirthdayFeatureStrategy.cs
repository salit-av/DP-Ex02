using System;

namespace BasicFacebookFeatures
{
    internal interface IBirthdayCountdownStrategy
    {
        TimeSpan GetTimeUntilNextBirthday(string i_Birthday);
    }

    internal class SimpleBirthdayCountdownStrategy : IBirthdayCountdownStrategy
    {
        public TimeSpan GetTimeUntilNextBirthday(string i_Birthday)
        {
            return calculateTimeUntilNextBirthday(i_Birthday);
        }

        private TimeSpan calculateTimeUntilNextBirthday(string i_Birthday)
        {
            string[] birthdayDivide = i_Birthday.Split('/');

            if (birthdayDivide.Length == 2 || birthdayDivide.Length == 3)
            {
                int month = int.Parse(birthdayDivide[0]);
                int day = int.Parse(birthdayDivide[1]);

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