using System.Runtime.InteropServices;
using System.Text;

namespace InsuranceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ascii Art
            string asciiArt1 = @"
            ██ ███    ██ ███████ ██    ██ ██████   █████  ███    ██  ██████ ███████      █████  ██████  ██████  
            ██ ████   ██ ██      ██    ██ ██   ██ ██   ██ ████   ██ ██      ██          ██   ██ ██   ██ ██   ██ 
            ██ ██ ██  ██ ███████ ██    ██ ██████  ███████ ██ ██  ██ ██      █████       ███████ ██████  ██████  
            ██ ██  ██ ██      ██ ██    ██ ██   ██ ██   ██ ██ ██  ██ ██      ██          ██   ██ ██      ██      
            ██ ██   ████ ███████  ██████  ██   ██ ██   ██ ██   ████  ██████ ███████     ██   ██ ██      ██      
                                                                                                                
                                                                                                                
             ";
            string asciiArt2 =
                @"

            ███████ ███████ ██████  ██  █████  ██          ███    ██ ██    ██ ███    ███ ██████  ███████ ██████  
            ██      ██      ██   ██ ██ ██   ██ ██          ████   ██ ██    ██ ████  ████ ██   ██ ██      ██   ██ 
            ███████ █████   ██████  ██ ███████ ██          ██ ██  ██ ██    ██ ██ ████ ██ ██████  █████   ██████  
                 ██ ██      ██   ██ ██ ██   ██ ██          ██  ██ ██ ██    ██ ██  ██  ██ ██   ██ ██      ██   ██ 
            ███████ ███████ ██   ██ ██ ██   ██ ███████     ██   ████  ██████  ██      ██ ██████  ███████ ██   ██                                                                                                                                                                                                                                                                                                                          
    ";
            string asciiArt3 = @" 

            ██████  ███████ ██████  ██████  ███████  ██████ ██  █████  ████████ ██  ██████  ███    ██ 
            ██   ██ ██      ██   ██ ██   ██ ██      ██      ██ ██   ██    ██    ██ ██    ██ ████   ██ 
            ██   ██ █████   ██████  ██████  █████   ██      ██ ███████    ██    ██ ██    ██ ██ ██  ██ 
            ██   ██ ██      ██      ██   ██ ██      ██      ██ ██   ██    ██    ██ ██    ██ ██  ██ ██ 
            ██████  ███████ ██      ██   ██ ███████  ██████ ██ ██   ██    ██    ██  ██████  ██   ████ 
                                                                                          
                                                                                          

";
            //Ascii Art Display. Add color to the text
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(asciiArt1);
            Console.ResetColor();
            //Welcome message
            Console.WriteLine("Welcome to the Insurance App!");
            //Variables
            string serialNumber = GenerateSerialNumber();
            int deviceType;
            //Main Process/When run...
            //Input from the user
            //Ask the user for their device name
            Console.WriteLine("Please enter the name of your device: ");
            string? deviceName = Console.ReadLine();
            //Ask the user for amount of that device
            Console.WriteLine("Please enter the amount of your device: ");
            int deviceAmount = Convert.ToInt32(Console.ReadLine());
            //Ask the user for the price of that device
            Console.WriteLine("Please enter the price of your device: ");
            double devicePrice = Convert.ToDouble(Console.ReadLine());
            // Ask the user for the type of Device| 1. Laptop 2. Desktop 3. Other
            Console.WriteLine("Please enter the type of your device: ");
            Console.WriteLine("1. Laptop");
            Console.WriteLine("2. Desktop");
            Console.WriteLine("3. Other");
            deviceType = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(500);
            // Display Serial Number
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(asciiArt2);
            Console.ResetColor();
            // Slow down the process
            Console.WriteLine("Generating Serial Number...");
            System.Threading.Thread.Sleep(2000);
            // Give device a serial number
            Console.WriteLine($"Your device has been registered with the serial number:{deviceName}|{serialNumber}");
            // Insurance Calculation
            // Device Price = Insurance Price
            // If user has more than 5 devices, they get a 10% discount for the other devices, but not the first five
            double insurancePrice = CalculateInsurance(deviceAmount, devicePrice);
            // Display the insurance price
            Console.WriteLine($"The insurance price for your device is: ${insurancePrice}");
            // Ask User if they would like to simulate depreciation
            // Simulate depreciation
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(asciiArt3);
            Console.ResetColor();
            Console.WriteLine("Simulating depreciation...");
            System.Threading.Thread.Sleep(2000);
            // Depreciation Calculation
            // Depreciation rate is 10% per Month for the first 6 months
            // Simulate 6 months of depreciation
            for (int i = 1; i <= 6; i++)
            {
                devicePrice = devicePrice * 0.9;
                //Round the device price to 2 decimal places
                devicePrice = Math.Round(devicePrice, 2);
                Console.WriteLine($"After {i} month(s), the value of your device is: ${devicePrice}");
                //Slow down the process
                System.Threading.Thread.Sleep(1000);
                //Display the final value of the device and the device category
                if (i == 6)
                {
                    Console.WriteLine($"The final value of your device (After Depreciation) is: ${devicePrice}");
                    if (deviceType == 1)
                    {
                        Console.WriteLine("Device Category: Laptop");
                    }
                    else if (deviceType == 2)
                    {
                        Console.WriteLine("Device Category: Desktop");
                    }
                    else
                    {
                        Console.WriteLine("Device Category: Other");
                    }
                    //Ask user if they would like to input another device
                    Console.WriteLine("Would you like to input another device? (Y/N)");
                    string? input = Console.ReadLine();
                    if (input == "Y" || input == "y")
                    {
                        Main(args);
                    }
                    else
                    {
                        Console.WriteLine("Thank you for using the Insurance App!");
                    }
                }
            }
        }

        //Method to generate a random serial number
        static string GenerateSerialNumber()
        {
            StringBuilder serial = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                serial.Append((char)random.Next('A', 'Z' + 1));
            }
            return serial.ToString();
        }

        private static double CalculateInsurance(int deviceAmount, double devicePrice)
        {
            double totalInsurancePrice = 0;
            for (int i = 0; i < deviceAmount; i++)
            {
                if (i < 5)
                {
                    totalInsurancePrice += devicePrice;
                }
                else
                {
                    totalInsurancePrice += devicePrice * 0.9; // 10% discount for devices after the first 5
                }
                //Round the total insurance price to 2 decimal places
                totalInsurancePrice = Math.Round(totalInsurancePrice, 2);
            }
            return totalInsurancePrice;
        }

        private static void SimulateDepreciation(ref double devicePrice)
        {
            // Simulate depreciation logic
            
        } 



    }
}


