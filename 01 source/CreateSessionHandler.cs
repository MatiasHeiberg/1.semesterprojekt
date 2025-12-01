using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace semesterprøve
{
    internal class CreateSessionHandler
    {
        public CreateSessionHandler()
        {
            CreateSession();
        }

        private void CreateSession()
        {
            Session session;

            session = new Session();
            SetSessionData(session);
            activity.AddSession(session);
        }
        private void SetSessionData(Session session)
        {
            User currentUser;

            session.SetPlayerMin();
            session.SetPlayerMax();
            session.SetDescription();
            currentUser = GetCurrentUser();
            session.AddParticipant(currentUser);
        }
        private User GetCurrentUser()
        {
            User user;

            user = state.CurrentUser;

            return user;
        }


    }
}
