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



