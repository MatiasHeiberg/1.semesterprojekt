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
            string[] lines = File.ReadAllLines(csvPath); // Opretter et array med alle linjer som indicer
            List<User> allUsers = new List<User>();

            for (int i = 1; i < lines.Length; i++) // Laver alle linjer om til brugerobjekter
            {
                string line = lines[i];
                User user = new User();

                user = ExtractUser(line); // Gemmer tekst-objektet som et User objekt
                allUsers.Add(user);

            }
            return allUsers;
        }
    }
}
