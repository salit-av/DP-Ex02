using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;

            Cef.Initialize(new CefSettings());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());

            Cef.Shutdown();
        }
    }
}