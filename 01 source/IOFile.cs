using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace semesterprøve
{
    public class IOFile
    {


        public static User ReadCurrentUser()
        {
            User currentUser = new User();
            string line = File.ReadAllText("CurrentUser.csv");
            currentUser = ExtractUser(line);
            return currentUser;
        }

        private static User ExtractUser(string line)
        {
            string[] parts = line.Split(',');
            string name = parts[0];
            bool isAdmin = bool.Parse(parts[1]);
            return new User(name, isAdmin);
        }

        public static void WriteCurrentUser(User currentUser)
        {
            {
                var line = $"{currentUser.Name},{currentUser.IsAdmin}";

                // Overskriver hele filen
                File.WriteAllText("CurrentUser.csv", line);
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
