using semesterprøve;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace semesterprøve
{
    internal class Application
    {
        // Opretter statiske singleton objekter der skal persistere igennem hele programmets levetid.
        public static List<User> AllUsers;
        private bool running = true;

        public void Run()
        {
            //indlæs brugere fra CSV
            AllUsers = IOFile.LoadUsers("Users.csv");

            //Sætter currentUser i state
            State.SetCurrentUser(AllUsers[8]);

            //Læser nuværende bruger fra fil
            State.GetCurrentUser();

            //Kører demo data oprettelse
            Activity.CreateDemoSessions();

            ShowMainMenu();
        }

        private void ShowMainMenu()
        {

            while (running)
            {
                Console.Clear();
                Console.WriteLine($"Logged in som {State.GetCurrentUser().Name} Admin: {State.GetCurrentUser().IsAdmin}");
                new ListSessionHandler();

                Console.WriteLine();
                Console.WriteLine("[tal] = tilmeld dig en session");
                Console.WriteLine("[n] = opret en ny session");
                Console.WriteLine("[q] = afslut programmet");
                MenuSelecter();

                if (running)
                {
                    View.TakeUserInput("\nTryk Enter for at fortsætte...");
                    continue;
                }

                break;
            }
        }
        private void MenuSelecter( )
        {
            string input = View.TakeUserInput("\nindtast dit valg:");

            switch (input)
            {
                case "q":
                    running = false;
                    Console.WriteLine("Shutting down...");
                    break;
                case "n":
                    new CreateSessionHandler();
                    ShowMainMenu();
                    break;
                default:
                    MenuItem(input);
                    break;
            }
        }
        private void MenuItem(string input)
        {
            if (int.TryParse(input, out int index))
            {
                List<Session> sessions = Activity.ListOfSession;

                if (index >= 1 && index <= sessions.Count)
                {
                    Session chosen = sessions[index - 1];

                    new JoinSessionHandler(chosen);
                }
                else
                {
                    Console.WriteLine("Ugyldigt sessionsnummer.");
                    MenuSelecter();
                }
            }
            else
            {
                Console.WriteLine("Ugyldigt input.");
                MenuSelecter();
            }
        }
    }
}

