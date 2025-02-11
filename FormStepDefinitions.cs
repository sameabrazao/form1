using FormSelenium.Specs.Drivers;
using FormSelenium.Specs.PageObjects;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace FormSelenium.Specs.Steps
{
    [Binding]
    public sealed class FormStepDefinitions
    {
        //page object para formulário
        private readonly FormPageObject _formPageObject;

        public FormStepDefinitions(BrowserDriver browserDriver)
        {
            _formPageObject = new FormPageObject(browserDriver.Current);
        }

        [Given(" that user  fill in their first name (.*)")]
        public void GivenThatUserFillInTheirFirstName(string name)
        {
            _formPageObject.EnterFirstName(name);
        }

        [Given("last name (.*)")]
        public void GivenLastName(string lastname)
        {
            _formPageObject.EnterLastName(lastname);
        }

        [Given("telephone number (.*)")]
        public void GivenTelephoneNumber(string telephonenumber)
        {
            _formPageObject.EnterLastName(telephonenumber);
        }

        [When("click in send")]
        public void WhenClickSend()
        {
            _formPageObject.ClickAdd();
        }

        [Then("should show (.*)")]
        public void ThenShouldShow(string expectedResult)
        {
            var actualResult = _formPageObject.WaitForNonEmptyResult();

            actualResult.Should().Be(expectedResult);
            //assertTrue(actualResult.isMessageWithSubjectIsUnread("Enviado com sucesso"));
        }
        
        [Then("should close message")]
        public void ThenShouldCloseMessage()
        {
        	_formPageObject.CloseMessage();
        }	
    }
}


