// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the SecondView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace TekConf.Droid.Views
{
    using Android.App;
    using Android.OS;

    /// <summary>
    /// Defines the SecondView type.
    /// </summary>
    [Activity(Label = "View for SecondView")]
    public class SecondView : BaseView
    {
        /// <summary>
        /// Called when [create].
        /// </summary>
        /// <param name="bundle">The bundle.</param>
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.SecondView);
        }
    }
}