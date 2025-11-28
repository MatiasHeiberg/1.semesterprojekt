Guide: [[Sequence diagram]]

# Version 1
Er designet med udgangspunkt i [[Klassediagram#Version 3]] og [[Use cases#2. Oprettelse af aktiviteter med mulighed for begrænsning af antal deltagere]]


```mermaid
sequenceDiagram
    actor B as Bruger
    participant V as View
    participant ST as State
    participant S as Session

    %% Bruger vælger funktionen
    B->>V: Vælg "Opret ny spilsession"
    V-->>B: Vis formular til ny spilsession

    %% Bruger udfylder og sender
    B->>V: Indtast beskrivelse, min, max, dato + klik "Opret"

    %% Systemet finder nuværende bruger
    V->>ST: getCurrentUser()
    ST-->>V: currentUser : User

    %% Session oprettes (ingen permissions)
    V->>S: new Session()
    V->>S: setDescription(beskrivelse)
    V->>S: setPlayerMinimum(min)
    V->>S: setPlayerMaximum(max)
    V->>S: setDate(dato)
    V->>S: addParticipant(currentUser)  <!-- hvis I vil have ejer/creator -->

    %% Session gemmes i View
    V->>V: listOfSession.Add(S)

    %% UI feedback
    V-->>B: Vis bekræftelse + opdateret liste med ny spilsession

```

```mermaid
classDiagram

    class Permission {
        canSeeAll()
    }

    class User {
        Role
        IsAdmin
    }

    class Activity {
        showActivity()
    }

    class View {
        printList(list, parameter)
    }

    Activity --> View
    View --> Permission
    Permission --> User


```

![[Pasted image 20251127130844.png|500]]