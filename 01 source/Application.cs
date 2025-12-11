namespace semesterprøve
{
    /// <summary>
    /// Dette er den primære kontrol klasse, som orkestrerer flowet i programmet. 
    /// Se evt. sekvensdiagram 1 - System Flow.
    /// </summary>
    /// <authors names = "Alle"/>
    public class Application
    {
        public static List<User> AllUsers; // En variabel til at holde alle bruger objekter
        private bool running = true; // Kontrol variabel der stopper while løkken i ShowMainMenu()

        public Application()
        {
            Run(); // Kalder automatisk Run() når applicationen instantieres.
        }

        private void Run()
        {
            AllUsers = IOFile.LoadUsers("Users.csv"); // Indlæs brugere fra CSV fil
            State.SetCurrentUser(AllUsers[8]); // Hardcoder den nuværende bruger, index 0-3 og 9 har administrator 
            Activity.CreateDemoSessions(); // Opretter demo data

            ShowMainMenu();
        }
        /// <summary>
        /// Metoden har ansvaret for programmets hovedmenu. 
        /// Den printer menuen og beder brugeren om et input som injektes til hjælpemetoden MenuSelecter().
        /// Metoden holder programmet igang, med en while-løkke, der bliver kontrolleret af running variablen.
        /// </summary>
        /// <authors names = "Alle"/>
        private void ShowMainMenu()
        {

            while (running)
            {
                Console.Clear();
                Console.WriteLine($"Logged in som {State.GetCurrentUser().Name} Admin: {State.GetCurrentUser().IsAdmin}");
                new ListSessionHandler(); // Returnere en liste efter brugerrettigheder. Se evt. sekvensdiagram 4 - use case 4. 

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
        /// <summary>
        /// Indeholder en switch der håndtere bruger input.
        /// </summary>
        private void MenuSelecter( )
        {
            string input = View.TakeUserInput("\nindtast dit valg:");

            switch (input)
            {
                case "q":
                    running = false; // Lukker programmet ned
                    Console.WriteLine("Shutting down...");
                    break;
                case "n":
                    new CreateSessionHandler(); // Starter oprettelsen af ny session. Se evt. sekvensdiagram 2 - use case 2
                    ShowMainMenu(); // Opdatere menuen med den nye session
                    break;
                default:
                    MenuItem(input); // Tilmelder brugeren den valgte session
                    break;
            }
        }
        /// <summary>
        /// Påbegynder tilmeldingssekvens hvis input er valid.
        /// </summary>
        private void MenuItem(string input)
        {
            if (int.TryParse(input, out int index)) // Hvis input er int køres løkken
            {
                List<Session> sessions = Activity.ListOfSession;

                if (index >= 1 && index <= sessions.Count) // Tjekker om input er out of range
                {
                    Session chosen = sessions[index - 1];
                    new JoinSessionHandler(chosen); // Starter tilmeldingen af en session. Se evt. sekvensdiagram 3 - use case 3
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

