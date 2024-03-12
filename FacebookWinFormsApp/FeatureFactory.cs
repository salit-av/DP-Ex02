using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class FeatureFactory
    {
        private User m_User;

        internal FeatureFactory(User user)
        {
            m_User = user;
        }

        internal RandomSelector CreateRandomSelector()
        {
            return new RandomSelector(m_User);
        }

        internal BirthdayFeature CreateBirthdayFeature(string birthday)
        {
            return new BirthdayFeature(birthday);
        }

        internal PostAnalyzer CreatePostAnalyzer()
        {
            return new PostAnalyzer(m_User);
        }
    }

}
