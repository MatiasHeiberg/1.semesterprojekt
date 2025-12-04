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
        public List<Session> ListOfSession
        {
            get {
                bool isAdmin = Permission.CanSeeAllSessions();
                FilterListData(isAdmin);
                return listOfSession;
            }
        }
        private List<Session> FilterListData(bool isAdmin)
        {
            List<Session> modifiedList; 
            modifiedList = new List<Session>();

            if (isAdmin)
            {
                return ListOfSession;
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
