namespace QA.TILS.Modules.Users.Core.SharedSteps
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.Framework.Core.Data;
    using QA.Framework.Core.Data.Templates;
    using QA.Framework.Core.Helpers;
    using QA.TILS.Modules.Users.Core.Pages.Common;
    using QA.TILS.Modules.Users.Core.Pages.FriendsPage;

    public static class FriendsSteps
    {
        private static NotLoggedUserProfilePageElements UserProfilePage
        {
            get
            {
                return new NotLoggedUserProfilePageElements();
            }
        }

        private static LoggedUserStartPageElements UserStartPage
        {
            get
            {
                return new LoggedUserStartPageElements();
            }
        }

        private static FriendsPage FriendsPage
        {
            get
            {
                return new FriendsPage();
            }
        }

        public static void RemoveUserFromFriends(User user)
        {
            NavigateTo.Url(user.ProfileUrl);
            UserProfilePage.UnfriendButton.Click();

            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.ActiveBrowser.Refresh();

            UserProfilePage.AddAsFriendButton.Wait.ForExists(10000);
        }

        public static void AddUserToFriends(User user)
        {
            NavigateTo.Url(user.ProfileUrl);
            UserProfilePage.AddAsFriendButton.Click();

            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.ActiveBrowser.Refresh();

            UserProfilePage.UnfriendButton.Wait.ForExists(10000);
        }

        public static void AcceptUserInvitation()
        {
            NavigateTo.Url("http://test.telerikacademy.com/");

            UserStartPage.UnacceptedInvitationsLink.Click();
            FriendsPage.Elements.AcceptFriendshipButton.Click();
        }
    }
}
