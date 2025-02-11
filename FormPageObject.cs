using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FormSelenium.Specs.PageObjects
{
   
    public class FormPageObject
    {
        //url do formulário
        private const string FormUrl = "https://imagens.amcom.com.br/HTML/testeQA_1_1.html";

        //browserDriver
        private readonly IWebDriver _webDriver;
        
        //tempo de espera padrão
        public const int DefaultWaitInSeconds = 5;

        public FormPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        //mapeamento dos elementos pelo id
        private IWebElement FirstNameElement => _webDriver.FindElement(By.Id("nome"));
        private IWebElement LastNameElement => _webDriver.FindElement(By.Id("sobrenome"));
        private IWebElement TelephoneNumberElement => _webDriver.FindElement(By.Id("telefone"));
        private IWebElement SendButtonElement => _webDriver.FindElement(By.Id("enviar"));
        private IWebElement ResultElement => _webDriver.FindElement(By.Id("modal"));
        private IWebElement CloseMessageElement => _webDriver.FindElement(By.Id("close");
        
        //funções para executar as ações desejadas de preenchimento de campos e cliques
        public void EnterFirstName(string name)
        {
            //na primeira linha limpa o campo e na segunda preenche
            FirstNameElement.Clear();
            FirstNameElement.SendKeys(name);
        }

        public void EnterLastName(string lastname)
        {
            LastNameElement.Clear();
            LastNameElement.SendKeys(lastname);
        }

        public void EnterTelephoneNumber(string telephonenumber)
        {
            TelephoneNumberElement.Clear();
            TelephoneNumberElement.SendKeys(telephonenumber);
        }

        public void ClickSend()
        {
            //clica no botão enviar
            SendButtonElement.Click();
        }
        

        //função para aguardar um valor existente
        public string WaitForNonEmptyResult()
        {
            return WaitUntil(
                () => ResultElement.GetAttribute("value"),
                result => !string.IsNullOrEmpty(result));
        }


        //função para aguardar um valor vazio
        public string WaitForEmptyResult()
        {
            return WaitUntil(
                () => ResultElement.GetAttribute("value"),
                result => result == string.Empty);
        }


        //função auxiliar para tratar excessão
        private T WaitUntil<T>(Func<T> getResult, Func<T, bool> isResultAccepted) where T: class
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(DefaultWaitInSeconds));
            return wait.Until(driver =>
            {
                var result = getResult();
                if (!isResultAccepted(result))
                    return default;

                return result;
            });
        }
        
         public void CloseMessage()
        {
            //clica no botão enviar
            CloseMessageElement.Click();
        }
    }
}
