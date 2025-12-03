using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace semesterprøve
{
    public class IOFile
    {
        //Læs Users.csv fra fil.
        string csvPath = "Users.csv";
        string[] lines = File.ReadAllLines(csvPath);

        //Deserialiser til liste af User objekter med Name (User.Name) IsAdmin (User.IsAdmin)
        List<User> AllUsers = JsonSerializer.Deserialize<List<User>>(file);

        //Opretter State
        State state = new State();

        //Vælger hvilken bruger der er "logget ind"
        //ændre index fra 0..9
        state.CurrentUser = AllUsers[0];
    }
}
