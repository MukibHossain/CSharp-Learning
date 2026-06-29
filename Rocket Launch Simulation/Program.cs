//Problem 1:
//Scenario: SpaceX rockets have multiple stages, each serving a different purpose during a
//launch. You need to create an enumeration that represents different rocket stages (PreLaunch,
//Liftoff, StageSeparation, OrbitInsertion, Reentry, Landing).
//Problem Statement:
//Define an enum RocketStage representing the different stages of a rocket launch.
//Write a Rocket class that has a method AdvanceStage() to transition to the next stage.
//Implement a program that simulates a SpaceX rocket launch by advancing through all
//stages and printing the current stage.
//Output:
//Preparing for launch.
//Liftoff! Rocket is ascending.
//Stage separation successful.
//Rocket has reached orbit.
//Reentering Earth's atmosphere.
//Rocket has landed successfully.

using System;
enum RocketStage
{
    PreLaunch,
    Liftoff,
    StageSeparation,
    OrbitInsertion,
    Reentry,
    Landing
}

class Rocket
{
    public void AdvanceStage(RocketStage stage)
    {
        if (stage == RocketStage.PreLaunch)
            Console.WriteLine("Preparing for launch.");

        else if (stage == RocketStage.Liftoff)
            Console.WriteLine("Liftoff! Rocket is ascending.");

        else if (stage == RocketStage.StageSeparation)
            Console.WriteLine("Stage separation successful.");

        else if (stage == RocketStage.OrbitInsertion)
            Console.WriteLine("Rocket has reached orbit.");

        else if (stage == RocketStage.Reentry)
            Console.WriteLine("Reentering Earth's atmosphere.");

        else if (stage == RocketStage.Landing)
            Console.WriteLine("Rocket has landed successfully.");
    }
}

class Program
{
    static void Main()
    {
        Rocket rocket = new Rocket();

        rocket.AdvanceStage(RocketStage.PreLaunch);
        rocket.AdvanceStage(RocketStage.Liftoff);
        rocket.AdvanceStage(RocketStage.StageSeparation);
        rocket.AdvanceStage(RocketStage.OrbitInsertion);
        rocket.AdvanceStage(RocketStage.Reentry);
        rocket.AdvanceStage(RocketStage.Landing);
    }
}
