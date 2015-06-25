// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the TestMainViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace TekConf.Core.Tests.ViewModels
{
    using TekConf.Core.ViewModels;

    using NUnit.Framework;

    /// <summary>
    /// Defines the TestMainViewModel type.
    /// </summary>
    [TestFixture]
    public class TestMainViewModel : BaseTest
    {
        /// <summary>
        /// The MainViewModel.
        /// </summary>
        private MainViewModel mainViewModel;

        /// <summary>
        /// Creates an instance of the object to test.
        /// To allow Ninja automatically create the unit tests
        /// this method should not be changed.
        /// </summary>
        public override void CreateTestableObject()
        {
            //this.mainViewModel = new MainViewModel();
        }
    }
}
