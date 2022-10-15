using System;

class HelloWorld{    
    static void Main(){
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            Console.WriteLine(OSPlatform.OSX);
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            Console.WriteLine(OSPlatform.Linux);
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            Console.WriteLine(OSPlatform.Windows);
        }

        //This stops the program to close immediately after start.
        Console.WriteLine("End of program Press Enter to Exit");
        Console.ReadLine();
    }
}