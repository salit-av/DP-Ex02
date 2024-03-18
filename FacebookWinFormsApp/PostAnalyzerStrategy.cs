using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal interface IPostAnalyzerStrategy
    {
        int CountPostsInPeriod(string i_Period);
    }

    internal class SimplePostAnalyzerStrategy : IPostAnalyzerStrategy
    {
        public int CountPostsInPeriod(string i_periodOfTime)
        {
            DateTime now = DateTime.Now;
            int counter = 0;

            foreach (Post post in FacebookAuthenticationManager.Instance.m_LoggedInUser.Posts)
            {
                DateTime postDate = post.CreatedTime.Value;

                if (isPostInSelectedPeriod(postDate, i_periodOfTime, now))
                {
                    counter++;
                }
            }

            return counter;
        }

        private bool isPostInSelectedPeriod(DateTime i_PostDate, string i_SelectedPeriod, DateTime i_Now)
        {
            bool isPostInPeriod = false;

            switch (i_SelectedPeriod)
            {
                case "This Month":
                    isPostInPeriod = i_PostDate.Year == i_Now.Year && i_PostDate.Month == i_Now.Month;
                    break;

                case "Last 3 Months":
                    DateTime threeMonthsAgo = i_Now.AddMonths(-3);
                    isPostInPeriod = i_PostDate > threeMonthsAgo && i_PostDate <= i_Now;
                    break;

                case "Last 12 Months":
                    DateTime twelveMonthsAgo = i_Now.AddMonths(-12);
                    isPostInPeriod = i_PostDate > twelveMonthsAgo && i_PostDate <= i_Now;
                    break;

                case "Last Five Years":
                    DateTime fiveYearsAgo = i_Now.AddYears(-5);
                    isPostInPeriod = i_PostDate > fiveYearsAgo && i_PostDate <= i_Now;
                    break;

                case "Last Ten Years":
                    DateTime tenYearsAgo = i_Now.AddYears(-10);
                    isPostInPeriod = i_PostDate > tenYearsAgo && i_PostDate <= i_Now;
                    break;
            }

            return isPostInPeriod;
        }
    }
}