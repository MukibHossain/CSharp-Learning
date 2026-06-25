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

