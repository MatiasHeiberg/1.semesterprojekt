/// <summary>
/// Session-klassen repræsenterer en spilsession med deltagerliste, spillerbegrænsninger, beskrivelse og dato.
/// </summary>
/// <authors names = "Alle"/>
/// 
using System;
namespace semesterprøve
{
    public class Session
    {
        private List<User> listOfParticipant = new List<User>();

        private int playerMinimum;
        private int playerMaximum;
        private string description;
        private DateTime date = new DateTime(2025, 12, 24);


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
        public void AddParticipant(User currentUser)
        {
            listOfParticipant.Add(currentUser);
        }
    }

}
