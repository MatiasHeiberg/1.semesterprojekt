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