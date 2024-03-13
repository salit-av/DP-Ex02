using System;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PostAnalyzer
    {
        private User m_User;

        internal PostAnalyzer(User user)
        {
            this.m_User = user;
        }

        internal async Task<int> CountPostsInPeriodAsync(string periodOfTime)
        {
            // Asynchronously run the counting operation in a task
            return await Task.Run(() =>
            {
                int counter = 0;
                DateTime now = DateTime.Now;

                foreach (Post post in m_User.Posts)
                {
                    // Check if CreatedTime has a value before trying to access it
                    if (post.CreatedTime.HasValue)
                    {
                        DateTime postDate = post.CreatedTime.Value;

                        if (isPostInSelectedPeriod(postDate, periodOfTime, now))
                        {
                            counter++;
                        }
                    }
                }

                return counter;
            });
        }

        private bool isPostInSelectedPeriod(DateTime postDate, string selectedPeriod, DateTime now)
        {
            bool isPostInPeriod = false;

            switch (selectedPeriod)
            {
                case "This Month":
                    isPostInPeriod = postDate.Year == now.Year && postDate.Month == now.Month;
                    break;

                case "Last 3 Months":
                    DateTime threeMonthsAgo = now.AddMonths(-3);
                    isPostInPeriod = postDate > threeMonthsAgo && postDate <= now;
                    break;

                case "Last 12 Months":
                    DateTime twelveMonthsAgo = now.AddMonths(-12);
                    isPostInPeriod = postDate > twelveMonthsAgo && postDate <= now;
                    break;

                case "Last Five Years":
                    DateTime fiveYearsAgo = now.AddYears(-5);
                    isPostInPeriod = postDate > fiveYearsAgo && postDate <= now;
                    break;

                case "Last Ten Years":
                    DateTime tenYearsAgo = now.AddYears(-10);
                    isPostInPeriod = postDate > tenYearsAgo && postDate <= now;
                    break;
            }

            return isPostInPeriod;
        }
    }
}
