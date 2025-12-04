/// <summary>
/// Session-klassen repræsenterer en spilsession med deltagerliste, spillerbegrænsninger, beskrivelse og dato.
/// </summary>
/// <authors names = "Alle"/>
/// 
using System;
using System.Reflection.Metadata.Ecma335;
namespace semesterprøve
{
    public class Session
    {
        private List<User> listOfParticipant = new List<User>();

        private int playerMinimum;
        private int playerMaximum;
        private string description;
        private DateTime date = new DateTime(2025, 12, 24);

        public DateTime Date { get => date; set => date = value; }

        public Session(List<User> listOfParticipant, int playerMinimum, int playerMaximum, string description, DateTime date)
        {
            this.listOfParticipant = listOfParticipant;
            this.playerMinimum = playerMinimum;
            this.playerMaximum = playerMaximum;
            this.description = description;
            this.Date = date;
        }

        public Session(int playerMinimum, int playerMaximum, string description, DateTime date)
        {
          
            this.playerMinimum = playerMinimum;
            this.playerMaximum = playerMaximum;
            this.description = description;
            this.Date = date;
        }

        public Session(int playerMinimum, int playerMaximum, string description)
        {

            this.playerMinimum = playerMinimum;
            this.playerMaximum = playerMaximum;
            this.description = description;
           
        }

        public Session()
        {
        }

        public void SetPlayerMin()
        {
            string instruction;
            int playerMinimum;

            instruction = "Indtast dit ønskede minimum antal spillere";
            playerMinimum = Convert.ToInt32(View.TakeUserInput(instruction));

            this.playerMinimum = playerMinimum;

        }
        public void SetPlayerMax()
        {
            string instruction;
            int playerMaximum;

            instruction = "Indtast dit ønskede maximum antal spillere";
            playerMaximum = Convert.ToInt32(View.TakeUserInput(instruction));

            this.playerMaximum = playerMaximum;
        }
        public void SetDescription()
        {
            string instruction;
            string description;

            instruction = "Indtast en kort beskrivelse af spillet";
            description = View.TakeUserInput(instruction);

            this.description = description;

        }
        //Metode til at tilføje nye spillere til eksisterende eller nye sessioner.
        public bool AddParticipant()
        {
            //Spørger Permission-klassen om der er plads til en ny deltager
            //Sender antal deltagere og max som argumenter.
            if (!Permission.CanJoinSession(listOfParticipant.Count, playerMaximum))
            {
                return false; // Hvis der ikke er plads, stop og returner false.
            }
            //Hvis der er plads, tilføjes brugeren til deltagerlisten.
            listOfParticipant.Add(Application.state.CurrentUser);
            return true; //Bekræfter at brugeren er blevet tilføjet.
        } 
    }

}
