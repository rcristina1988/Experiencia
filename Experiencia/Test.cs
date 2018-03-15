using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Experiencia
{
    [TestFixture()]
    public class Test
    {
		private IWebDriver driver;
        string url = "https://mobilewebserver9-switchstudios.installprogram.eu/MobileWebGames/game/mgs/7_4_3_4595?lobbyURL=https%3A%2F%2Fmobilewebserver9-switchstudios.installprogram.eu%2FLobby%2Fen%2FIslandParadise%2FGames%2F3ReelSlots&moduleID=2&clientID=40302&gameName=switchEuropeanRoulette&gameTitle=Roulette&LanguageCode=en&clientTypeID=40&casinoID=5007&lobbyName=IslandParadise&loginType=PlayerService&bankingURL=https%3A%2F%2Fmobilewebserver9-switchstudios.installprogram.eu%2FLobby%2Fen%2FIslandParadise%2FBanking&xmanEndPoints=https%3A%2F%2Fmobilewebserver9-SwitchStudios.installprogram.eu%2FXMan%2Fx.x&routerEndPoints=&disablePoweredBy=false&currencyFormat=&isPracticePlay=true&logoutURL=https%3A%2F%2Fmobilewebserver9-switchstudios.installprogram.eu%2FLobby%2Fen%2FIslandParadise%2FLogout&host=Desktop&activityStatementURL=undefined";
        string element = "return Switchbox.automation.find('betDisplayValue')";
        [Test()]

        public void TestCase()
        {
            driver = new ChromeDriver(@"/Users/ritacristina/Downloads");
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
            Thread.Sleep(10000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Dictionary<string, object> result = js.ExecuteScript(element) as Dictionary<string, object>;
            string displayedValue = result["displayedValue"].ToString();
            Assert.That(displayedValue.Equals("0.00"));
            driver.Quit();
           
        }
    }
}
