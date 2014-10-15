using System;
using System.Collections.Generic;
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
			BindingContext = this;
		}

		private TimeSpan meetingStartTime;
		private TimeSpan meetingEndTime;


	}
}

