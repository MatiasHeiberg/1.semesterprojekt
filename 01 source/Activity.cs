/// <summary>
/// Activity-klassen repræsenterer en aktivitet, der indeholder en liste af sessions.
/// </summary>
/// <authors names = "Alle"/>
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace semesterprøve
{
    public class Activity 
    {
        private List<Session> listOfSession = new List<Session>();

        public Activity()
        {
            {
                List<User> listOfParticipant = new List<User>
            {
                new User("Alice"),
                new User("Bob")
            }



            new Session(2, 3, "Ludo"),
            new Session(2, 4, "Matador"),
            new Session(2, 2, "Skak"),
            new Session(2, 7, "Uno"),
            new Session(4, 8, "Poker")

        }
            ;
        }

        public List<Session> ListOfSession
        {
            get {

              
                bool isAdmin = permission.CanSeeAllSessions(State state);
                FilterListData(isAdmin);
                return listOfSession;
            }
        }


        private List<Session> FilterListData(bool accessLevel)
        {
            List<Session> modifiedList; 
            modifiedList = new List<Session>();

            foreach(Session session in listOfSession)
            {
                
            }






            return modifiedList;

        }

        public void AddSession(Session session)
        {
            listOfSession.Add(session);
        }
    }
}
