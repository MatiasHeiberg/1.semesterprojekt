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
            listOfSession.Add(new Session(/*new List<User>(),*/2, 6, "Ludo", new DateTime(2025, 11, 24)));
            listOfSession.Add(new Session(2, 6, "Matador", new DateTime(2025, 11, 24)));
            listOfSession.Add(new Session(2, 6, "Settlers of Catan"));
            listOfSession.Add(new Session(2, 2, "Skak"));
            listOfSession.Add(new Session(2, 4, "Kingdom Death: Monster"));
        }

        public List<Session> ListOfSession
        {
            get {
                bool isAdmin = Permission.CanSeeAllSessions();
                List<Session> returnList = FilterListData(isAdmin);
                return returnList;
            }
        }
        private List<Session> FilterListData(bool isAdmin)
        {
            List<Session> modifiedList;

            modifiedList = new List<Session>();
            
            if (isAdmin)
            {
                return listOfSession;
            }


            foreach (Session session in listOfSession)
                {
                    if (session.Date > DateTime.Today)
                    {
                    modifiedList.Add(session);
                    }
                }

            return modifiedList;
        }

        public void AddSession(Session session)
        {
            listOfSession.Add(session);
        }
    }
}
