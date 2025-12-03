/// <summary>
/// Klassen State fungerer som en container for den aktuelle bruger i systemet.
/// </summary>
/// <authors names = "Alle"/>
/// 
using System;
namespace semesterprøve
{
    public class State
    {
        //Gemmer den bruger der er logget ind nu.
        private User currentUser;
        priate Activity currentList;
        //Læser den nuværende bruger
        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
            }
        }
    }

}
