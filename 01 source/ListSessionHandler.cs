using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterprøve
{
    internal class ListSessionHandler
    {
        public ListSessionHandler()
        {
          ListSessions();
        }

        private void ListSessions()
        {
            Activity activity;
            activity = new Activity();  

            Permission permission;
            permission = new Permission();  

            List<Session> session = activity.ListOfSession;
            permission.CanSeeAllSessions(State state);

           




        }
    }
}
