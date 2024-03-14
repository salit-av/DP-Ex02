using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class FeatureFacade
    {
        private User m_User;
        private IBirthdayCountdownStrategy m_BirthdayCountdownStrategy;
        private IPostAnalyzerStrategy m_PostAnalyzerStrategy;

        public FeatureFacade(User user, IBirthdayCountdownStrategy birthdayCountdownStrategy, IPostAnalyzerStrategy postAnalyzerStrategy)
        {
            m_User = user;
            m_BirthdayCountdownStrategy = birthdayCountdownStrategy;
            m_PostAnalyzerStrategy = postAnalyzerStrategy;
        }

        public TimeSpan GetTimeUntilNextBirthday()
        {
            return m_BirthdayCountdownStrategy.GetTimeUntilNextBirthday(m_User.Birthday);
        }

        public int CountPostsInPeriod(string period)
        {
            return m_PostAnalyzerStrategy.CountPostsInPeriod(period);
        }

        public User GetRandomFriend()
        {
            RandomSelector randomSelector = FeatureFactory.CreateRandomSelector(m_User);
            return randomSelector.GetRandomFriend();
        }

        public Post GetRandomPost()
        {
            RandomSelector randomSelector = FeatureFactory.CreateRandomSelector(m_User);
            return randomSelector.GetRandomPost();
        }

        public int ConvertMonthStringToInt(string month)
        {
            MonthConverter monthConverter = FeatureFactory.CreateMonthConverter();
            return monthConverter.GetMonthNumber(month);
        }
    }
}
