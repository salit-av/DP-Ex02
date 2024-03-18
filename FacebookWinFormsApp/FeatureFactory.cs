using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal static class FeatureFactory
    {
        internal static RandomSelector CreateRandomSelector(User i_User)
        {
            return new RandomSelector(i_User);
        }

        internal static MonthConverter CreateMonthConverter()
        {
            return new MonthConverter();
        }

        internal static BirthdayFeature CreateBirthdayFeature(string i_Birthday)
        {
            return new BirthdayFeature(i_Birthday);
        }
    }
}
