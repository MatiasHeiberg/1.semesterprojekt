Guide: [[Sequence diagram]]

#### Syntax eksempel
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


#### Flow ide
Vi bruger [[OO layers]]
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
# [[Use cases#2. Oprettelse af aktiviteter med mulighed for begrænsning af antal deltagere|Use case 2]]
## Version 1
Er designet med udgangspunkt i [[Klassediagram#Version 3]], men er ajour med [[Klassediagram#Version 4|version 4]] 
```mermaid
sequenceDiagram

Actor _
Note left of _: message found
participant Session
participant View
participant State
participant Activity

_->>Session: CreateSession()
activate Session
Session->>View: TakeUserInput(string)
activate View
View-->>Session: playerMin : string 
deactivate View
Session->>View: TakeUserInput(string)
activate View
View-->>Session:  playerMax : string
deactivate View
	Session->>View: TakeUserInput(string)
activate View
View-->>Session: description : string 
deactivate View
Session->>State: get_CurrentUser()
activate State
State-->>Session: CurrentUser : User
deactivate State
Session->>Session: Session(int, int, string, User)
Session->>Activity: listOfSession.Add(Session)

deactivate Session
```

## Version 2
Er designet med udgangspunkt i [[Klassediagram#Version 3]], men er ajour med [[Klassediagram#Version 4|version 4]] 
```mermaid
sequenceDiagram

Actor _
Note left of _: message found
box 1 Presentation
participant View
end
box 2 Application
participant CreateSessionHandler 
participant State
end
box 3 Domain
participant Session
participant Activity
end


%% Message found
_->>CreateSessionHandler: new()

%% SetPlayerMin
activate CreateSessionHandler
CreateSessionHandler->>CreateSessionHandler: CreateSession()
CreateSessionHandler->>Session: SetPlayerMin()
activate Session
Session->>View: TakeUserInput(string)
activate View
View-->>Session: string
deactivate View
Session-->>CreateSessionHandler: int
deactivate Session

%% SetPlayerMax
CreateSessionHandler->>Session: SetPlayerMax()
activate Session
Session->>View: TakeUserInput(string)
activate View
View-->>Session: string
deactivate View
Session-->>CreateSessionHandler: int
deactivate Session

%% SetDescription
CreateSessionHandler->>Session: SetDescription()
activate Session
Session->>View: TakeUserInput(string)
activate View
View-->>Session: string
deactivate View
Session-->>CreateSessionHandler: string
deactivate Session

%% getCurrentUser
CreateSessionHandler->>State: getCurrentUser
activate State
State-->>CreateSessionHandler: User
deactivate State

%% Session Constructor
CreateSessionHandler->>Session: new(int, int, string, User)
Session-->>CreateSessionHandler: Session

%% listOfSessions.add()
CreateSessionHandler->>Activity: add(Session)
deactivate CreateSessionHandler
```