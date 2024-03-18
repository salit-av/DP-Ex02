using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class FeatureFacade
    {
        private User m_User;
        private IBirthdayCountdownStrategy m_BirthdayCountdownStrategy;
        private IPostAnalyzerStrategy m_PostAnalyzerStrategy;

        internal FeatureFacade(User i_User, IBirthdayCountdownStrategy i_BirthdayCountdownStrategy, IPostAnalyzerStrategy i_PostAnalyzerStrategy)
        {
            m_User = i_User;
            m_BirthdayCountdownStrategy = i_BirthdayCountdownStrategy;
            m_PostAnalyzerStrategy = i_PostAnalyzerStrategy;
        }

        internal TimeSpan GetTimeUntilNextBirthday()
        {
            return m_BirthdayCountdownStrategy.GetTimeUntilNextBirthday(m_User.Birthday);
        }

        internal int CountPostsInPeriod(string i_Period)
        {
            return m_PostAnalyzerStrategy.CountPostsInPeriod(i_Period);
        }

        internal User GetRandomFriend()
        {
            RandomSelector randomSelector = FeatureFactory.CreateRandomSelector(m_User);
            return randomSelector.GetRandomFriend();
        }

        internal Post GetRandomPost()
        {
            RandomSelector randomSelector = FeatureFactory.CreateRandomSelector(m_User);
            return randomSelector.GetRandomPost();
        }

        internal int ConvertMonthStringToInt(string i_Month)
        {
            MonthConverter monthConverter = FeatureFactory.CreateMonthConverter();
            return monthConverter.GetMonthNumber(i_Month);
        }
    }
}