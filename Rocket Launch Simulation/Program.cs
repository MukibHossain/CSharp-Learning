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
