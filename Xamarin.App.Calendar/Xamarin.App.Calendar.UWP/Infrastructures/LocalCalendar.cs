using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.App.Calendar.Models;

[assembly: global::Xamarin.Forms.Dependency(typeof(Xamarin.App.Calendar.UWP.Infrastructures.LocalCalendar))]

namespace Xamarin.App.Calendar.UWP.Infrastructures
{
	public class LocalCalendar : Xamarin.App.Calendar.Infrastructures.ICalendar
	{
		public async Task<List<CalendarEvent>> GetEventsAsync()
		{
			//AppointmentStore store = await AppointmentManager.RequestStoreAsync(AppointmentStoreAccessType.AllCalendarsReadOnly); // why stops here?

			return new List<CalendarEvent>();
		}
	}
}
