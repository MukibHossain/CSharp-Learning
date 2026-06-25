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

        Console.Write("Enter Road Condition: (Highway/Urban/Rain) ");
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
        else
        {
            Console.WriteLine("Wrong Input");
        }
    }
}
