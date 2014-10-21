namespace QA.TILS.Modules.Users.Core.Pages.FriendsPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.Framework.Core.Base;
    using QA.Framework.Core.Extensions;

    public class FriendsPageElements : BaseElementsMap
    {
        public HtmlDiv RemoveFriendshipButton
        {
            get
            {
                return this.Find.ByExpression<HtmlDiv>("removeFriendship".ToIsClassExpression());
            }
        }

        public HtmlDiv SendMessageButton
        {
            get
            {
                return this.Find.ByExpression<HtmlDiv>("sendMessage".ToIsClassExpression());
            }
        }


        public HtmlDiv RemoveFriendshipConfirmation
        {
            get
            {
                return this.Find.ByExpression<HtmlDiv>("sureOption".ToIsClassExpression());
            }
        }

        public HtmlUnorderedList SentInvitationsList
        {
            get
            {
                return this.Find.ById<HtmlUnorderedList>("requestedFriendRequests");
            }
        }

        public HtmlDiv AcceptFriendshipButton
        {
            get
            {
                return this.Find.ByExpression<HtmlDiv>("approveFriendship".ToIsClassExpression());
            }
        }

        public HtmlDiv DeclineFriendshipButton
        {
            get
            {
                return this.Find.ByExpression<HtmlDiv>("removeFriendship".ToIsClassExpression());
            }
        }

        public HtmlDiv NoFriendsMessage
        {
            get
            {
                return this.Find.ByXPath<HtmlDiv>("//*[@id='MainContent']/div");
            }
        }
    }
}
