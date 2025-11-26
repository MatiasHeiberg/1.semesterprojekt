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
	playerMinimum : int 
	playerMaximum : int
	description : string
	
}
class User {
	-roles : List<Role>
	+IsAdmin : bool
	
}
class Game {
	title : string
	playerMinimumDefault : int
	playerMaximumDefault : int
	availableCopies : int
}

class Date {
	date : list<DateTime>
	availbleGames : list<Game>
}
class Permission {
	<<service>>
}
%% Serviceklasse til at håndtere rettigheds kald i systemmet.
class Admin 

%% Class relationships
Session "1" --> "1..*" User
Session "1" --> "1" Game
Session "1" --> "1" Date
Admin --|> User

```