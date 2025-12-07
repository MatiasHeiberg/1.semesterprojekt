using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using semesterprøve;

namespace WPFsemesterprøve
{
    /// <summary>
    ///
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();//Initialize alt der defineret i MainWindow
            
            RunWPF();//Kører RunWPF metode (indlæser brugere, sætter currentUser og opretter demosessioner) (Genbrugt fra konsol app)
            
            List<Session> sessions = Activity.ListOfSession;//henter listen af sessioner fra Activity (Genbrugt fra konsol app)
            
            SessionsDescriptionListBox.ItemsSource = sessions;//Sætter Listboxen i UI til at bruge listen af sessioner
           
            LoggedInAsTextBlock.Text = $"Logged in som {State.GetCurrentUser().Name} Admin: {State.GetCurrentUser().IsAdmin}"; //Opdaterer teksten der viser nuværende bruger (Genbrugt fra konsol app)
        }
        public void RunWPF()
        {
            
            semesterprøve.Application.AllUsers = IOFile.LoadUsers("Users.csv");//indlæs brugere fra CSV (Genbrugt fra konsol app)

            State.SetCurrentUser(semesterprøve.Application.AllUsers[0]);//Sætter currentUser i state (Genbrugt fra konsol app), her hardcoded til en bestemt bruger, (0 på listen)

            State.GetCurrentUser();//Læser nuværende bruger fra fil (Genbrugt fra konsol app)

            Activity.CreateDemoSessions();//Kører demo data oprettelse (Genbrugt fra konsol app)
        }

        //Eventhandler der kører når en session vælges i Listboxen formålet er at opdatere den anden Listbox med deltagerne i den valgte session.
        //session.ListOfParticipant genbrugt.
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            Session selectedSession = SessionsDescriptionListBox.SelectedItem as Session; //Caster det valgte 'item' til en session objekt. 
            
            if (selectedSession == null)//Hvis ingen session er valgt, sæt Listboxen til null og returner.
            {
                SelectedSessionListBox.ItemsSource = null;//Fjerner indholdet i den anden Listbox.
                return;
            }
            
            SelectedSessionListBox.ItemsSource = selectedSession.ListOfParticipant;//Sætter Listboxen til at vise deltagerne i den valgte session.
        }
        //Eventhandler der kører når "Join Session" knappen trykkes. Formålet er at lade bruger deltage i den valgte session.
        //session.AddParticipant genbrugt. Hvis ingen session er valgt, vis en besked til brugeren.
        private void JoinSessionButton_Click(object sender, RoutedEventArgs e)
        {
            Session selectedSession = SessionsDescriptionListBox.SelectedItem as Session; //Caster det valgte 'item' til en session objekt.
            if (selectedSession == null) //Hvis ingen session er valgt, vis en besked og returner.
            {
                MessageBox.Show("Vælg venligst en session først."); //Vis besked til brugeren.
                return;
            }
            JoinSessionHandler handler = new JoinSessionHandler(selectedSession); //Opretter en ny JoinSessionHandler med den valgte session.
        }
        //Eventhandler der kører når LoggedInUserTextBlock er loaded. Formålet er at opdatere teksten med nuværende bruger information.
        private void LoggedInUserTextBlock_Loaded(object sender, RoutedEventArgs e)
        {
            LoggedInAsTextBlock.Text = $"Logged in som {State.GetCurrentUser().Name} Admin: {State.GetCurrentUser().IsAdmin}";
        }
    }
}