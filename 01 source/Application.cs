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

        public void Run()
        {
            //indlæs brugere fra CSV
            List<User> allUsers = IOFile.LoadUsers("Users.csv");

            //Sætter currentUser i state
            state.CurrentUser = allUsers[0];

            //test
            Console.WriteLine($"Logged in som {state.CurrentUser.Name} Admin: {state.CurrentUser.IsAdmin}");
        }
    }
}
