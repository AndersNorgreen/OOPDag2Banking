using OOPDag2Banking.Banking;

namespace OOPDag2Banking
{
    internal static class Helper
    {
        public static class GeneratePassword
        {
            public static string CreatePassword()
            {
                string password;
                do
                {
                    Console.WriteLine("** Dit kodeord skal være mindst otte tegn langt og indeholde et stort bogstav, et tal og et specialtegn **");
                    Console.Write("Indtast et kodeord: ");

                    password = Console.ReadLine();
                    if (string.IsNullOrEmpty(password))
                    {
                        Console.Clear();
                        Console.WriteLine("Dit kodeord kan ikke være tomt" + Environment.NewLine);
                        continue;
                    }
                    else
                    {

                        if (!CorrectLength(password))
                        {
                            CheckFailed("Dit kodeord skal være mindst otte tegn langt");
                            continue;
                        }
                        else if (!ContainsUppercase(password))
                        {
                            CheckFailed("Dit kodeord skal indeholde mindst et stort bogstav");
                            continue;
                        }
                        else if (!ContainsSpecialChar(password))
                        {
                            CheckFailed("Dit kodeord skal indeholde mindst et specialtegn");
                            continue;
                        }
                        else if (!ContainsNumber(password))
                        {
                            CheckFailed("Dit kodeord skal indeholde mindst et tal");
                            continue;
                        }
                        else
                            return password;
                    }
                } while (true);
            }
            private static bool CorrectLength(string password)
            {
                return password.Length >= 8 ? true : false;
            }
            private static bool ContainsUppercase(string password)
            {
                return password.Any(char.IsUpper) ? true : false;
            }
            private static bool ContainsSpecialChar(string password)
            {
                return (password.Any(ch => !Char.IsLetterOrDigit(ch))) ? true : false;
            }
            private static bool ContainsNumber(string password)
            {
                return password.Any(char.IsDigit) ? true : false;
            }
            private static void CheckFailed(string message)
            {
                Console.Clear();
                Console.WriteLine(message);
            }
        }
        public static class Menus
        {
            public static void MainMenu()
            {
                Console.WriteLine("**** Velkommen til TEC Banking ****" + Environment.NewLine);
                Console.WriteLine("Du kan nu logge ind som: ");
                Console.WriteLine("1. Medarbejder");
                Console.WriteLine("2. Kunde");
                Console.WriteLine("3. Afslut");
                Console.Write(Environment.NewLine + "Indtast valg: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        EmployeeMenu();
                        break;
                    case "2":
                        Console.Clear();
                        CustomerMenu();
                        break;
                    case "3":
                        Quit();
                        break;
                }
            }

            public static void CustomerMenu()
            {
                Console.WriteLine("**** Velkommen til TEC Banking kundesystem ****" + Environment.NewLine);
                Console.WriteLine("Hvilken handling ønsker du at udføre?");
                Console.WriteLine("1. Se kontooversigt");
                Console.WriteLine("2. Overfør penge");
                Console.WriteLine("3. Tilbage til hovedmenu");
                Console.WriteLine("4. Afslut");
                Console.Write(Environment.NewLine + "Indtast valg: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Account.ViewAccounts();
                        break;
                    case "2":
                        Account.TransferBalance();
                        break;
                    case "3":
                        Console.Clear();
                        MainMenu();
                        break;
                    case "4":
                        Quit();
                        break;
                }
            }



            public static void EmployeeMenu()
            {
                Console.WriteLine("**** Velkommen til TEC Banking medarbejdersystem ****" + Environment.NewLine);
                Console.WriteLine("Hvilken handling ønsker du at udføre?");
                Console.WriteLine("1. Se kontooversigt");
                Console.WriteLine("2. Overføre penge");
                Console.WriteLine("3. Tilbage til hovedmenu");
                Console.WriteLine("4. Afslut");
                Console.Write(Environment.NewLine + "Indtast valg: ");

                switch (Console.ReadLine())
                {

                }
            }

            public static void Quit()
            {
                Console.Clear();
                Console.WriteLine("Tak for besøget og på gensyn!");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
        }
    }
}
