using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace semesterprøve
{
    public class IOFile
    {

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
                
                //Vi splitter hver linje med line.Split ved hvert komma, så "Andreas,true"
                //bliver til "parts = ["Andreas", "true"] i endnu en array af strenge.
                string[] parts = line.Split(',');

                //navnm, f.eks. "Andreas".
                string name = parts[0];

                //adminstatus, f.eks. "true".
                bool isAdmin = bool.Parse(parts[1]);

                //opretter User objekt og tilføjer det til listen.
                allUsers.Add(new User(name, isAdmin));

            }
            //Returnerer listen allUsers.
            return allUsers;
        }
    }
}
