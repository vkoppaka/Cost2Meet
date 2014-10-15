using System;

namespace Cost2Meet
{
	public class CostCalculator
	{
		public decimal Calculate(int numberOfPeople, decimal averageRate, TimeSpan startTime, TimeSpan endTime)
		{
			if (endTime < startTime)
			{
				throw new InvalidDatesException("meeting end time cannot be less than start time");
			}

			TimeSpan difference = endTime - startTime;

			decimal totalHours = difference.Hours + (difference.Minutes / 60);

			decimal moneySpent = Math.Round(numberOfPeople * averageRate * totalHours, 2);


			return moneySpent;
		}
	}
}

