namespace semesterprøve
{
    /// <summary>
    /// Håndterer I/O til en CSV fil.
    /// </summary>
    /// <authors names = "Alle"/>
    public class IOFile
    {
        public static User ReadCurrentUser()
        {
            User currentUser = new User(); 
            string line = File.ReadAllText("CurrentUser.csv"); // Gemmer bruger tekst-objektet som en lang string
            currentUser = ExtractUser(line); // Gemmer tekst-objektet som et User objekt
            return currentUser;
        }
        /// <summary>
        /// Opretter et User objekt ud fra et tekst-objekt
        /// </summary>
        private static User ExtractUser(string line)
        {
            string[] parts = line.Split(','); // Opdeler alle objektets attributter efter komma delimeter
            string name = parts[0]; // Gemmer den første substring som navn
            bool isAdmin = bool.Parse(parts[1]); // Gemmer den anden substring som isAdmin
            return new User(name, isAdmin);
        }

        public static void WriteCurrentUser(User currentUser)
        {
            {
                string line = $"{currentUser.Name},{currentUser.IsAdmin}";
                File.WriteAllText("CurrentUser.csv", line); // Overskriver hele filen med den nye bruger
            }
        }
        public static List<User> LoadUsers(string csvPath)
        {
            //Læser hele filen på én gang. Resultatet er et array af strings.
            //Hver element i arrayet er en linje i filen.
            string[] lines = File.ReadAllLines(csvPath);

            //Vi opretter en tom liste som skal fyldes med User objekter.
            List<User> allUsers = new List<User>();

            //Vi gennemløber hver linje i filen. eks. "Andreas,true".
            //Vi springer første linje over, ved at sætte i=1, da den består af overskrifter.
            for (int i = 1; i < lines.Length; i++) 
            {

                string line = lines[i];

                User user = new User();

                user = ExtractUser(line);

                //opretter User objekt og tilføjer det til listen.
                allUsers.Add(user);

            }
            //Returnerer listen allUsers.
            return allUsers;
        }
    }
}
