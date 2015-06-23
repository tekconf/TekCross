// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the TestSecondViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace TekConf.Core.Tests.ViewModels
{
    using TekConf.Core.ViewModels;

    using NUnit.Framework;

    /// <summary>
    /// Defines the TestSecondViewModel type.
    /// </summary>
    [TestFixture]
    public class TestSecondViewModel : BaseTest
    {
        /// <summary>
        /// The SecondViewModel.
        /// </summary>
        private SecondViewModel secondViewModel;

        /// <summary>
        /// Creates an instance of the object to test.
        /// To allow Ninja automatically create the unit tests
        /// this method should not be changed.
        /// </summary>
        public override void CreateTestableObject()
        {
            this.secondViewModel = new SecondViewModel();
        }

        /// <summary>
        /// Tests my property.
        /// </summary>
        [Test]
        public void TestMyProperty()
        {
            //// arrange
            bool changed = false;

            this.secondViewModel.PropertyChanged += (sender, args) =>
                {
                    if (args.PropertyName == "MyProperty")
                    {
                        changed = true;
                    }
                };

            //// act
            this.secondViewModel.MyProperty = "Hello MvvmCross";

            //// assert
            Assert.AreEqual(changed, true);
        }

        /// <summary>
        /// Tests my command.
        /// </summary>
        [Test]
        public void TestMyCommand()
        {
            //// arrange

            //// act
            this.secondViewModel.MyCommand.Execute(null);

            //// assert
        }
    }
}
