/// <summary>
/// Activity-klassen repræsenterer en aktivitet, der indeholder en liste af sessions.
/// </summary>
/// <authors names = "Alle"/>
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterprøve
{
    public class Activity 
    {
        private List<Session> listOfSession = new List<Session>();

        public void AddSession(Session session)
        {
            listOfSession.Add(session);
        }
    }
}
