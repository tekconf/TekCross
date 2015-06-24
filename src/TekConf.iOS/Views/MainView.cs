using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;

namespace TekConf.iOS.Views
{
    using TekConf.Core.ViewModels;
    using Foundation;
    using UIKit;

    [Register("MainView")]
    public class MainView : MvxTableViewController
    {
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var source = new TableSource(TableView);

			var bindings = this.CreateBindingSet<MainView, MainViewModel>();
			bindings.Bind(source).To(vm => vm.Conferences);
			bindings.Apply ();

			TableView.Source = source;
			TableView.ReloadData();
		}

		public class TableSource : MvxStandardTableViewSource
		{
			private static readonly NSString Identifier = new NSString("MenuCellIdentifier");
			private const string BindingText = "TitleText Name";

			#warning Switch to new base constructor when released...
			public TableSource(UITableView tableView)
				: base(tableView, UITableViewCellStyle.Default, Identifier, BindingText)
			{
			}
		}
    }
}