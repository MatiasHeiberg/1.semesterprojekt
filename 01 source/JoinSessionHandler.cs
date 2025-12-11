namespace semesterprøve
{
    /// <summary>
    /// JoinSessionHandler håndtere tilmelding til en eksisterende session.
    /// Sekvensen sættes automatisk i gang når konstruktoren modtager et metodekald.
    /// </summary>


    public class JoinSessionHandler
    {
        public JoinSessionHandler(Session session)
        {
            JoinSession(session);
        }

        private void JoinSession(Session session)
        {
            session.AddParticipant();
        }
    }
}
