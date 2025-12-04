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
        public void Run()
        {
            //indlæs brugere fra CSV
            List<User> allUsers = IOFile.LoadUsers("Users.csv");

            //Opretter State
            State state = new State();

            //Sætter currentUser i state
            state.CurrentUser = allUsers[0];

            //test
            Console.WriteLine($"Logged in som {state.CurrentUser.Name} Admin: {state.CurrentUser.IsAdmin}");
        }
    }
}
