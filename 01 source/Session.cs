using System;

public class Session
{
	private List<User> listOfParticipant = new List<User>();

    private int playerMinimum;
    private int playerMaximum;
    private string description;
    private DateTime date = new DateTime(2025, 12, 24);

    public List<User> ListOfParticipant
    {
        get
        {
            return listOfParticipant;
        }
        set
        {
            listOfParticipant = value;
        }
    }

    public int PlayerMinimum
	{
		get;
		set;
	}
	public int PlayerMaximum
    {
        get;
        set;
    }
    public string Description
    {
        get;
        set;
    }
    public DateTime Date
    {
        get;
        set;
    }

}
