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


