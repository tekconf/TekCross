using System;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.ViewModels;
using UIKit;

namespace TekConf.iOS.Views
{
    public class MyContainer : MvxTouchViewsContainer
    {
        protected override IMvxTouchView CreateViewOfType(Type viewType, MvxViewModelRequest request)
        {
            return (IMvxTouchView)UIStoryboard.FromName("MainStoryboard", null)
                .InstantiateViewController(viewType.Name);
        }
    }
}