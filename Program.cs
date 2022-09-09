//A code to find occupancy percentage of a hotel and the pay needed for five workers who share equal hours and receive overtime after 8 hours
double roomsBooked;
Console.WriteLine ("How many rooms are booked?");
roomsBooked = int.Parse(Console.ReadLine());


double totalRooms;
Console.WriteLine(("Enter the total amount of rooms"));
totalRooms = int.Parse(Console.ReadLine());


double HOURS_PER_ROOM = 1.25;
double CLEANERS_WAGE = 12.37;

double occupanyRate = (roomsBooked/totalRooms) * 100;
occupanyRate = Math.Round(occupanyRate,2);

double hoursToClean = roomsBooked * HOURS_PER_ROOM;

double costOfCleaners;
double employees = 5;
double shiftLength = 8;
double hoursAssigned;
double overTimeRate = 1.5;

hoursAssigned = hoursToClean / employees; 

if (hoursAssigned > shiftLength) {
    double overTime = (hoursAssigned - shiftLength);
    costOfCleaners = ((overTime * overTimeRate * CLEANERS_WAGE) + (CLEANERS_WAGE * shiftLength)) * employees;
    costOfCleaners = Math.Round(costOfCleaners,2);

}

else {
    costOfCleaners = hoursToClean * CLEANERS_WAGE;
    costOfCleaners = Math.Round(costOfCleaners,2);
}


System.Console.WriteLine("The occupancy rate is: " + occupanyRate + "%");
System.Console.WriteLine("The cost to clean rooms for the day is : " + costOfCleaners); 

