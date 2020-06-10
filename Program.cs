using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tinder
{
    class Program
    {
        static void Main(string[] args)
        {

        //    IWebDriver driver = new ChromeDriver();
        //     AcessaTinder();
            
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://tinder.com/");
            //Thread.Sleep(2000);

            //Cookie
            IWebElement confirmaCookie = driver.FindElement(By.XPath("//span[contains(text(),'Aceito')]"));
            confirmaCookie.Click();
            Thread.Sleep(1500);

            
            //Faz login com Facebook
        //     IWebElement loginFacebook = driver.FindElement(By.XPath("//div[@id='modal-manager']//div[2]//button[1]"));
        //     loginFacebook.Click();
        //    // Thread.Sleep(1000);

        //     driver.SwitchTo().Window(driver.WindowHandles[1]);
        //     //Thread.Sleep(2000);

        //     IWebElement emailFb = driver.FindElement(By.XPath("//input[@id='email']"));
        //     emailFb.Click();
        //     emailFb.SendKeys("");
        //     Thread.Sleep(500);
        //     IWebElement senhaFb = driver.FindElement(By.XPath("//input[@id='pass']"));
        //     senhaFb.Click();
        //     senhaFb.SendKeys("");
        //     Thread.Sleep(300);
        //     IWebElement BtnLogin = driver.FindElement(By.XPath("//input[@id='u_0_0']"));
        //     BtnLogin.Click();
        //     Thread.Sleep(300);
        //Login com Facebook

        // Login com Numero telefone

        // IWebElement loginTelefone = driver.FindElement(By.XPath("//span[contains(text(),'Entrar com número de telefone')]"));
        // loginTelefone.Click();
        // Thread.Sleep(500);
        // IWebElement CampoTelefone = driver.FindElement(By.XPath("//input[@name='phone_number']"));
        // CampoTelefone.Click();
        // CampoTelefone.SendKeys("");
        // Thread.Sleep(500);

        // IWebElement confirmaLoginTelefone = driver.FindElement(By.XPath("//span[@class='Pos(r) Z(1)'][contains(text(),'Continuar')]"));
        // confirmaLoginTelefone.Click();

        // Login com numero de telefone


        // Login com google

        IWebElement loginGoogle = driver.FindElement(By.XPath("//span[contains(text(),'Entrar com o Google')]"));
        loginGoogle.Click();
        Thread.Sleep(500);

        driver.SwitchTo().Window(driver.WindowHandles[1]);

        // IWebElement minhaConta = driver.FindElement(By.XPath("//div[@class='w1I7fb']")); // Caso a conta já esteja salva
        IWebElement minhaConta = driver.FindElement(By.XPath("//input[@id='identifierId']"));
        minhaConta.Click();
        minhaConta.SendKeys("");
        Thread.Sleep(800);

        IWebElement btnAvacar = driver.FindElement(By.XPath("//span[contains(text(),'Próxima')]"));
        btnAvacar.Click();
        Thread.Sleep(1000);

        IWebElement minhaContaSenha = driver.FindElement(By.XPath("//input[@name='password']"));
        minhaContaSenha.Click();
        Thread.Sleep(200);
        minhaContaSenha.SendKeys("");
        Thread.Sleep(200);

        IWebElement minhaContaLogin = driver.FindElement(By.XPath("//span[contains(text(),'Próxima')]"));
        minhaContaLogin.Click();
        Thread.Sleep(500);

        
       
        
        


        }

        public static void AcessaTinder()
        {
            // IWebDriver driver = new ChromeDriver();
            // driver.Navigate().GoToUrl("https://tinder.com/");
            // driver.Manage().Window.Maximize();
        }

        public static void FazLogin()
        {
        
        }

    }
}
