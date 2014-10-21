namespace QA.TILS.Modules.Users.Tests.Front
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.Framework.Core.Base;
    using QA.TILS.Modules.Users.Core.Pages.MessagesPage;
    using QA.TILS.Modules.Users.Core.Pages.FriendsPage;
    using ArtOfTest.WebAii.Core;
    using QA.TILS.Modules.Users.Core.SharedSteps;
    using QA.Framework.Core.Data;
    using QA.TILS.Modules.Users.Core.Pages.Common;

    /// <summary>
    /// The initial state that must serve as a precondition for all of the tests below is 
    /// that TestUser1 and TestUser 2 are friends
    /// </summary>
    [TestClass]
    public class FriendshipInvitations : BaseTest
    {
        public FriendsPage FriendsPage;
        public MessagesPage MessagesPage;
        public LoggedUserStartPageElements UserStartPage;

        public override void TestInitialize()
        {
            this.FriendsPage = new FriendsPage();
            this.MessagesPage = new MessagesPage();
            this.UserStartPage = new LoggedUserStartPageElements();

            this.Browser.ClearCache(BrowserCacheType.Cookies);
            this.Browser.Refresh();
        }

        [TestMethod]
        public void Invitation_Is_Received_By_The_Correct_Users()
        {
            LoginSteps.LoginTestUser1();
            FriendsSteps.RemoveUserFromFriends(TestUsers.TestUser2);
            FriendsSteps.AddUserToFriends(TestUsers.TestUser2);

            LoginSteps.LoginTestUser2();
            this.UserStartPage.UnacceptedInvitationsLink.Wait.ForExists();

            // Reverse to initial state (the two test users ARE friends)
            FriendsSteps.AcceptUserInvitation();
        }

        [TestMethod]
        public void Request_Notification_Disappears_After_Friendship_Approval()
        {
            LoginSteps.LoginTestUser1();
            FriendsSteps.RemoveUserFromFriends(TestUsers.TestUser2);
            FriendsSteps.AddUserToFriends(TestUsers.TestUser2);

            LoginSteps.LoginTestUser2();
            this.UserStartPage.UnacceptedInvitationsLink.Wait.ForExists();

            FriendsSteps.AcceptUserInvitation();
            this.Browser.Refresh();

            this.UserStartPage.UnacceptedInvitationsLink.Wait.ForExistsNot();
        }

        [TestMethod]
        public void Invitation_Notification_Link_Navigates_To_The_Correct_Place()
        {
            LoginSteps.LoginTestUser1();
            FriendsSteps.RemoveUserFromFriends(TestUsers.TestUser2);
            FriendsSteps.AddUserToFriends(TestUsers.TestUser2);

            LoginSteps.LoginTestUser2();
            this.UserStartPage.UnacceptedInvitationsLink.Click();
            this.Browser.WaitUntilReady();

            Assert.AreEqual(this.FriendsPage.Url, this.Browser.Url);

            // Reverse to initial state (the two test users ARE friends)
            FriendsSteps.AcceptUserInvitation();
        }
    }
}
