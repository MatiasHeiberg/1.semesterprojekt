# Version 1
```mermaid
classDiagram

User <|-- Admin
User <|-- GameMaster
Event <-- Admin
GameSession <-- User
		
class User{
	property
    method()}
class Admin{
	property
    method()}
class GameMaster{
	property
    method()}
class Event{
	property
    method()}
class GameSession{
	property
    method()}
class Game{
	property
    method()}
```

Game <-- GameSession
GameSession <-- Event
Event <-- Game



GameSession <|-- GameMaster
Event <-- User

# Version 2

```mermaid
classDiagram

%% Class definitions
class Session {
	id : int
	ownership : User
	game : Game
	playerMinimum : int 
	playerMaximum : int
	date : Date
	description : string
	
	%% Skal have en constructor der tager default spiller count som standard værdi.
}
class User {
	-roles : List<Role>
	-sessionOwnership : list<Session>
	+IsAdmin : bool
	+IsGamemaster : bool
	
}
class Role {
	<<enumeration>>
    USER
    GAMEMASTER
    ADMIN
}
class Game {
	title : string
	playerMinimumDefault : int
	playerMaximumDefault : int
	inventoryCount : int
}
class UserProfile
class Date {
	date : DateTime
}
class Permission {
	+CanDeleteSession(User)
	+CanSeeFullSessionList(User)
	+IsGamemaster(User)
}

%% Class relationships
Session "1" --> "1..*" User
Session "1" --> "1" Game
Session "1" --> "1" Date
User "1" --> "1..3" Role
User "1" --> "1" UserProfile

```

# Version 3
Vi skærer klassediagrammet helt ind til essentielle features for at kunne opfylde opgavekravene. Se ![[Krav#^9cb3e5]]
```mermaid
classDiagram

%% Class definitions
class Session {
    -listOfParticipant : List<User>
	playerMinimum : int 
	playerMaximum : int
	description : string
	date : DateTime
	
}
class User {
	+IsAdmin : bool
	
}
class State {
	currentUser : User
}
%% Serviceklasse til at håndtere rettigheds kald i systemmet.
class Permission {
	<<service>>
}

%% Class relationships
Session "1" --> "1..*" User


```


# Version 4
Hænger sammen med [[Sekvensdiagram#Version 1]]

```mermaid
classDiagram

%% Class definitions
class Session {
	<<domain>>
    -listOfParticipant : List<User>
	-playerMin : int 
	-playerMax : int
	-description : string
	-date : DateTime
	
	+SetPlayerMin()
	+SetPlayerMax()
	+SetDescription()
	+AddParticipant(User)
	
	
}
class User {
	<<domain>>
	-isAdmin : bool
	
}
class State {
	<<application>>
	-currentUser : User
}
%% Serviceklasse til at håndtere rettigheds kald i systemmet.
class Permission {
	<<application>>
	+CanJoinSession(int, int)
}

class View {
	<<presentation>> 
	+TakeUserInput()
}
class Activity {
	<<domain>>
	-listOfSession : List<Session>
	
	+AddSession(Session)
}
class CreateSessionHandler{
	<<application>>
	-CreateSession()
	-GetCurrentUser()
	-SetSessionData(Session)
}
%% Class relationships
Session "1" -- "1..*" User
Session -- View
Session -- Activity
Session -- Permission
CreateSessionHandler -- View
CreateSessionHandler -- Session
CreateSessionHandler -- State
CreateSessionHandler -- Activity



```

# Version 5

```mermaid
classDiagram

%% CLASS DEFINITIONS
class Session {
	<<domain>>
    -listOfParticipant : List<User>
	-playerMin : int 
	-playerMax : int
	-description : string
	-date : DateTime
	
	+SetPlayerMin()
	+SetPlayerMax()
	+SetDescription()
	+AddParticipant(User)
	
	
}
class User {
	<<domain>>
	-isAdmin : bool
	
}
class State {
	<<application>>
	-currentUser : User
}
class Permission {
	<<application>>
	+CanJoinSession(int, int)
	+CanSeeAllSessions()
}

class View {
	<<presentation>> 
	+TakeUserInput()
	+PrintSessions()
	-SessionFormatter()
}
class Activity {
	<<domain>>
	-listOfSession : List<Session>
	
	+AddSession(Session)
}
class CreateSessionHandler{
	<<application>>
	-CreateSession()
	-GetCurrentUser()
	-SetSessionData(Session)
}
class JoinSessionHandler {
	<<application>>
	-JoinSession()
}
class ListSessionsHandler {
	<<application>>
	-ListSessions()
}

%% CLASS RELATIONSHIPS
%% Use case 2
Session -- View
Session -- Permission
CreateSessionHandler -- View
CreateSessionHandler -- Session
CreateSessionHandler -- State
CreateSessionHandler -- Activity
State -- User

%% Use case 3
ListSessionsHandler -- Activity
ListSessionsHandler -- View
Permission -- User
ListSessionsHandler -- JoinSessionHandler
Activity -- Permission
Permission -- State
View -- JoinSessionHandler
JoinSessionHandler -- State
JoinSessionHandler -- Session
```
# Version 6
```mermaid
classDiagram

class Session {
	<<domain>>
    +ListOfParticipant : List<User>
	+PlayerMin : int 
	+PlayerMax : int
	+Description : string
	+Date : DateTime
	
	+SetPlayerMin()
	+SetPlayerMax()
	+SetDescription()
	+AddParticipant(User)
}
class User {
	<<domain>>
	+IsAdmin : bool
	+Name : string
	
}
class State {
	<<application>>
	+GetCurrentUser()
	+SetCurrentUser(user)
}
class Permission {
	<<application>>
	+CanJoinSession(int, int)
	+CanSeeAllSessions()
}

class View {
	<<presentation>> 
	+TakeUserInput(string)
	+PrintSessionsWithIndex()
	-SessionFormatter()
}
class Activity {
	<<domain>>
	+ListOfSession : List<Session>
	+AddSession(Session)
	+CreateDemoSession()
	-FilterListData()
}
class CreateSessionHandler{
	<<application>>
	-CreateSession()
	-SetSessionData(Session)
}
class JoinSessionHandler {
	<<application>>
	-JoinSession()
}
class ListSessionsHandler {
	<<application>>
	-ListSessions()
}
class IOFile {
	<<data>>
	+ReadCurrentUser()
	+WriteCurrentUser()
	+LoadUsers()
	-ExtractUser()
}
class Application {
	<<application>>
	+AllUsers : List<User>
	-running : bool
	-Run()
	-ShowMainMenu()
	-MenuSelecter()
	-MenuItem()

}


Session -- View
Session -- Permission
Session -- State

Activity -- Permission

Application -- IOFile
Application -- State
Application -- Activity
Application -- View
Application -- JoinSessionHandler

CreateSessionHandler -- Session
CreateSessionHandler -- Activity

JoinSessionHandler -- State
JoinSessionHandler -- Session

ListSessionsHandler -- Activity
ListSessionsHandler -- View

Permission -- State

State -- User
State -- IOFile
```