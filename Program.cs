using System;

public interface ILamp
{
    string LampType {get;}
    string LampVendor {get;}
    int Lumens {get;}
    string ElementType {get;}
    int ElementCount {get;}

    void DisplayLampInfo();
    void ChangeLumens(int lumens);
}

public interface ICamera
{
    string CameraType {get;}
    string CameraVendor {get;}
    int Sensitivity {get;}

    void DisplayCameraInfo();
    void ChangeSensitivity(int sensitivity);
}


public class PhotoStudio : ILamp, ICamera
{
    // Lamp
    public string LampType {get;}
    public string LampVendor {get;}
    public int Lumens {get; private set;}
    public string ElementType {get;}
    public int ElementCount {get;}

    // Camera
    public string CameraType {get;}
    public string CameraVendor {get;}
    public int Sensitivity {get; private set;}

    public PhotoStudio(string lampType, string lampManufacturer, int lumens, string elementType, int elementCount, string cameraType, string cameraManufacturer, int sensitivity)
    {
        LampType = lampType;
        LampVendor = lampManufacturer;
        Lumens = lumens;
        ElementType = elementType;
        ElementCount = elementCount;
        
        CameraType = cameraType;
        CameraVendor = cameraManufacturer;
        Sensitivity = sensitivity;
    }

    public void DisplayLampInfo()
    {
        Console.WriteLine($"Lamp Type: {LampType}");
        Console.WriteLine($"Lamp Vendor: {LampVendor}");
        Console.WriteLine($"Lumens: {Lumens}");
        Console.WriteLine($"Element Type: {ElementType}");
        Console.WriteLine($"Element Count: {ElementCount}");
    }

    public void ChangeLumens(int lumens)
    {
        Lumens = lumens;
    }

    public void DisplayCameraInfo()
    {
        Console.WriteLine($"Camera Type: {CameraType}");
        Console.WriteLine($"Manufacturer: {CameraVendor}");
        Console.WriteLine($"Sensitivity: {Sensitivity}");
    }

    public void ChangeSensitivity(int sensitivity)
    {
        Sensitivity = sensitivity;
    }
}


class Program
{
    static void Main()
    {
        var studio1 = new PhotoStudio("LED", "Philips", 800, "LED", 2, "DSLR", "Canon", 800);
        var studio2 = new PhotoStudio("Fluorescent", "GE", 1200, "CFL", 4, "Mirrorless", "Sony", 1200);

        Console.WriteLine("Studio 1:");
        studio1.DisplayLampInfo();
        studio1.DisplayCameraInfo();

        Console.WriteLine("\nStudio 2:");
        studio2.DisplayLampInfo();
        studio2.DisplayCameraInfo();

        studio1.ChangeSensitivity(1600);
        Console.WriteLine("\nStudio 1 after changing sensitivity:");
        studio2.DisplayLampInfo();
        studio1.DisplayCameraInfo();
    }
}
