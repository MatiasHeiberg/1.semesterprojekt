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
using static System.Net.Mime.MediaTypeNames;

namespace semesterprøve
{
    public class Activity 
    {
        private List<Session> listOfSession = new List<Session>();

        public Activity()
        {

        }
        public void CreateDemoSessions()
        {
                listOfSession.Add(new Session(new List<User> { Application.AllUsers[0], Application.AllUsers[1], Application.AllUsers[2] }, 2, 4, "Ludo", new DateTime(2025, 11, 24, 19, 00, 00)));
                listOfSession.Add(new Session(new List<User> { Application.AllUsers[3], Application.AllUsers[4] }, 2, 6, "Matador", new DateTime(2025, 11, 24, 19, 00, 00)));
                listOfSession.Add(new Session(new List<User> { Application.AllUsers[5] }, 2, 6, "Settlers of Catan", new DateTime(2025, 12, 24, 19, 00, 00)));
                listOfSession.Add(new Session(new List<User> { Application.AllUsers[6], Application.AllUsers[7] }, 2, 2, "Skak", new DateTime(2025, 12, 24, 19, 00, 00)));
                listOfSession.Add(new Session(new List<User> { Application.AllUsers[8] }, 2, 4, "Kingdom Death: Monster", new DateTime(2025, 12, 24, 19, 00, 00)));
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
