using SQLite.Net.Attributes;

namespace Cost2Meet
{
	[Table("meetinghistory")]
	public class MeetingHistory
	{
		[Unique, PrimaryKey]
		public int ID { get; set; }

		public string History { get; set; }
	}
}

