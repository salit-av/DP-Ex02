using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal static class FeatureFactory
    {
        internal static RandomSelector CreateRandomSelector(User user)
        {
            return new RandomSelector(user);
        }

        internal static BirthdayFeature CreateBirthdayFeature(string birthday)
        {
            return new BirthdayFeature(birthday);
        }

        internal static PostAnalyzer CreatePostAnalyzer(User user)
        {
            return new PostAnalyzer(user);
        }
    }
}
