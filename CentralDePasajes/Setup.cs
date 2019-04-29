using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace CentralDePasajes
{
    public class Setup
    {

        public static IWebDriver Driver { get; set; }

        /// <summary>
        /// Inicializa un Driver de Chrome
        /// </summary>
        /// <param name="ImplicitWait"></param>
        /// <param name="PageLoad"></param>
        public static void InicializarConChrome(int ImplicitWait, int PageLoad, string Url = "https://www.centraldepasajes.com.ar/" )
        {
            Driver = new ChromeDriver();
            Driver.Url = Url;
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ImplicitWait);
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(PageLoad);
        }

        public static void Esperar(int Time, By Elemento)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Time));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Elemento));

        }


    }
}
