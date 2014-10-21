namespace QA.TILS.Modules.Users.Core.Pages.RegistrationPage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using QA.Framework.Core.Extensions;

    public class RegistrationPageValidator
    {
        public RegistrationPageValidator(RegistrationPage initialRegistrationPage)
        {
            this.RegistrationPage = initialRegistrationPage;
        }

        public RegistrationPage RegistrationPage { get; private set; }

        public void VerifyUserNameErrorMessage(string errorMessage)
        {
            this.RegistrationPage.Elements.UsernameErrorMessage.AssertTextEquals(errorMessage);
        }

        public void VerifyImmediateValidationErrorMessages(string forUserName, string forPassword, string forPasswordAgain, string forFirstName, string forLastName, string forEmail)
        {
            this.RegistrationPage.Elements.UsernameErrorMessage.AssertTextEquals(forUserName);
            this.RegistrationPage.Elements.PasswordErrorMessage.AssertTextEquals(forPassword);
            this.RegistrationPage.Elements.PasswordAgainErrorMessage.AssertTextEquals(forPasswordAgain);
            this.RegistrationPage.Elements.FirstNameErrorMessage.AssertTextEquals(forFirstName);
            this.RegistrationPage.Elements.LastNameErrorMessage.AssertTextEquals(forLastName);
            this.RegistrationPage.Elements.EmailErrorMessage.AssertTextEquals(forEmail);
        }

        public void VerifySummaryValidationErrorMessages(params string[] errorMessages)
        {
            this.RegistrationPage.Elements.SummaryValidationErrors.Wait.ForExists();
            for (int index = 0; index < errorMessages.Length; index++)
            {
                this.RegistrationPage.Elements.SummaryValidationErrors.AssertTextIsContained(errorMessages[index]);
            }
        }

        public void VerifyEmptyFieldsImmediateErrorMessages()
        {
            this.VerifyImmediateValidationErrorMessages(
                ErrorMessages.UserNameMissing,
                ErrorMessages.PasswordMissing,
                ErrorMessages.PasswordAgainMissing,
                ErrorMessages.FirstNameMissing,
                ErrorMessages.LastNameMissing,
                ErrorMessages.EmailMissing);
        }

        public void VerifyEmptyFieldsSummaryErrorMessages()
        {
            this.VerifySummaryValidationErrorMessages(
                ErrorMessages.UserNameMissing,
                ErrorMessages.PasswordMissing,
                ErrorMessages.PasswordAgainMissing,
                ErrorMessages.FirstNameMissing,
                ErrorMessages.LastNameMissing,
                ErrorMessages.EmailMissing);
        }
    }
}
