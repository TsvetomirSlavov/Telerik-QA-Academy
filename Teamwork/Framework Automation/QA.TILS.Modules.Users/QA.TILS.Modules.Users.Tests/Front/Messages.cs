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
    using QA.TILS.Modules.Users.Core.Pages.Common;

    /// <summary>
    /// The initial state that must serve as a precondition for all of the tests below is 
    /// that TestUser1 and TestUser 2 are friends and there are no new messages between them
    /// </summary>
    [TestClass]
    public class Messages : BaseTest
    {
        public FriendsPage FriendsPage;
        public MessagesPage MessagesPage;
        public LoggedUserStartPageElements StartPageElements;

        public override void TestInitialize()
        {
            this.FriendsPage = new FriendsPage();
            this.MessagesPage = new MessagesPage();
            this.StartPageElements = new LoggedUserStartPageElements();

            this.Browser.ClearCache(BrowserCacheType.Cookies);
            this.Browser.Refresh();

            Manager.Current.Settings.Web.RecycleBrowser = true;
        }

        [TestMethod]
        public void Logged_Users_Can_Access_Messages_Section()
        {
            LoginSteps.LoginTestUser1();
            NavigateTo.Page(this.MessagesPage);

            MessagesPage.Elements.SendMessageButton.Wait.ForExists(5000);
        }

        [TestMethod]
        public void Messages_Could_Not_Be_Accessed_Without_Logging_In_First()
        {
            NavigateTo.Page(this.MessagesPage);

            Assert.IsTrue(this.Browser.Url.Contains("http://test.telerikacademy.com/Users/Auth/Login"));
        }

        [TestMethod]
        public void Messages_Sent_Are_Received_By_The_Recepient()
        {
            LoginSteps.LoginTestUser1();

            string messageContent = RandomDataGenerator.GenerateRandomString(5, 15);
            MessagesSteps.SendMessageTo(TestUsers.TestUser2, messageContent);

            LoginSteps.LoginTestUser2();

            NavigateTo.Page(this.MessagesPage);

            this.MessagesPage.Elements.FriendTile.Click();

            this.MessagesPage.Elements.Messages.Wait.ForExists(5000);

            Assert.IsTrue(this.MessagesPage.Elements.Messages.InnerText.Contains(messageContent));

            // Reverse to initial state (there are no unread messages between the users)
            MessagesSteps.ReadNewMessages();
        }

        [TestMethod]
        public void New_Messages_Sent_Invoke_New_Messages_Notification()
        {
            LoginSteps.LoginTestUser1();

            string messageContent = RandomDataGenerator.GenerateRandomString(5, 15);
            MessagesSteps.SendMessageTo(TestUsers.TestUser2, messageContent);

            LoginSteps.LoginTestUser2();

            this.StartPageElements.NewMessagesLink.AssertIsPresent();

            // Reverse to initial state (there are no unread messages between the users)
            MessagesSteps.ReadNewMessages();
        }

        [TestMethod]
        public void New_Messages_Notification_Is_Removed_After_The_Message_Is_Read()
        {
            LoginSteps.LoginTestUser1();

            string messageContent = RandomDataGenerator.GenerateRandomString(5, 15);
            MessagesSteps.SendMessageTo(TestUsers.TestUser2, messageContent);

            LoginSteps.LoginTestUser2();

            this.StartPageElements.NewMessagesLink.AssertIsPresent();
            MessagesSteps.ReadNewMessages();

            NavigateTo.Url("http://test.telerikacademy.com/");
            this.StartPageElements.NewMessagesLink.AssertIsNotPresent();
        }
    }
}
