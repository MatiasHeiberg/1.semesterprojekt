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
        private User currentUser;

        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
        }
    }

}
