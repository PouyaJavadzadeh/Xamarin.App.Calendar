namespace Xamarin.App.Calendar.UWP
{
	public sealed partial class MainPage
	{
		public MainPage()
		{
			this.InitializeComponent();

			LoadApplication(new Xamarin.App.Calendar.App());

			// Why this method works?
			//Xamarin.Forms.Device.BeginInvokeOnMainThread(async () =>
			//{
			//	var store = await AppointmentManager.RequestStoreAsync(AppointmentStoreAccessType.AllCalendarsReadOnly);
			//	var calendars = await store.FindAppointmentCalendarsAsync(FindAppointmentCalendarsOptions.IncludeHidden);
			//	foreach (var item in calendars)
			//	{
			//		Debug.WriteLine(item.CanCancelMeetings);
			//		Debug.WriteLine(item.CanCreateOrUpdateAppointments);
			//		Debug.WriteLine(item.CanForwardMeetings);
			//		Debug.WriteLine(item.CanNotifyInvitees);
			//		Debug.WriteLine(item.CanProposeNewTimeForMeetings);
			//		Debug.WriteLine(item.CanUpdateMeetingResponses);
			//		Debug.WriteLine(item.DisplayColor);
			//		Debug.WriteLine(item.DisplayName);
			//		Debug.WriteLine(item.IsHidden);
			//		Debug.WriteLine(item.LocalId);
			//		Debug.WriteLine(item.MustNofityInvitees);
			//		Debug.WriteLine(item.OtherAppReadAccess);
			//		Debug.WriteLine(item.OtherAppWriteAccess);
			//		Debug.WriteLine(item.RemoteId);
			//		Debug.WriteLine(item.SourceDisplayName);
			//		Debug.WriteLine(item.SummaryCardView);
			//		Debug.WriteLine(item.SyncManager);
			//		Debug.WriteLine(item.UserDataAccountId);
			//	}
			//});
		}
	}
}
