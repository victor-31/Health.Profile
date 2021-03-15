// program to test out the class


using System;

class HealthProfileTest
{
    public static void Main(string[] args)
    {
        HealthProfile hpp = new HealthProfile(null, null, 0, 0, 0, 0, 0, null);

        Console.Write("Enter First Name: ");
        hpp.FirstName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Last Name: ");
        hpp.LastName = Convert.ToString(Console.ReadLine());
        Console.Write("Enter Day of Birth: ");
        hpp.DayOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Month of Birth: ");
        hpp.MonthOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Year of Birth: ");
        hpp.YearOfBirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Weight in pounds: ");
        hpp.WeightInPounds = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Height in inches: ");
        hpp.HeightInInches = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Gender: ");
        hpp.Gender = Convert.ToString(Console.ReadLine());

        
        
        hpp.DisplayFirstName();
        hpp.DisplayLastName();
        hpp.DisplayDayOfBirth();
        hpp.DisplayMonthOfBirth();
        hpp.DisplayYearOfBirth();
        hpp.DisplayWeightInPounds();
        hpp.DisplayHeightInInches();
        hpp.DisplayGender();
        hpp.DisplayYearsOfAgeSimple();
        hpp.DisplayMaxHeartRate();
        hpp.DisplayTargetHeartRate();
        hpp.DisplayBodyMassIndex();
        hpp.DisplayBMIOutput();
        hpp.DisplayBMIChart();        
    }
}