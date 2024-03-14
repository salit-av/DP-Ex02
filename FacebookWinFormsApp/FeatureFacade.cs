using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class FeatureFacade
    {
        private User m_User;
        private RandomSelector m_RandomSelector;
        private PostAnalyzer m_PostAnalyzer;

        public FeatureFacade(User user)
        {
            m_User = user;
            m_RandomSelector = FeatureFactory.CreateRandomSelector(m_User);
            m_PostAnalyzer = FeatureFactory.CreatePostAnalyzer(m_User);
        }

        public TimeSpan TimeUntilNextBirthday()
        {
            BirthdayFeature birthdayFeature = FeatureFactory.CreateBirthdayFeature(m_User.Birthday);
            
            return birthdayFeature.TimeToBirhtday();
        }

        public int CountPostsInPeriod(string period)
        {
            return m_PostAnalyzer.CountPostsInPeriod(period);
        }

        public User GetRandomFriend()
        {
            return m_RandomSelector.GetRandomFriend();
        }

        public Post GetRandomPost()
        {
            return m_RandomSelector.GetRandomPost();
        }

        public int ConvertMonthNumberToInt(string month)
        {
            MonthConverter monthConverter = FeatureFactory.CreateMonthConverter();

            return monthConverter.GetMonthNumber(month);
        }
    }
}