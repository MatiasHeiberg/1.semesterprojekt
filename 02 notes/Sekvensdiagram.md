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
# [[Use cases#2. Oprettelse af aktiviteter med mulighed for begrænsning af antal deltagere]]
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

actor _
box 1 Presentation
participant View
end
box 2 Application
participant CreateSessionHandler
participant State
participant Permission
end
box 3 Domain
participant Session
participant Activity
end

%% Message found
_->>CreateSessionHandler: new()
activate CreateSessionHandler
Note right of _: message found

	CreateSessionHandler->>CreateSessionHandler: CreateSession()
	activate CreateSessionHandler
		
		%% SetSessionData
		CreateSessionHandler->>Session: new()
		CreateSessionHandler->>CreateSessionHandler: SetSessionData()
		activate CreateSessionHandler
		
			%% SetPlayerMin
			CreateSessionHandler->>Session: SetPlayerMin()
			activate Session
			
				Session->>View: TakeUserInput(string)
				activate View
					
					View-->>Session: string
					
				deactivate View
				
			deactivate Session
			
			%% SetPlayerMax
			CreateSessionHandler->>Session: SetPlayerMax()
			activate Session
			
				Session->>View: TakeUserInput(string)
				activate View
				
					View-->>Session: string
					
				deactivate View
			
			deactivate Session
			
			%% SetDescription
			CreateSessionHandler->>Session: SetDescription()
			activate Session
			
				Session->>View: TakeUserInput(string)
				activate View
					
					View-->>Session: string
					
				deactivate View
				
			deactivate Session		
		
			%% getCurrentUser
			CreateSessionHandler->>CreateSessionHandler: GetCurrentUser()
			activate CreateSessionHandler
				
				CreateSessionHandler->>State: getCurrentUser
				activate State
					
				State-->>CreateSessionHandler: User
					
				deactivate State
				
			deactivate CreateSessionHandler
			
			%% AddParticipant
			CreateSessionHandler->>Session: AddParticipant(User)
			activate Session
				
				Session->>Permission: CanJoinSession(int, int)
				activate Permission
					
					Permission->>Session: bool
					
				deactivate Permission
				Session-->>CreateSessionHandler: bool
					
			deactivate Session
			
		deactivate CreateSessionHandler
		
		%% listOfSessions.add()
		CreateSessionHandler->>Activity: AddSession(Session)
		
	deactivate CreateSessionHandler
	
deactivate CreateSessionHandler
```
## Version 3
```mermaid
sequenceDiagram

box 1 Presentation
participant View
end
box 2 Application
participant Application
participant CreateSessionHandler
participant State
participant Permission
end
box 3 Domain
participant Session
participant Activity
end
box 4 Data
participant IOFile
end

%% Message found
Application->>CreateSessionHandler: new()
activate CreateSessionHandler
Note right of Application: message found

	CreateSessionHandler->>CreateSessionHandler: CreateSession()
	activate CreateSessionHandler
		
		%% SetSessionData
		CreateSessionHandler->>Session: new()
		CreateSessionHandler->>CreateSessionHandler: SetSessionData()
		activate CreateSessionHandler
		
			%% SetPlayerMin
			CreateSessionHandler->>Session: SetPlayerMin()
			activate Session
			
				Session->>View: TakeUserInput(string)
				activate View
					
					View-->>Session: string
					
				deactivate View
				
			deactivate Session
			
			%% SetPlayerMax
			CreateSessionHandler->>Session: SetPlayerMax()
			activate Session
			
				Session->>View: TakeUserInput(string)
				activate View
				
					View-->>Session: string
					
				deactivate View
			
			deactivate Session
			
			%% SetDescription
			CreateSessionHandler->>Session: SetDescription()
			activate Session
			
				Session->>View: TakeUserInput(string)
				activate View
					
					View-->>Session: string
					
				deactivate View
				
			deactivate Session		
			
			%% AddParticipant
			CreateSessionHandler->>Session: AddParticipant(User)
			activate Session
				
				Session->>Permission: CanJoinSession(int, int)
				activate Permission
					
					Permission->>Session: bool
					
				deactivate Permission
				Session->>State: GetCurrentUser()
				activate State
					
					State->>IOFile: ReadCurrentUser()
					activate IOFile
						
						IOFile-->>State: User
						
					deactivate IOFile
					State-->>Session: User
				
				deactivate State
				
				Session-->>CreateSessionHandler: bool
					
			deactivate Session
			
		deactivate CreateSessionHandler
		
		%% listOfSessions.add()
		CreateSessionHandler->>Activity: AddSession(Session)
		
	deactivate CreateSessionHandler
	
deactivate CreateSessionHandler
```

# [[Use cases#3. Tilmelding til aktiviteter]]
## Version 1
Er designet med udgangspunkt i [[Klassediagram#Version 5]].
```mermaid
sequenceDiagram

box 1 Presentation
participant View
end
box 2 Application
participant Application
participant ListSessionsHandler 
participant JoinSessionHandler 
participant State
participant Permission
end
box 3 Domain
participant Session
end


%% Message found
Application->>JoinSessionHandler: new()
activate JoinSessionHandler
Note right of Application: message found
	
	JoinSessionHandler->>JoinSessionHandler: JoinSession()
	activate JoinSessionHandler
		
		JoinSessionHandler->>View: TakeUserInput(string)
		activate View
			
			View-->>JoinSessionHandler: string
			
		deactivate View
		
		JoinSessionHandler->>State: getCurrentUser
		activate State
			
			State-->>JoinSessionHandler: User
			
		deactivate State
		JoinSessionHandler->>Session: AddParticipant(User)
		activate Session
			
			Session->>Permission: CanJoinSession(int, int)
			activate Permission
				
				Permission->>Session: bool
				
			deactivate Permission
			Session-->>JoinSessionHandler: bool
			
		deactivate Session
		JoinSessionHandler->>ListSessionsHandler: ListSession()
		
	deactivate JoinSessionHandler
	
deactivate JoinSessionHandler
```

## Version 2
```mermaid
sequenceDiagram

actor _
box 2 Application
    participant Application
    participant JoinSessionHandler 
    participant State
    participant Permission
end
box 3 Domain
    participant Session
end
box 4 Data
    participant IOFile
end

_->>Application: user selection
activate Application
	Note right of _: message found
	Application->>Application:MenuItem()
Application->>JoinSessionHandler: new(selection)
activate JoinSessionHandler
JoinSessionHandler->>JoinSessionHandler: JoinSession()

%% Hent nuværende bruger (via State/IOFile)
JoinSessionHandler->>State: GetCurrentUser()
activate State
State->>IOFile: ReadCurrentUser()
activate IOFile
IOFile-->>State: User
deactivate IOFile
State-->>JoinSessionHandler: User
deactivate State

%% Forsøg at tilføje bruger til Session
JoinSessionHandler->>Session: AddParticipant()
activate Session

Session->>Permission: CanJoinSession()
activate Permission
Permission-->>Session: canJoin
deactivate Permission
deactivate Session

deactivate JoinSessionHandler
deactivate Application


```
# Use case 4: ## [Admin](app://obsidian.md/Admin) ser information på tidligere [Session](app://obsidian.md/Session)s 
## Version 1
```mermaid
sequenceDiagram

box 1 Presentation
participant View
end
box 2 Application
participant Application
participant ListSessionsHandler 
participant State
participant Permission
end
box 3 Domain
participant User 
participant Activity
end


%% Message found
Application->>ListSessionsHandler: new()
activate ListSessionsHandler
Note right of Application: message found
	
	ListSessionsHandler->>ListSessionsHandler: ListSessions()
	activate ListSessionsHandler
		
		%% getListOfSessions
		ListSessionsHandler->>Activity: new()
		ListSessionsHandler->>Activity: getListOfSession
		activate Activity
			
			%% FilterByPermission
			Activity->>Permission: CanSeeAllSessions()
			activate Permission
			Permission->>State: getCurrentUser
			activate State
				
				State-->>Permission: User
				
			deactivate State
			Permission->>User: getIsAdmin
			activate User
				
				User-->>Permission: bool
				
			deactivate User
			Permission-->>Activity: bool
			deactivate Permission
			Activity-->>ListSessionsHandler: List<Session>
			
		deactivate Activity
		
		%% Print
		ListSessionsHandler->>View: PrintSessions(List<Session>)
		activate View
			
			loop
			View->>View: SessionFormatter()
			end
		deactivate View

	deactivate ListSessionsHandler
	
deactivate ListSessionsHandler
```
## [[Version 2]]
```mermaid
sequenceDiagram

box 1 Presentation
    participant View
end
box 2 Application
    participant Application
    participant ListSessionHandler 
    participant State
    participant Permission
end
box 3 Domain
    participant User 
    participant Activity
end
box 4 Data
    participant IOFile
end

%% Message found
Application->>ListSessionHandler: new()
activate ListSessionHandler

activate ListSessionHandler	
ListSessionHandler->>ListSessionHandler: ListSessions()
		
    %% get ListOfSessions
    ListSessionHandler->>Activity: get ListOfSession
    activate Activity
			
        %% FilterByPermission
        Activity->>Permission: CanSeeAllSessions()
        activate Permission

        Permission->>State: GetCurrentUser()
        activate State
				
        State->>IOFile: ReadCurrentUser()
        activate IOFile
        IOFile-->>State: User
        deactivate IOFile

        State-->>Permission: User
        deactivate State

        Permission->>User: IsAdmin
        activate User
        User-->>Permission: true
        deactivate User

        Permission-->>Activity: true
        deactivate Permission
        Activity->>Activity: FilterListData()

    Activity-->>ListSessionHandler: List<Session>
    deactivate Activity

%% Print
ListSessionHandler->>View: PrintSessionsWithIndex(List<Session>)
activate View

loop for hver session
    View->>View: SessionFormatter(session)
end
deactivate View

deactivate ListSessionHandler

```

# System flow sekvensdiagram 
## Version 1
```mermaid
sequenceDiagram
    actor User
    participant Application
    participant View
    participant ListSessionHandler
    participant JoinSessionHandler
    participant CreateSessionHandler

    User->>Application: Starter program (Main)
    activate Application

	Application->>Application: ShowMainMenu()

    loop hovedmenu kører
        Application->>ListSessionHandler: print sessioner
        View-->>Application: bruger input
			
        alt valg == "n"
            Application->>CreateSessionHandler: opret session

        else valg == "q"
            Application->>Application: afslut program
        else andet input
			Application->>Application: vælg session
			Application->>JoinSessionHandler: tilmeld session
            
        end
    end

    deactivate Application

```