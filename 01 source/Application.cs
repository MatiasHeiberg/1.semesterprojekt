using semesterprøve;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterprøve
{
    internal class Application
    {
        // Opretter statiske singleton objekter der skal persistere igennem hele programmets levetid.
        public static State state = new State();
        public static Activity activity = new Activity();
        public static List<User> AllUsers;

        public void Run()
        {
            //indlæs brugere fra CSV
            AllUsers = IOFile.LoadUsers("Users.csv");

            //Sætter currentUser i state
            state.CurrentUser = AllUsers[1];

            

            activity.CreateDemoSessions();

            ShowMainMenu();
        }

        private void ShowMainMenu()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                //test
                Console.WriteLine($"Logged in som {state.CurrentUser.Name} Admin: {state.CurrentUser.IsAdmin}");
                new ListSessionHandler();

                Console.WriteLine();
                Console.WriteLine("[tal] = tilmeld dig en session");
                Console.WriteLine("[n] = opret en ny session");
                Console.WriteLine("[q] = afslut programmet");

                string input = View.TakeUserInput("\n indtast dit valg:");

                switch (input)
                {
                    case "q":
                        running = false; 
                        break;
                    case "n":
                        new CreateSessionHandler();
                        break;
                    default:
                        if (int.TryParse(input, out int index))
                        {
                            List<Session> sessions = activity.ListOfSession;

                            if (index >= 1 && index <= sessions.Count)
                            {
                                Session chosen = sessions[index - 1];

                                new JoinSessionHandler(chosen);
                            }
                            else
                            {
                                Console.WriteLine("Ugyldigt sessionsnummer.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ugyldigt input.");
                        }
                        break;
                }

                if (running)
                {
                    View.TakeUserInput("\nTryk Enter for at fortsætte...");
                }
            }
            }
        }
    }

