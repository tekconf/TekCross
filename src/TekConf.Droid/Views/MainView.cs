namespace TekConf.Droid.Views
{
    using Android.App;
    using Android.OS;

    [Activity(Label = "View for MainView")]
    public class MainView : BaseView
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.MainView);
        }
    }
}