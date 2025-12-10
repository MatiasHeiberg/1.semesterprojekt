using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace semesterprøve
{
    public class CreateSessionHandler
    {
        public CreateSessionHandler()
        {
            CreateSession();
        }

        private void CreateSession()
        {
            Session session = new Session();
            SetSessionData(session);
            Activity.AddSession(session);
        }
        private void SetSessionData(Session session)
        {
            session.SetPlayerMin();
            session.SetPlayerMax();
            session.SetDescription();
            session.AddParticipant();
        }
    }
}
