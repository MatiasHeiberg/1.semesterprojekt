
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

Vi overvejede også at bruge *injection* til at de to singleton objekter rundt i vores program som argumenter fra metode til metode, men dette virkede uoverskueligt og vi var i tvivl om det ville løse indkapslings problemet hvis store dele af programmets metoder alligevel fik adgang til objekterne igennem dens metode parameter. Derfor gik vi med at bruge en ekstern fil. 

%% En anden løsning vi har diskuteret efterfølgende, var at oprette to variabler. En `private static` og en som instans variabel der kopiere dataen gemt i den statiske. Hver gang programmet skal have adgang til dataen, oprettes der et nyt objekt som der kan skrives ny data til via instans variablen. Den data kan så persisteres ved at gemme den  %%