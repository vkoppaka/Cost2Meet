using System;

namespace Cost2Meet
{
	public class InvalidDatesException : Exception
	{
		public InvalidDatesException()
		{

		}

		public InvalidDatesException(string message)
			: base(message)
		{

		}
	}
}

