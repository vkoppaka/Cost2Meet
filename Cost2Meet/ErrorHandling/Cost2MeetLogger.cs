using System;
using Xamarin;

namespace Cost2Meet
{
	public static class Cost2MeetLogger
	{
		public static void LogException(Exception ex)
		{
			Insights.Report (ex);
		}
	}
}

