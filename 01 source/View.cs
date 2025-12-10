/// <summary>
/// View fungerer som en klasse, der er ansvarlig for at printe indhold ud til konsollen.

/// </summary>
/// <authors names = "Alle"/>
/// 
using System;
namespace semesterprøve

{
    public static class View
    {
        public static string TakeUserInput(string instruction)
        {
            string userInput;
            
            Console.WriteLine(instruction);
            userInput = Console.ReadLine();

            return userInput;
        }

        public static void PrintSessionsWithIndex(List<Session> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Session session = list[i];
                Console.WriteLine($"{i+1}.{SessionFormatter(session)}");
            }
        }

        private static string SessionFormatter(Session session)
        {
            string formatThis;
            formatThis = $"""
            {session.Date} - {session.Description}
            ({session.ListOfParticipant.Count}/{session.PlayerMaximum})
            """;

            return formatThis;
        } 
    }

}
