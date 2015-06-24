using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Polly;
using System.Net;
using Fusillade;
using System.Linq;

namespace TekConf.Core
{
	
	public class RemoteDataService : IRemoteDataService
	{
		IApiService _apiService;

		public RemoteDataService (IApiService apiService)
		{
			this._apiService = apiService;
			
		}
		public async Task<IEnumerable<ConferenceDto>> GetConferencesAsync (Priority priority, bool force)
		{
			List<ConferenceDto> conferences = null;
			Task<List<ConferenceDto>> getConferencesTask;
			switch (priority) {
			case Priority.Background:
				getConferencesTask = _apiService.Background.GetConferences ();
				break;
			case Priority.UserInitiated:
				getConferencesTask = _apiService.UserInitiated.GetConferences ();
				break;
			case Priority.Speculative:
				getConferencesTask = _apiService.Speculative.GetConferences ();
				break;
			default:
				getConferencesTask = _apiService.UserInitiated.GetConferences ();
				break;
			}

			conferences = await Policy
				.Handle<WebException> ()
				.WaitAndRetryAsync
				(
					retryCount: 5, 
					sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds (Math.Pow (2, retryAttempt))
				).ExecuteAsync (() => getConferencesTask);

			if (conferences != null && conferences.Any ()) {
				if (force) {
					conferences = conferences.OrderBy (c => c.Start).ToList ();
				} else {
					conferences = conferences.OrderBy (c => c.Start).ToList ();

				}
			}
			return conferences;
		}
	}
}