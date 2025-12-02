using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace semesterprøve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Læs Users.json fra fil.
            string jsonpath = "Users.json";
            string json = File.ReadAllText(jsonpath);

            //Deserialiser til liste af User objekter med Name (User.Name) IsAdmin (User.IsAdmin)
            List<User> AllUsers = JsonSerializer.Deserialize<List<User>>(json);

            //Opretter State
            State state = new State();

            //Vælger hvilken bruger der er "logget ind"
            //ændre index fra 0..9
            state.CurrentUser = AllUsers[0];

        }
    }
}
