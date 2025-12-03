/// <summary>
/// User-klassen repræsenterer en bruger i systemet og indeholder oplysninger om brugerens administrative rettigheder.
/// </summary>
/// <authors names = "Alle"/>
/// 
using System;
namespace semesterprøve
{
    public class User
    {
        private bool isAdmin = false;
        private string name;

        public User(string name, bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            this.name = name;
        }

        public bool IsAdmin
        {
            get
            {
                return isAdmin;
            }
            set
            {
                isAdmin = value;
            }
        }



    }

}
