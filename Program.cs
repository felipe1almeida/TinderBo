using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tinder
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();            
            AutoLike(driver);
            // LerSenha();
        }

        public static void AcessaTinder(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://tinder.com/");
        }

        public static void AutoLike(IWebDriver driver)
        {
            
            AcessaTinder(driver);
            ConfirmaCookie(driver);
            LoginGoogle(driver);
            HabilitaLocalizacaoEPopUp(driver);
            Thread.Sleep(8000);
            
           
                for(;;)
                {
                    int nAleatorio = NumerosAleatorios(driver);
                    if (nAleatorio < 70)
                    {
                        Thread.Sleep(800);
                        try
                        {
                            Like(driver);
                        }
                        catch (WebDriverException)
                        {
                            try
                            {
                                Thread.Sleep(500);
                                PopupAddHome(driver);
                            }
                            catch (WebDriverException)
                            {
                                Thread.Sleep(800);
                                MandaOi(driver);
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(300);
                        Dislike(driver);
                    }
                }
        }

        public static void LoginFacebook(IWebDriver driver)
        {
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
        }

        public static void LoginTelefone(IWebDriver driver)
        {
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
        }
        
        public static void LoginGoogle(IWebDriver driver)
        {
            Thread.Sleep(3500);
            IWebElement loginGoogle = driver.FindElement(By.XPath("//span[contains(text(),'Entrar com o Google')]"));
            loginGoogle.Click();
            Thread.Sleep(3000);

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            // IWebElement minhaConta = driver.FindElement(By.XPath("//div[@class='w1I7fb']")); // Caso a conta já esteja salva
            IWebElement minhaConta = driver.FindElement(By.XPath("//input[@id='identifierId']"));
            minhaConta.Click();
            minhaConta.SendKeys("");
            Thread.Sleep(1500);

            IWebElement btnAvacar = driver.FindElement(By.XPath("//span[contains(text(),'Próxima')]"));
            btnAvacar.Click();
            Thread.Sleep(3000);

            IWebElement minhaContaSenha = driver.FindElement(By.XPath("//input[@name='password']"));
            minhaContaSenha.Click();
            Thread.Sleep(800);
            minhaContaSenha.SendKeys("");
            Thread.Sleep(1200);

            IWebElement minhaContaLogin = driver.FindElement(By.XPath("//span[contains(text(),'Próxima')]"));
            minhaContaLogin.Click();
            Thread.Sleep(5000);
            driver.SwitchTo().Window(driver.WindowHandles[0]);
        }
        public static void ConfirmaCookie(IWebDriver driver)
        {
            IWebElement confirmaCookie = driver.FindElement(By.XPath("//span[contains(text(),'Aceito')]"));
            confirmaCookie.Click();
        }

        public static void Like(IWebDriver driver)
        {
            string l = "/"+"/*[name()='path' and contains(@d,'M21.994 10')]";
            IWebElement like = driver.FindElement(By.XPath(l));
            
            like.Click();
        }

        public static void HabilitaLocalizacaoEPopUp(IWebDriver driver)
        {
            Thread.Sleep(3000);
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("prefs", "profile.default_content_setting_values.geolocation", "1");
                    
            Thread.Sleep(3000);
            IWebElement habilitaLocalizacao = driver.FindElement(By.XPath("//span[@class='Pos(r) Z(1) Fz($xs)']"));
            habilitaLocalizacao.Click();
            Thread.Sleep(300);

            IWebElement naoTenhoInteresseNotificacao = driver.FindElement(By.XPath("//span[@class='Pos(r) Z(1) Fz($xs) C($c-dark-gray)']"));
            naoTenhoInteresseNotificacao.Click();
        }
       
        public static void FechaMatch(IWebDriver driver)
        {
            IWebElement FechaMatch = driver.FindElement(By.XPath("//a[@class='Pt(20px) Pb(40px) C(#fff) Fw($bold) Tt(u) Lts($ls-s) D(b) W(100%) Trsdu($slow) active']"));
            FechaMatch.Click();
        }
        public static void MandaOi(IWebDriver driver)
        {
            Thread.Sleep(400);
            IWebElement campoTexto = driver.FindElement(By.XPath("//textarea[@id='chat-text-area']"));
            campoTexto.Click();
            Thread.Sleep(300);
            campoTexto.SendKeys("Ei");
            Thread.Sleep(500);
            IWebElement enviaMsg = driver.FindElement(By.XPath("//span[contains(text(),'Enviar')]"));
            enviaMsg.Click();
        }

        public static void PopupAddHome(IWebDriver driver)
        {
            IWebElement popup = driver.FindElement(By.XPath("//span[contains(text(),'Não tenho interesse')]"));
            popup.Click();
        }

        public static void Dislike(IWebDriver driver)
        {
            string d = "/"+"/*[name()='path' and contains(@d,'M14.926 12')]";
            IWebElement dislike = driver.FindElement(By.XPath(d));
            dislike.Click();
        }

        public static int NumerosAleatorios(IWebDriver driver)
        {
            Random nAleatorios = new Random();
            int n = nAleatorios.Next(1, 100);

            return n;
        }

        public static string LerSenha()
        {
            string[] lines = System.IO.File.ReadAllLines(@"password.txt");

            string email = lines[0];
            string senha = lines[1];           

            return email;
        }


    }
}
