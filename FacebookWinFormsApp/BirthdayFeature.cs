using System;

namespace BasicFacebookFeatures
{
    internal class BirthdayFeature
    {
        private readonly int r_Day;
        private readonly int r_Month;

        internal BirthdayFeature(string i_Birthday)
        {
            string[] birthdayDivide = i_Birthday.Split('/');

            if (birthdayDivide.Length == 2 || birthdayDivide.Length == 3)
            {
                r_Month = int.Parse(birthdayDivide[0]);
                r_Day = int.Parse(birthdayDivide[1]);
            }
        }

        internal int GetBirthdayMonth()
        {
            return r_Month;
        }
    }
}