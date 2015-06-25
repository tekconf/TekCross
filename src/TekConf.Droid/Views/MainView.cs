using Android.Support.V7.Widget;
using Cirrious.MvvmCross.Droid.Support.RecyclerView;

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

			var recyclerView = FindViewById<MvxRecyclerView>(Resource.Id.my_recycler_view);
			recyclerView.HasFixedSize = true;

			var layoutManager = new LinearLayoutManager(this);
			recyclerView.SetLayoutManager(layoutManager);
        }
    }
}