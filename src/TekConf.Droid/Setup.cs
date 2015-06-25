using Android.Content;
using Cirrious.CrossCore.Platform;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Reflection;
using Cirrious.MvvmCross.Droid.Support.RecyclerView;

namespace TekConf.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
		
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

		protected override IList<Assembly> AndroidViewAssemblies {
			get {
				var toReturn = base.AndroidViewAssemblies;
				toReturn.Add(typeof(MvxRecyclerView).Assembly);
				return toReturn;
			}
		}
    }
}