namespace semesterprøve
{
    /// <summary>
    /// Handler der opretter og gemmer ny sessionsobjekt.
    /// Sekvensen sættes automatisk i gang når konstruktoren modtager et metodekald.
    /// </summary>
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
            Activity.AddSession(session); // Gemmer den ny oprettede session
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
