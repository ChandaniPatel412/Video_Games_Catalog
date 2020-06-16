using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_Games_Catalog;
using Video_Games_Catalog.Controllers;

namespace Video_Games_Catalog.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
