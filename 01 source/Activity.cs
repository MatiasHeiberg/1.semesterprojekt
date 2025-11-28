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

namespace _1.semesterprøve
{
    public class Activity 
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
}
