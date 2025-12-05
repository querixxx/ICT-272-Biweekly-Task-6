using System;

namespace TigerSoccerClub
{
    class Program
    {

        public Program(int players, string name, string registration, string jersey, double price)
        {
            Players = players;
            Name = name;
            Registration = registration;
            Jersey = jersey;
            Price = price;
        }

        public int Players { get; set; }
        public string Name { get; set; }
        public string Registration { get; set; }
        public string Jersey { get; set; }
        public double Price { get; set; }

        static void Main(string[] args)
        {
            int i = 0;
            double total = 0;
            int jerseyamt = 100;
            String Name = "";
            String Registration = "";
            String Jersey = "";
            int initalamt_kids = 150;
            int initalamt_adult = 230;
            
            //these lines of codes are for aligning items to center and contains heading portion
            string s = "*****Welcome to TigerSoccerClub*****";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);

            Console.Write("Enter the number of players per registrations: ");
             int Players = Convert.ToInt32(Console.ReadLine());

            if(Players>4 || Players<1)
            {
                Console.WriteLine("Invalid number, Please enter the registration number betweeen 1 to 4");
            }
            else
            {
                if(Players == 1)
                {
                    Console.Write("Enter name: ");
                    Name = Console.ReadLine();

                     Console.Write("Registration type: ");
                     Registration = Console.ReadLine();

                    Console.Write("Enter Yes/No to indicate wheather you want jersey: ");
                     Jersey = Console.ReadLine();

                    if (Registration == "Kids" && Jersey == "Yes")
                    {
                          total = initalamt_kids + jerseyamt;
                        Console.Write("Total price from " + Name + " is: " + total);
                        Console.WriteLine("\n");

                    }
                    else if (Registration == "Kids" && Jersey == "No")
                    {
                         total = initalamt_kids;
                        Console.Write("Total price from " + Name + " is: " + total);
                        Console.WriteLine("\n");
                    }
                    else if (Registration == "Adult" && Jersey == "Yes")
                    {
                         total = initalamt_adult + jerseyamt;
                        Console.Write("Total price from " + Name + " is: " + total);
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        total = initalamt_adult;
                        Console.Write("Total price from " + Name + " is: " + total);
                        Console.WriteLine("\n");
                    }
                    string s1 = "Summary of Registrations";
                    Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                    Console.WriteLine(s1);
                    Console.WriteLine("******************************************************************************************************");
                    Console.WriteLine("Name    " + " Type   " + " Jersey   " + " Total ");
                    Console.WriteLine("\n");

                    for (int j = 0; j < Players; j++)
                    {
                        Console.WriteLine(Name + " " + Registration + " " + Jersey + " " + total);
                    }


                }
                else
                {
                    for (i = 0; i < Players; i++)
                    {
                        Console.Write("Enter name: ");
                         Name = Console.ReadLine();

                        Console.Write("Registration type: ");
                         Registration = Console.ReadLine();

                        Console.Write("Enter Yes/No to indicate wheather you want jersey: ");
                         Jersey = Console.ReadLine();


                        if (Registration == "Kids" && Jersey == "Yes")
                        {
                            double test = initalamt_kids + jerseyamt;
                            double test1 = (test * 5) / 100;
                            total = test - test1;
                            Console.Write("Total price from " + Name + " is: " + total);
                            Console.WriteLine("\n");

                        }
                        else if (Registration == "Kids" && Jersey == "No")
                        {
                            double b1 = initalamt_kids;
                            double b2 = (b1 * 5) / 100;
                            total = b1 - b2;
                            Console.Write("Total price from " + Name + " is: " + total);
                            Console.WriteLine("\n");
                        }
                        else if (Registration == "Adult" && Jersey == "Yes")
                        {
                            double c1 = initalamt_adult + jerseyamt;
                            double c2 = (c1 * 5) / 100;
                            total = c1 - c2;
                            Console.Write("Total price from " + Name + " is: " + total);
                            Console.WriteLine("\n");
                        }
                        else 
                        {
                            double d1 = initalamt_adult;
                            double d2 = (d1 * 5) / 100;
                            total = d1 - d2;
                            Console.Write("Total price from " + Name + " is: " + total);
                            Console.WriteLine("\n");
                        }
                            string s2 = "Summary of Registrations";
                            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
                            Console.WriteLine(s2);
                            Console.WriteLine("******************************************************************************************************");
                            Console.WriteLine("Name    " + " Type   " + " Jersey   " + " Total ");
                            Console.WriteLine(Name + " " + Registration + " "+ " " + " " + Jersey + " " + " " + " " + total);
                            Console.WriteLine("\n");

                    }


                }
                 
            }
        }
        
    }
}
