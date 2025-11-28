/// <summary>
/// View fungerer som en serviceklasse, der er ansvarlig for at printe indhold ud til konsollen.
/// </summary>
/// <authors names = "Alle"/>
/// 
using System;

public class View
{
    private List<Session> listOfSession = new List<Session>();
    public List<Session> ListOfSession
    {
        get
        {
            return listOfSession;
        }
        set
        {
            listOfSession = value;
        }
    }
}
