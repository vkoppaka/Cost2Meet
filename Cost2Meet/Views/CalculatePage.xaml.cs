using System;
using Xamarin.Forms;

namespace Cost2Meet
{	
	public partial class CalculatePage : ContentPage
	{	
		public int NumberOfPeopleAttending { get; set; }
		public decimal AverageRate { get; set; }

		public TimeSpan MeetingStartTime
		{
			get 
			{
				var midnight = new TimeSpan (0, 0, 0);
				if (meetingStartTime == midnight) {
					meetingStartTime += new TimeSpan (DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
				}
				return meetingStartTime;
			}
			set 
			{
				meetingStartTime = value;
			}
		}

		public TimeSpan MeetingEndTime
		{
			get 
			{
				var midnight = new TimeSpan (0, 0, 0);
				if (meetingEndTime == midnight) {
					meetingEndTime += new TimeSpan (DateTime.Now.Hour + 1, DateTime.Now.Minute, DateTime.Now.Second);
				}
				return meetingEndTime;
			}
			set 
			{
				meetingEndTime = value;
			}
		}

		public CalculatePage ()
		{
			InitializeComponent ();
			InitializeToolbar ();
			costCalculator = new CostCalculator ();
			BindingContext = this;
		}

		private void InitializeToolbar ( )
		{
			calculateButton = new ToolbarItem ( ) { Name = "Calculate" };
			calculateButton.Activated += ((object o, EventArgs e ) => CalculateMeetingCost( ));
			ToolbarItems.Add (calculateButton);
		}

		private async void CalculateMeetingCost ()
		{
			var meetingCost = costCalculator.Calculate (NumberOfPeopleAttending, AverageRate, MeetingStartTime, MeetingEndTime);

			bool okAndSave = await DisplayAlert ("This meeting cost you $" + meetingCost, "", "Ok", "Cancel");
			if ( okAndSave ) 
			{
				//Do actual save
			}
		}

		private TimeSpan meetingStartTime;
		private TimeSpan meetingEndTime;

		ToolbarItem calculateButton;


		private CostCalculator costCalculator;

	}
}

