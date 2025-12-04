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
        internal static string? TakeUserInput(string instruction)
        {
            string userInput;
            
            Console.WriteLine(instruction);
            userInput = Console.ReadLine();

            return userInput;
        }
    }

}
