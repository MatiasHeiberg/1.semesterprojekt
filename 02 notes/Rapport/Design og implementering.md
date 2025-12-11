
> [!NOTE] 
> ![[Implementeringsprincipper#^139892]]
> - Vi opnår DRY med abstraktion.
> #### Eksempler på principperne
> ##### Abstraktion
> - [[Use cases#2. Oprettelse af aktiviteter med mulighed for begrænsning af antal deltagere]]
> - [[Sekvensdiagram - Use case 2 version 3.png]]
> - CreateSession metoden har en masse hjælpemetoder der er abstraktioner
> ##### Indkapsling
> - Globale singleton objekter -> førte til persistent data i fil 
> ##### DRY
> Små bygge klodser der kan genbruges flere steder i koden
> TakeUserInput
> ##### Command-Query
> - Måske...
> ##### Logical Architecture 
> - Hvis med sekvens diagram at koden er opdelt i lag
> ##### Distributed Contorl
> - Hvis tidlig sekvensdiagram hvor alle metodekald går ind og ud af en central klasse (*centralized control*) og et nyt diagram hvor pilene går ind og ud af en masse forskellige klasser.

# Abstraktion
I klassen `CreateSessionHandler` er der metoden `CreateSession()` som opretter et objekt og kalder en masse *Set* metoder for at tilføje data til det. Her har vi abstraheret disse metode kald ud af metoden for at gøre den mere enkel og forståelig. I stedet er de placeret i hjælpemetoden `SetSessionData()`, hvilket har nok information i navnet til at det er forståeligt hvad `CreateSession()` gør. 

```csharp
private void CreateSession()
{
    Session session = new Session();
    SetSessionData(session);
    Activity.AddSession(session);
}
private void SetSessionData(Session session)
{
    session.SetPlayerMin();
    session.SetPlayerMax();
    session.SetDescription();
    session.AddParticipant();
}
```

# Indkapsling
Vores program har data på den nuværende bruger (i `State` klassen) og på alle aktiviteter oprettet (i `Activity` klassen). Vi havde problemer med at gøre denne data tilgængelig de steder i koden hvor den skulle bruges samtidig med at persistere den. Normalt ville vi oprette nye objekter der hvor dataen skulle tilgås, men dette vil skabe nye instanser af dataen uden at gemme eventuelle ændringer lavet til tidligere objekter. Vi løste først problemet ved at oprette *Singleton* objekter gemt i statiske variabler som vi kunne skrive til globalt. Dette brydder med indkapslings pricippet, derfor ledte vi efter en bedre løsning, hvilket blev at gemme dataen i en CSV fil som vi så kan læse/skrive til under runtime.

```csharp
    internal class Application
    {
        // Opretter statiske singleton objekter der skal persistere igennem hele programmets levetid.
        public static State state = new State();
        public static Activity activity = new Activity();
	}
```

Vi overvejede også at bruge *injection* til at få de to singleton objekter rundt i vores program som argumenter fra metode til metode, men dette virkede uoverskueligt og vi var i tvivl om det ville løse indkapslings problemet hvis store dele af programmets metoder alligevel havde en parameter der giver dem adgang til objekterne. Derfor gik vi med at bruge en ekstern fil som løsning.

I takt med at vi skriver dette afsnit (den sidste dag af rapportskrivningen) går det op for os at der er en anden mere simpel løsning. Problemet er at programmet skal kunne tage imod ændringer til data fra brugeren, og huske disse ændringer i løbet af programmets levetid, uden at bruge global data der bryder indkapslings princippet og uden at miste adgang til tidligere ændringer hver gang et nyt objekt oprettes. 
*Løsningen er at* gøre dataen `private static` og tilføje en public property alle objekterne kan tilgå, præcis der og kun der, hvor dataen er relevant. Dataen bliver ikke nulstillet ved kald af constructor, da den tilhører klassen. Dataen er ikke global da den private access modifier indkapsler den. Adgang til dataen kan præciseres ved kun at oprette nye objekter i de lokale scopes hvor det er relevant.
```csharp
class Application
{
	Activity activity = new Activity();
	Session session = new Session();
	activity.AddSession(session);
}

class Activity
{
	private static List<Session> listOfSessions; 

	public AddSession(Session)
	{
		listOfSessions.Add(Session);
	}
}
```

# DRY
I programmets klasse `View` er der en metode `TakeUserInput(string)`, som bliver brugt flere steder i koden til at tage forskellige slags input. Den har en string parameter der indeholder den instruks der skal forklare brugeren hvilket slags input programmet forventer af vedkommende. Ved at gøre argumentet til et parameter, og ikke en lokal variabel i metoden, kan metoden, og dens logik, genbruges til mange forskellige slags input. Det gør at vi undgår at skulle gentage Console.ReadLine(); i mange forskellige, men ens, metoder. 

# Distributed Control og Logical Architecture
I vores tidlige sekvensdiagram (INDSÆT REFERENCE TIL USE CASE 2 SEKVENSDIAGRAM VERSION 1) ses det hvordan en enkel klasse har ejerskab over hele sekvensen. Alt logik ligger inde i denne ene klasse og alle metodekald går ud, og returnere direkte tilbage til den. Denne tidlige arkitektur, kaldet *Centralized Control* (INDSÆT KILDE: Fowler), sammenfiltrer kildekoden og gør koden svær at forstå og vedligeholde. Vi opdagede ideen om lag, Larman kalder dem *Logical Architecture*, i *Applying UML and Patterns* midt i projektet, og ændrede efterfølgende vores arkitektur. Vores seneste version af samme sekvens kan ses (INDSÆT REFERENCE TIL USE CASE 2 SEKVENSDIAGRAM VERSION NYESTE) som viser hvordan arkitekturen har ændret programmet til *Distributed Control*