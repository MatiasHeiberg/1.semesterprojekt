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
            bool running = true;

            while (running)
            {
                Console.Clear();
                //test
                Console.WriteLine($"Logged in som {State.GetCurrentUser().Name} Admin: {State.GetCurrentUser().IsAdmin}");
                new ListSessionHandler();

                Console.WriteLine();
                Console.WriteLine("[tal] = tilmeld dig en session");
                Console.WriteLine("[n] = opret en ny session");
                Console.WriteLine("[q] = afslut programmet");
                MenuSelecter(running);

                if (running)
                {
                    View.TakeUserInput("\nTryk Enter for at fortsætte...");

                }
            }
        }
        private void MenuSelecter(bool running)
        {
            string input = View.TakeUserInput("\nindtast dit valg:");

            switch (input)
            {
                case "q": 
                    running = false;
                    break;
                case "n":
                    new CreateSessionHandler();
                    MenuSelecter(running);
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
                    MenuSelecter(true);
                }
            }
            else
            {
                Console.WriteLine("Ugyldigt input.");
                MenuSelecter(true);
            }
        }
    }
}

