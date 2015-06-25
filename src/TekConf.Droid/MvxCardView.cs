//using Android.Views;
//using Android.Support.V7.Widget;
//using Cirrious.MvvmCross.Binding.BindingContext;
//using Cirrious.MvvmCross.Binding.Droid.BindingContext;
//using Android.Content;
//using Android.Util;
//using Cirrious.MvvmCross.Binding.Droid.Views;
//using Cirrious.CrossCore;
//using System;
//using Android.Runtime;
//using Cirrious.MvvmCross.Binding.Attributes;
//
//namespace TekConf.Droid
//{
//	public class MvxCardView : CardView, IMvxBindingContextOwner
//	{
//		private object _cachedDataContext;
//		private bool _isAttachedToWindow;
//		private readonly int _templateId;
//		private readonly IMvxAndroidBindingContext _bindingContext;
//
//		public MvxCardView(Context context, IAttributeSet attrs)
//			: this(MvxAttributeHelpers.ReadTemplateId(context, attrs), context, attrs)
//		{
//		}
//
//		public MvxCardView(int templateId, Context context, IAttributeSet attrs)
//			: base(context, attrs)
//		{
//			_templateId = templateId;
//
//			if (!(context is IMvxLayoutInflater))
//			{
//				throw Mvx.Exception("The owning Context for a MvxCardView must implement LayoutInflater");
//			}
//
//			_bindingContext = new MvxAndroidBindingContext(context, (IMvxLayoutInflater)context);
//			this.DelayBind(() =>
//				{
//					if (Content == null && _templateId != 0)
//					{
//						Mvx.Trace("DataContext is {0}", DataContext == null ? "Null" : DataContext.ToString());
//						Content = _bindingContext.BindingInflate(_templateId, this);
//					}
//				});
//		}
//
//
//		protected MvxCardView(IntPtr javaReference, JniHandleOwnership transfer)
//			: base(javaReference, transfer)
//		{
//		}
//
//		protected IMvxAndroidBindingContext AndroidBindingContext
//		{
//			get { return _bindingContext; }
//		}
//
//		public IMvxBindingContext BindingContext
//		{
//			get { return _bindingContext; }
//			set { throw new NotImplementedException("BindingContext is readonly in the list item"); }
//		}
//
//		protected View Content { get; set; }
//
//		protected override void Dispose(bool disposing)
//		{
//			if (disposing)
//			{
//				this.ClearAllBindings();
//				_cachedDataContext = null;
//			}
//
//			base.Dispose(disposing);
//		}
//
//		protected override void OnAttachedToWindow()
//		{
//			base.OnAttachedToWindow();
//			_isAttachedToWindow = true;
//			if (_cachedDataContext != null
//				&& DataContext == null)
//			{
//				DataContext = _cachedDataContext;
//			}
//		}
//
//		protected override void OnDetachedFromWindow()
//		{
//			_cachedDataContext = DataContext;
//			DataContext = null;
//			base.OnDetachedFromWindow();
//			_isAttachedToWindow = false;
//		}
//
//		[MvxSetToNullAfterBinding]
//		public object DataContext
//		{
//			get { 
//				return _bindingContext.DataContext; 
//			}
//			set
//			{
//				if (_isAttachedToWindow)
//				{
//					_bindingContext.DataContext = value;
//				}
//				else
//				{
//					_cachedDataContext = value;
//					if (_bindingContext.DataContext != null)
//					{
//						_bindingContext.DataContext = null;
//					}
//				}
//			}
//		}
//	}
//}
