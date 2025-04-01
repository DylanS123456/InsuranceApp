using System.Runtime.InteropServices;

namespace InsuranceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ascii Art
            string asciiArt = @"

    ██ ███    ██ ███████ ██    ██ ██████   █████  ███    ██  ██████ ███████      █████  ██████  ██████  
    ██ ████   ██ ██      ██    ██ ██   ██ ██   ██ ████   ██ ██      ██          ██   ██ ██   ██ ██   ██ 
    ██ ██ ██  ██ ███████ ██    ██ ██████  ███████ ██ ██  ██ ██      █████       ███████ ██████  ██████  
    ██ ██  ██ ██      ██ ██    ██ ██   ██ ██   ██ ██  ██ ██ ██      ██          ██   ██ ██      ██      
    ██ ██   ████ ███████  ██████  ██   ██ ██   ██ ██   ████  ██████ ███████     ██   ██ ██      ██      
                                                                                                        
                                                                                                        
     ";
            //Add different colors to the text
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(asciiArt);
            Console.ResetColor();
            // Underline the text
            Console.WriteLine("Welcome to the Insurance App!");


        }
    }
}


