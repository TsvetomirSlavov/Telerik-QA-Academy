namespace QA.TILS.Modules.Users.Core.Pages.RegistrationPage
{

    using ArtOfTest.WebAii.Controls.HtmlControls;

    using QA.Framework.Core.Base;
    using QA.Framework.Core.Extensions;

    public class RegistrationPageElements : BaseElementsMap
    {
        public HtmlInputText UsernameField
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Username");
            }
        }

        public HtmlInputPassword PasswordField
        {
            get
            {
                return this.Find.ById<HtmlInputPassword>("Password");
            }
        }

        public HtmlInputPassword PasswordAgainField
        {
            get
            {
                return this.Find.ById<HtmlInputPassword>("PasswordAgain");
            }
        }

        public HtmlInputText FirstNameInBulgarianField 
        {
            get 
            {
                return this.Find.ById<HtmlInputText>("FirstName");
            }
        }

        public HtmlInputText LastNameInBulgarianField
        {
            get
            {
                return this.Find.ById<HtmlInputText>("LastName");
            }
        }

        public HtmlInputText EmailField
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Email");
            }
        }

        public HtmlInputCheckBox TermsAndConditionsCheckBox 
        { 
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("TermsAndConditions");
            }
        }

        public HtmlControl TermsAndConditionsLabel
        { 
            get
            {
                return this.Find.ByAttributes<HtmlControl>("for=TermsAndConditions");
            }
        }

        public HtmlAnchor TermsAndConditionsLink 
        {
            get 
            {
                return this.Find.ByAttributes<HtmlAnchor>("termsAndConditionsCheckboxExplanation".ToClassContainsExpression());
            }
        }

        public HtmlInputSubmit SubmitButton
        {
            get
            {
                return this.Find.ByXPath<HtmlInputSubmit>("//*[@id='MainContent']/form/fieldset/p/input");
            }
        }

        public HtmlDiv SummaryValidationErrors 
        { 
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("validation-summary-errors".ToClassContainsExpression());
            }
        }

        public HtmlSpan UsernameErrorMessage 
        { 
            get
            {
                return this.Find.ByExpression<HtmlSpan>("for=Username", "TagName=span");
            }
        }

        public HtmlSpan PasswordErrorMessage
        {
            get
            {
                return this.Find.ByExpression<HtmlSpan>("for=Password", "TagName=span");
            }
        }

        public HtmlSpan PasswordAgainErrorMessage
        {
            get
            {
                return this.Find.ByExpression<HtmlSpan>("for=PasswordAgain", "TagName=span");
            }
        }

        public HtmlSpan FirstNameErrorMessage
        {
            get
            {
                return this.Find.ByExpression<HtmlSpan>("for=FirstName", "TagName=span");
            }
        }

        public HtmlSpan LastNameErrorMessage
        {
            get
            {
                return this.Find.ByExpression<HtmlSpan>("for=LastName", "TagName=span");
            }
        }

        public HtmlSpan EmailErrorMessage
        {
            get
            {
                return this.Find.ByExpression<HtmlSpan>("for=Email", "TagName=span");
            }
        }
    }
}
