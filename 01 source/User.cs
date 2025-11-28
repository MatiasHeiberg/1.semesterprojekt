/// <summary>
/// User-klassen repræsenterer en bruger i systemet og indeholder oplysninger om brugerens administrative rettigheder.
/// </summary>
/// <authors names = "Alle"/>
/// 
using System;

public class User
{
    private bool isAdmin = false; 
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
