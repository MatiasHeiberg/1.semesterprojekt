using System;

public class View
{
    private List<Session> listOfSession = new List<Session>;
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
