
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
> - Måske
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