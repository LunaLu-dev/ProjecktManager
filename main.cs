using System.Threading;
using System;
using System.IO;

class ProjecktManager{    
    static void Main(){

        string input = "";
        string inputT = "";

        Console.WriteLine("--- Welcome To Projeckt Manager ---");
        Console.WriteLine("--- Made By Luna Nordbergh ---");
        Console.WriteLine("");
        Console.WriteLine("What Projeckt do you want to create?");
        Console.WriteLine("1. Dev, 2. YouTube (WIP), 3. TikTok (WIP)");
        input = Console.ReadLine();
        //converts input to from a number to text
        if      (input == "1"){inputT = "Dev";}
        else if (input == "2"){inputT = "YouTube";}
        else if (input == "3"){inputT = "TikTok";}
        Console.WriteLine("");
        Console.Clear();
        Console.WriteLine("You have selected " + input + " (" + inputT + ")");

        //dev
        if (input == "1") {
            Console.WriteLine("What kind of Dev projeckt do you want to create?");
            Console.WriteLine("1. C#, 2. C++, 3. Python, 4. Java, 5. Web (html, css, js)");
            input = Console.ReadLine();
            //converts input to from a number to text
            if      (input == "1"){inputT = "C#";}
            else if (input == "2"){inputT = "C++";}
            else if (input == "3"){inputT = "Python";}
            else if (input == "4"){inputT = "Web";}
            Console.Clear();
            Console.WriteLine("You have selected " + input + " (" + inputT + ")");

            //C#
            if (input == "1"){
                Console.WriteLine("What's the path of the projeckts folder?");
                string path = Console.ReadLine();
                Console.WriteLine("What's the name of the projeckt?");
                string name = Console.ReadLine();
                
                if (File.Exists(path + @"\" + name + @"/main.cs") == false) {
                    if (Directory.Exists(path)){
                        //create files
                        Directory.CreateDirectory(path + @"\" + name);
                        Console.WriteLine("Created New Directory " + path + @"\" + name + @"\");
                        File.Copy(Directory.GetCurrentDirectory() + @"\templates\windows\cs\main.cs", path + @"\" + name + @"\");
                        Console.WriteLine("Created New File " + path + @"\" + name + @"\main.cs");
                        File.Copy(Directory.GetCurrentDirectory() + @"\templates\windows\cs\compiler.bat", path + @"\" + name + @"\");
                        Console.WriteLine("Created New File " + path + @"\" + name + @"\compiler.bat");
                        if (File.Exists(@"C:\Windows\Microsoft.NET\Framework\v3.5\csc.exe") == false) {
                            Console.WriteLine("");
                            Console.WriteLine("!!! WARNING, for the compiler to work you need to have microsoft .NET 3.5 installed !!!");
                            Console.WriteLine("This can be installed at");
                            Console.WriteLine("https://www.microsoft.com/en-us/download/details.aspx?id=21");
                        }
                        else if (File.Exists(@"C:\Windows\Microsoft.NET\Framework\v3.5\csc.exe") == true){
                            Console.WriteLine("Done you're all good!");
                        }
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                    }
                    else{
                        Console.WriteLine("Projeckt Folder Does not exists");
                        Thread.Sleep(500);
                        Console.Clear();
                        Main();
                    }
                }
                else{
                    Console.WriteLine("File Already Exists");
                    Thread.Sleep(500);
                    Console.Clear();
                    Main();
                }
            }//C++
            else if (input == "2") {
                Console.WriteLine("What's the path of the projeckts folder?");
                string path = Console.ReadLine();
                Console.WriteLine("What's the name of the projeckt?");
                string name = Console.ReadLine();
                
                if (File.Exists(path + @"\" + name + @"/main.cpp") == false) {
                    if (Directory.Exists(path)){
                        //creating files
                        Directory.CreateDirectory(path + @"\" + name);
                        Console.WriteLine("Created New Directory " + path + @"\" + name + @"\");
                        File.Copy(Directory.GetCurrentDirectory() + @"\templates\windows\cpp\main.cpp", path + @"\" + name + @"\");
                        Console.WriteLine("Created New File " + path + @"\" + name + @"\main.cpp");
                        Console.WriteLine("Done you're all good!");
                        Thread.Sleep(800);
                        Environment.Exit(0);
                    }
                    else{
                        Console.WriteLine("Projeckt Folder Does not exists");
                        Thread.Sleep(500);
                        Console.Clear();
                        Main();
                    }
                }
                else{
                    Console.WriteLine("File Already Exists");
                    Thread.Sleep(500);
                    Console.Clear();
                    Main();
                }
            }
            else if (input == "3") {
                Console.WriteLine("What's the path of the projeckts folder?");
                string path = Console.ReadLine();
                Console.WriteLine("What's the name of the projeckt?");
                string name = Console.ReadLine();
                
                if (File.Exists(path + @"\" + name + @"/main.py") == false) {
                    if (Directory.Exists(path)){
                        //creating files
                        Directory.CreateDirectory(path + @"\" + name);
                        Console.WriteLine("Created New Directory " + path + @"\" + name + @"\");
                        File.Copy(Directory.GetCurrentDirectory() + @"\templates\windows\py\main.py", path + @"\" + name + @"\");
                        Console.WriteLine("Created New File " + path + @"\" + name + @"\main.py");
                        Console.WriteLine("Done you're all good!");
                        Thread.Sleep(800);
                        Environment.Exit(0);
                    }
                    else{
                        Console.WriteLine("Projeckt Folder Does not exists");
                        Thread.Sleep(500);
                        Console.Clear();
                        Main();
                    }
                }
                else{
                    Console.WriteLine("File Already Exists");
                    Thread.Sleep(500);
                    Console.Clear();
                    Main();
                }
            }
            else if(input == "4") {
                Console.WriteLine("What's the path of the projeckts folder?");
                string path = Console.ReadLine();
                Console.WriteLine("What's the name of the projeckt?");
                string name = Console.ReadLine();
                
                if (File.Exists(path + @"\" + name + @"/index.html") == false) {
                    if (Directory.Exists(path)){
                        //creating files
                        Directory.CreateDirectory(path + @"\" + name);
                        Console.WriteLine("Created New Directory " + path + @"\" + name + @"\");
                        File.Copy(Directory.GetCurrentDirectory() + @"\templates\windows\web\index.html", path + @"\" + name + @"\");
                        File.Copy(Directory.GetCurrentDirectory() + @"\templates\windows\web\style.css", path + @"\" + name + @"\");
                        File.Copy(Directory.GetCurrentDirectory() + @"\templates\windows\web\script.js", path + @"\" + name + @"\");
                        Console.WriteLine("Created New File " + path + @"\" + name + @"\index.html");
                        Console.WriteLine("Created New File " + path + @"\" + name + @"\style.css");
                        Console.WriteLine("Created New File " + path + @"\" + name + @"\scipt.js");
                        Console.WriteLine("Done you're all good!");
                        Thread.Sleep(800);
                        Environment.Exit(0);
                    }
                    else{
                        Console.WriteLine("Projeckt Folder Does not exists");
                        Thread.Sleep(500);
                        Console.Clear();
                        Main();
                    }
                }
                else{
                    Console.WriteLine("File Already Exists");
                    Thread.Sleep(500);
                    Console.Clear();
                    Main();
                }
            }

        }//YouTube
        else if (input == "2") {
            
        }//TikTok
        else if (input == "3") {
            
        }



        //This stops the program to close immediately after start.
        Console.WriteLine("End of program Press Enter to Exit");
        Console.ReadLine();
    }
} 