using static System.Runtime.InteropServices.JavaScript.JSType;

namespace semesterprøve
{
    /// <summary>
    /// Session-klassen repræsenterer en spilsession med deltagerliste, spillerbegrænsninger, beskrivelse og dato.
    /// </summary>
    /// <authors names = "Alle"/>
    public class Session
    {
        // Fields
        private List<User> listOfParticipant = new List<User>();
        private int playerMinimum;
        private int playerMaximum;
        private string description;
        private DateTime date = new DateTime(2025, 12, 24, 19, 00, 00);

        // Properties
        public DateTime Date { get => date; private set => date = value; }
        public string Description { get => description; private set => description = value; }
        public List<User> ListOfParticipant { get => listOfParticipant; private set => listOfParticipant = value; }
        public int PlayerMaximum { get => playerMaximum; private set => playerMaximum = value; }

        public int PlayerMinimum { get => playerMinimum; private set => playerMinimum = value; }

        // Constructor
        public Session(List<User> listOfParticipant, int playerMinimum, int playerMaximum, string description, DateTime date)
        {
            Date = date;
            Description = description;
            ListOfParticipant = listOfParticipant;
            PlayerMaximum = playerMaximum;
            PlayerMinimum = playerMinimum;
        }

        public Session() 
        {
        }

        // Methods
        public void SetPlayerMin()
        {
            string instruction;
            
            instruction = "Indtast dit ønskede minimum antal spillere"; 
            PlayerMinimum = Convert.ToInt32(View.TakeUserInput(instruction)); // Gemmer bruger input som minimum antal spillere

        }
        public void SetPlayerMax()
        {
            string instruction;

            instruction = "Indtast dit ønskede maximum antal spillere";
            PlayerMaximum = Convert.ToInt32(View.TakeUserInput(instruction)); // Gemmer bruger input som maximum antal spillere
        }
        public void SetDescription()
        {
            string instruction;

            instruction = "Indtast en kort beskrivelse af spillet";
            Description = View.TakeUserInput(instruction); // Gemmer bruger input som beskrivelse af sessionen og det spil der spilles
        }
        /// <summary>
        /// Metode til at tilføje et user objekt til en session.
        /// Den bruges både ed oprettelse af en session, til at tilføje "gamemasteren" til sessionen 
        /// samt når andre brugere efterfølgende tilmelder sig.
        /// </summary>
        public bool AddParticipant()
        {
            if (!Permission.CanJoinSession(ListOfParticipant.Count, PlayerMaximum)) // Spørger Permission-klassen om der er plads til en ny deltager
            {
                return false; // Hvis der ikke er plads, stop og returner false
            }
            ListOfParticipant.Add(State.GetCurrentUser()); // Hvis der er plads, tilføjes brugeren til deltagerlisten.
            return true; // Indtil nu ubrugt boolean (kunne bruge den til at bekræfte tilmelding)
        } 
    }

}
