using System;

namespace TigerSoccerClub
{
    public static class InputValidation
    {
        public static string GetValidRegistration()
        {
            while (true)
            {
                Console.Write("Registration type (Kids/Adult): ");
                string input = Console.ReadLine();

                if (input == "Kids" || input == "Adult")
                    return input;

                Console.WriteLine("Invalid input. Please enter Kids or Adult.\n");
            }
        }

        public static string GetValidJersey()
        {
            while (true)
            {
                Console.Write("Jersey? (Yes/No): ");
                string input = Console.ReadLine();

                if (input == "Yes" || input == "No")
                    return input;

                Console.WriteLine("Invalid input. Please enter Yes or No.\n");
            }
        }
    }
}
