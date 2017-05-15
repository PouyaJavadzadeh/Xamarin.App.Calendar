using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.App.Calendar.Models;

namespace Xamarin.App.Calendar.Infrastructures
{
	public interface ICalendar
	{
		Task<List<CalendarEvent>> GetEventsAsync();
	}
}
