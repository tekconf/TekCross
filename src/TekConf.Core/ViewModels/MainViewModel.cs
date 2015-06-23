// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the MainViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Collections.ObjectModel;
using TekConf.Core.ViewModels;

namespace TekConf.Core.ViewModels
{
    public class Conference
    {
        public string Slug { get; set; }
        public string Name { get; set; }

    }
    /// <summary>
    /// Define the MainViewModel type.
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            this.Conferences = new ObservableCollection<Conference>(new List<Conference>() { new Conference(){ Name ="C1", Slug = "S1"}});
        }
        public ObservableCollection<Conference> Conferences { get; set; }
    }
}
