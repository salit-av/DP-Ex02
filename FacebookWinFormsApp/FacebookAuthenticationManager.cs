using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class FacebookAuthenticationManager
    {
        private static FacebookAuthenticationManager s_Instance;
        private LoginResult m_LoginResult;
        internal User m_LoggedInUser { get; private set; }

        private FacebookAuthenticationManager() { }

        internal static FacebookAuthenticationManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    s_Instance = new FacebookAuthenticationManager();
                }

                return s_Instance;
            }
        }

        internal bool Login(string i_AppId, params string[] i_Permissions)
        {
            bool isLoginSucceeded = false;
            m_LoginResult = FacebookService.Login(i_AppId, i_Permissions);

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                isLoginSucceeded = true;
            }

            return isLoginSucceeded;
        }

        internal void Logout()
        {
            FacebookService.LogoutWithUI();
            m_LoggedInUser = null;
        }
    }
}