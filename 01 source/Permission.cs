/// <summary>
/// Permission-klassen repræsenterer et system til håndtering af brugerrettigheder.
/// </summary>
/// <authors names = "Alle"/>
/// 
using System;

namespace semesterprøve
{
    public class Permission
    {
        public static bool CanJoinSession(int participantCount, int playerMaximum)
        {
            //Sammenligner antal nuværende spillere med max tilladt.
            //Hvis nuværende antal >= max er sessionen fuld.
            if (participantCount >= playerMaximum)
            {
                Console.WriteLine("Du kan ikke tilmelde dig, da sessionen er fuld");
                return false; // tilmelding afvises.
            }
            return true; // Der er plads, tillad tilmelding.
        }
    }
}



