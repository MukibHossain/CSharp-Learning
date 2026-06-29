//Problem 2:
//Scenario: Neuralink implants operate in multiple modes (Idle, DataProcessing,
//NeuroStimulation, SleepMode). The implant's behavior depends on the input from neural
//signals.
//Problem Statement:
//Create an enum ImplantMode to represent different operating states of a Neuralink
//implant.
//Implement a class NeuralinkDevice with a method SwitchMode(ImplantMode mode)
//that allows changing modes based on external triggers.
//Simulate a Neuralink device that cycles through different states based on user input.

using System;
enum ImplantMode
{
    Idle,
    DataProcessing,
    NeuroStimulation,
    SleepMode
}

class NeuralinkDevice
{
    public void SwitchMode(ImplantMode mode)
    {
        Console.WriteLine("Current Mode: " + mode);
    }
}

class Program
{
    static void Main()
    {
        NeuralinkDevice device = new NeuralinkDevice();

        device.SwitchMode(ImplantMode.Idle);

        device.SwitchMode(ImplantMode.DataProcessing);

        device.SwitchMode(ImplantMode.NeuroStimulation);

        device.SwitchMode(ImplantMode.SleepMode);
    }
}

