namespace semesterprøve
{
    /// <summary>
    /// Handler der returnere den liste der skal printes ud.
    /// Sekvensen sættes automatisk i gang når konstruktoren modtager et metodekald.
    /// </summary>
    /// <authors names = "Alle"/>
    internal class ListSessionHandler
    {
        public ListSessionHandler()
        {
          ListSessions();
        }

        private void ListSessions()
        {
            List<Session> session = Activity.ListOfSession; // Gemmer listen over sessioner der skal printes
            View.PrintSessionsWithIndex(session); // Metodekald til presentation laget der printer listen 
        }
    }
}
