// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the SecondView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using CoreGraphics;

namespace TekConf.iOS.Views
{
    using System.Drawing;

    using Cirrious.MvvmCross.Binding.BindingContext;

    using Core.ViewModels;
    using Foundation;
    using UIKit;

    /// <summary>
    /// Defines the SecondView type.
    /// </summary>
    [Register("SecondView")]
    public class SecondView : BaseView
    {
        /// <summary>
        /// Views the did load.
        /// </summary>
        /// <summary>
        /// Called when the View is first loaded
        /// </summary>
        public override void ViewDidLoad()
        {
            this.View = new UIView { BackgroundColor = UIColor.White };

            base.ViewDidLoad();

            UILabel uiLabel = new UILabel(new CGRect(10, 10, 300, 40));
            View.AddSubview(uiLabel);
            UITextField uiTextField = new UITextField(new CGRect(10, 50, 300, 40));
            View.AddSubview(uiTextField);

            var set = this.CreateBindingSet<SecondView, SecondViewModel>();
            set.Bind(uiLabel).To(vm => vm.MyProperty);
            set.Bind(uiTextField).To(vm => vm.MyProperty);
            set.Apply();

            UITapGestureRecognizer tap = new UITapGestureRecognizer(() => uiTextField.ResignFirstResponder());
            View.AddGestureRecognizer(tap);
        }
    }
}
