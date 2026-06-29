//Problem 3:
//Scenario: Tesla’s self-driving system operates at different autonomy levels (Manual,
//AssistedDriving, Autonomous, EmergencyOverride).
//Problem Statement:
//Define an enum AutonomyLevel to represent different levels of Tesla’s self-driving
//system.
//Implement a class TeslaCar with a method SetAutonomy(AutonomyLevel level).
//Implement a driving simulation where the car dynamically changes autonomy levels
//based on road conditions (e.g., rain, highway, urban).



using System;
enum AutonomyLevel
{
    Manual,
    AssistedDriving,
    Autonomous,
    EmergencyOverride
}

class TeslaCar
{
    public void SetAutonomy(AutonomyLevel level)
    {
        Console.WriteLine("Driving Mode: " + level);
    }
}

class Program
{
    static void Main()
    {
        TeslaCar car = new TeslaCar();

        Console.Write("Enter Road Condition: (Highway/Urban/Rain/muddyroad) ");
        string road = Console.ReadLine();

        if (road == "Highway")
        {
            car.SetAutonomy(AutonomyLevel.Autonomous);
        }
        else if (road == "Urban")
        {
            car.SetAutonomy(AutonomyLevel.AssistedDriving);
        }
        else if (road == "Rain")
        {
            car.SetAutonomy(AutonomyLevel.EmergencyOverride);
        }
        else if (road == "muddyroad")
        {
            car.SetAutonomy(AutonomyLevel.Manual);
        }
        else
        {
            Console.WriteLine("Wrong Input");
        }
    }
}
