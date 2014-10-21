namespace QA.TILS.Modules.Users.Tests.Front
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using QA.Framework.Core.Base;
    using QA.Framework.Core.Data;
    using QA.Framework.Core.Helpers;
    using QA.Framework.Core.Extensions;
    using QA.TILS.Modules.Users.Core.Pages.FriendsPage;
    using QA.TILS.Modules.Users.Core.Pages.MessagesPage;
    using QA.TILS.Modules.Users.Core.SharedSteps;

    /// <summary>
    /// The initial state that must serve as a precondition for all of the tests below is 
    /// that TestUser1 and TestUser 2 are friends
    /// </summary>
    [TestClass]
    public class Friends : BaseTest
    {
        public FriendsPage FriendsPage;
        public MessagesPage MessagesPage;

        public override void TestInitialize()
        {
            this.FriendsPage = new FriendsPage();
            this.MessagesPage = new MessagesPage();

            this.Browser.ClearCache(BrowserCacheType.Cookies);
            this.Browser.Refresh();
        }

        [TestMethod]
        public void Trying_To_Remove_A_Friend_Prompts_For_Confirmation()
        {
            LoginSteps.LoginTestUser1();
            NavigateTo.Page(this.FriendsPage);

            this.FriendsPage.Elements.RemoveFriendshipButton.Click();

            this.FriendsPage.Elements.RemoveFriendshipConfirmation.Wait.ForExists(5000);
        }

        [TestMethod]
        public void Requesting_A_Friendship_Does_Not_Add_User_To_Your_Friends_Without_Approval()
        {
            LoginSteps.LoginTestUser1();
            FriendsSteps.RemoveUserFromFriends(TestUsers.TestUser2);
            FriendsSteps.AddUserToFriends(TestUsers.TestUser2);

            NavigateTo.Page(this.FriendsPage);

            this.FriendsPage.Elements.SentInvitationsList.Wait.ForExists(5000);

            // Reverse to initial state (the two test users ARE friends)
            LoginSteps.LoginTestUser2();
            FriendsSteps.AcceptUserInvitation();
        }

        [TestMethod]
        public void Removing_A_Friend_Removes_Him_From_Your_Friends_List()
        {
            LoginSteps.LoginTestUser1();
            FriendsSteps.RemoveUserFromFriends(TestUsers.TestUser2);

            NavigateTo.Page(this.FriendsPage);
            Manager.Current.ActiveBrowser.RefreshDomTree();
            this.FriendsPage.Elements.NoFriendsMessage.Wait.ForExists(5000);

            // Reverse to initial state (the two test users ARE friends)
            FriendsSteps.AddUserToFriends(TestUsers.TestUser2);
            LoginSteps.LoginTestUser2();
            FriendsSteps.AcceptUserInvitation();
        }

        [TestMethod]
        public void Send_Message_Button_On_A_Friends_Tile_Navigates_To_The_Correct_Place()
        {
            LoginSteps.LoginTestUser1();
            NavigateTo.Page(this.FriendsPage);

            this.FriendsPage.Elements.SendMessageButton.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();

            this.MessagesPage.Elements.Messages.AssertTextIsContained("13:32, 1.10Test22:49, 8.10Test22:52, 8.10Test22:54, 8.10This is a text message");
        }
    }
}
