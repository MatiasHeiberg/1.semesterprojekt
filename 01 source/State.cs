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
        public static User GetCurrentUser()
        { 
            return IOFile.ReadCurrentUser();
        }
        public static void SetCurrentUser(User user)
        {
            IOFile.WriteCurrentUser(user);
        }
    }

}
