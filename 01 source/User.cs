namespace semesterprøve
{
    /// <summary>
    /// User-klassen repræsenterer en bruger i systemet og indeholder oplysninger om brugerens administrative rettigheder.
    /// </summary>
    /// <authors names = "Alle"/>
    public class User
    {
        private bool isAdmin; // boolean der angiver om brugeren er adminstrator,
        private string name;

        public bool IsAdmin { get => isAdmin; }
        public string Name { get => name; }

        public User() // Har en eksplicit tom constructor fordi vi opretter tomme objekter 
        {
        }
        public User(string name, bool isAdmin = false) // bemærk at isAdmin har en standard værdi, false, som giver begrænset rettigheder
        {
            this.isAdmin = isAdmin;
            this.name = name;
        }
    }
}
