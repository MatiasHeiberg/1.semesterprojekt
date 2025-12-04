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
        //boolean der angiver om brugeren er adminstrator,
        //standard værdi er sat til false.
        private bool isAdmin = false;

        //Holder selve navnet på brugeren,
        //den er privat da vi kun vil gøre den tilgængelig via en property.
        private string name;

        //constructoren til oprettelse af bruger, skal have navn
        //men isAdmin er sat til false som standard.
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
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
