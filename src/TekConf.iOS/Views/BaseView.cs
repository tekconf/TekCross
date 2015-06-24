using Cirrious.MvvmCross.Touch.Views;
using Foundation;
using UIKit;

namespace TekConf.iOS.Views
{
    public abstract class BaseView : MvxViewController
    {
        protected BaseView()
        {
            this.Initialize();
        }
			
        protected BaseView(string nibName, NSBundle bundle)
            : base(nibName, bundle)
        {
            this.Initialize();
        }

        private void Initialize()
        {
            this.EdgesForExtendedLayout = UIRectEdge.None;
        }
    }
}