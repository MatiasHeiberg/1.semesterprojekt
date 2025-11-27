using System;

public class State
{
	private User currentUser;

    public User CurrentUser
    {
        get
        {
            return currentUser;
        }
        set
        {
            currentUser = value;
        }
    }
}
