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
            List<Session> session = Application.activity.ListOfSession;
            View.PrintSessionsWithIndex(session);
        }
    }
}
