using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterprøve
{
    //JoinSessionHandler håndtere tilmelding til af den aktualle bruger fra state til
    //en konkret session.

    public  class JoinSessionHandler
    {


        //Constructor som modtager den valgte session og nuværende state (bruger).
        //Kalder JoinSession() med det samme.
        public JoinSessionHandler(Session session)
        {
            JoinSession(session);
        }

        //Henter currentUser fra GetCurrentUser(som henter den fra state) og sender brugeren videre
        //til session.AddParticipant() som selv kalder Permission.CanJoinSession.
        private void JoinSession(Session session)
        {
            User currentUser = State.GetCurrentUser();
            session.AddParticipant();
        }
    }
}
