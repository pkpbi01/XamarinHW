using NUnit.Framework;
using XamarinHW.ViewModels;

namespace UnitTestProject1
{
    [TestFixture]
    public class Tests
    {
        private MainPageViewModel _mainPageViewModel;

        [SetUp]
        public void Setup()
        {
            _mainPageViewModel = new MainPageViewModel();
        }

        [Test]
        public void Test1()
        {
            //Arrange

            //Act

            //Assert
            Assert.Pass();
        }
    }
}