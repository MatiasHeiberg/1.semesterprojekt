/// <summary>
/// Activity-klassen repræsenterer en aktivitet, der indeholder en liste af sessions.
/// </summary>
/// <authors names = "Alle"/>
namespace semesterprøve
{
    public class Activity 
    {
        private static List<Session> listOfSession = new List<Session>();

        public Activity()
        {

        }
        public static void CreateDemoSessions()
        {
                listOfSession.Add(new Session(new List<User> { Application.AllUsers[0], Application.AllUsers[1], Application.AllUsers[2] }, 2, 4, "Ludo", new DateTime(2025, 11, 24, 19, 00, 00)));
                listOfSession.Add(new Session(new List<User> { Application.AllUsers[3], Application.AllUsers[4] }, 2, 6, "Matador", new DateTime(2025, 11, 24, 19, 00, 00)));
                listOfSession.Add(new Session(new List<User> { Application.AllUsers[5] }, 2, 6, "Settlers of Catan", new DateTime(2025, 12, 24, 19, 00, 00)));
                listOfSession.Add(new Session(new List<User> { Application.AllUsers[6], Application.AllUsers[7] }, 2, 2, "Skak", new DateTime(2025, 12, 24, 19, 00, 00)));
                listOfSession.Add(new Session(new List<User> { Application.AllUsers[8] }, 2, 4, "Kingdom Death: Monster", new DateTime(2025, 12, 24, 19, 00, 00)));
        }
        /// <summary>
        /// Property der returnere den filtrerede liste, tilpasset rettighederne af den nuværende bruger.
        /// </summary>
        public static List<Session> ListOfSession
        {
            get {
                bool isAdmin = Permission.CanSeeAllSessions(); // Returnere om brugeren er admin
                List<Session> returnList = FilterListData(isAdmin); // Gemmer den filtrerede liste 
                return returnList;
            }
        }
        /// <summary>
        /// Retunerer en filtreret liste ud fra isAdmin parameteren. 
        /// Er isAdmin false sorteres alle session objekter fra hvis Date propertien er ældre end Today().
        /// </summary>
        private static List<Session> FilterListData(bool isAdmin)
        {
            List<Session> modifiedList; 

            modifiedList = new List<Session>();
            
            if (isAdmin)
            {
                return listOfSession; // Er brugeren admin, returneres den fulde liste
            }


            foreach (Session session in listOfSession)
                {
                    if (session.Date > DateTime.Today)
                    {
                    modifiedList.Add(session);
                    }
                }

            return modifiedList; 
        }

        public static void AddSession(Session session)
        {
            listOfSession.Add(session);
        }
    }
}
