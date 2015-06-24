// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the MainViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Collections.ObjectModel;
using TekConf.Core.ViewModels;
using Fusillade;
using System.Threading.Tasks;
using System.Linq;

namespace TekConf.Core.ViewModels
{
	public class MainViewModel : BaseViewModel
	{
		readonly IRemoteDataService _remoteDataService;

		public MainViewModel (IRemoteDataService remoteDataService)
		{
			_remoteDataService = remoteDataService;

			this.Conferences = new ObservableCollection<ConferenceDto> (
				new List<ConferenceDto> () { 
					new ConferenceDto () {
						Name = "C1",
						Slug = "S1"
				} });

			Load ();
		}

		private async Task Load() 
		{
			var conferences  = await _remoteDataService.GetConferencesAsync (Priority.UserInitiated, force: false);
			this.Conferences = new ObservableCollection<ConferenceDto>(conferences.ToList());
		}
		public ObservableCollection<ConferenceDto> Conferences { get; set; }
	}
}