while(true)
{
    Console.Write("Enter password: ");
    string pass = Console.ReadLine();
    int passLength = pass.Length;

    if (passLength >= 8)
    {
        bool containsAtLeastOneUppercase = pass.Any(char.IsUpper);
        if (containsAtLeastOneUppercase == true)
        {
            bool containsAtLeastOneNum = pass.Any(char.IsNumber);
            if (containsAtLeastOneNum == true)
            {
                bool containsAtLeastOneChar = pass.Any(char.IsSymbol);
                if (containsAtLeastOneChar == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your password is safety");
                    Console.ReadKey();
                    Console.ResetColor();
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error please enter char");
                    Console.ReadKey();
                    Console.ResetColor();
                    Console.Clear();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Error please enter number!");
                Console.ReadKey();
                Console.ResetColor();
                Console.Clear();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Error please enter upercase!");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Your password isn't safety you must input minimal 8 characters");
        Console.ReadKey();
        Console.ResetColor();
        Console.Clear();
    }
}

