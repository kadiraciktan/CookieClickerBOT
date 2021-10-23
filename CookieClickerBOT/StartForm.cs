using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace CookieClickerBOT
{
    public partial class StartForm : Form
    {
        IWebDriver WebDriver;
        IWebElement CookieElement;
        private bool active = false;

        public StartForm()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            active = !active;
            NumTime.Enabled = !active;

            if (WebDriver is null)
            {
                //Webdriver Interfaceine Chrome kullanacağımızı belirtiyoruz.
                WebDriver = ChromeDriverInit();
                //Web Adresimize Gidiyoruz
                WebDriver.Navigate().GoToUrl("https://orteil.dashnet.org/cookieclicker/");
                // Tıklayacağımız nesnemizi seçiyoruz
                CookieElement = WebDriver.FindElement(By.Id("bigCookie"));
            }

            // PROGRAMIMIZIN ASENKRON OLARAK TIKLAMA YAPMASINI SAĞLIYORUZ
            Thread _thread = new Thread(() =>
            {
                if (CookieElement != null)
                {
                    while (active)
                    {
                        try
                        {
                            Thread.Sleep((int)NumTime.Value);
                            CookieElement.Click();
                        }
                        catch { }
               
                    }
                }
            });

            _thread.Start();


        }

        public ChromeDriver ChromeDriverInit()
        {
            var chromeOptions = new ChromeOptions();
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            return new ChromeDriver(chromeDriverService, chromeOptions);
        }

        public void CheckProcesses()
        {
            if (WebDriver != null)
            {
                WebDriver.Dispose();

                Process[] killChrome = Process.GetProcessesByName("chromedriver.exe");

                foreach (var process in killChrome)
                {
                    process.Kill();
                }

            }
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // açık olan driverları dispose ediyoruz.
            CheckProcesses();
        
        }
    }
}
