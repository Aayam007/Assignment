using System;

// Interface definition
public interface IPlayable
{
    void Play();
}

public interface IRecordable
{
    void Record();
}

// Class implementing multiple interfaces

public interface IMultimediaDevice : IPlayable, IRecordable
{
    void Sing();
}
public class MultimediaDevice : IMultimediaDevice
{
    // Implementation of the Play method from IPlayable
    public void Play()
    {
        Console.WriteLine("Playing multimedia...");
    }

    // Implementation of the Record method from IRecordable
    public void Record()
    {
        Console.WriteLine("Recording multimedia...");
    }

    public void Sing()
    {
        Console.WriteLine("Sing Song");
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the class implementing multiple interfaces
        MultimediaDevice device = new MultimediaDevice();

        IMultimediaDevice multimediaDevice = new MultimediaDevice();
        multimediaDevice.Sing();
        multimediaDevice.Play();
        multimediaDevice.Record();
        // Using methods from both interfaces
        device.Play();
        device.Record();
    }
}
