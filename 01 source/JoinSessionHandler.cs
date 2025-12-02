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
    
    internal class JoinSessionHandler
    {
        //Den session som brugeren skal tilmeldes.
        private Session session;
        //Den bruger som skal tilmeldes til sessionen.
        private State state;

        //Constructor som modtager den valgte session og nuværende state (bruger).
        //Kalder JoinSession() med det samme.
        public JoinSessionHandler(Session session, State state)
        {
           
            this.session = session;
            this.state = state;

            JoinSession();
        }
        //Henter currentUser fra GetCurrentUser(som henter den fra state) og sender brugeren videre
        //til session.AddParticipant() som selv kalder Permission.CanJoinSession.
        private void JoinSession()
        {
            User currentUser = GetCurrentUser();
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
