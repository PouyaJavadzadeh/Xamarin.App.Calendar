using System.Collections.Generic;
using Xamarin.App.Calendar.Models;
using Xamarin.Forms;

namespace Xamarin.App.Calendar.Infrastructures
{
	internal class CrossCalendar
	{
		private static List<CalendarEvent> events = null;
		private static readonly object locker = new object();

		private CrossCalendar() { }

		public static List<CalendarEvent> Events
		{
			get
			{
				try
				{
					lock (locker)
					{
						if (events == null)
						{
							events = DependencyService.Get<ICalendar>(DependencyFetchTarget.GlobalInstance).GetEventsAsync().Result;
						}
					}
				}
				catch (System.Exception)
				{
					// TODO: Log
				}

				return events;
			}
		}
	}
}
