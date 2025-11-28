Guide: [[Sequence diagram]]

# Version 1
Er designet med udgangspunkt i [[Klassediagram#Version 3]] og [[Use cases#2. Oprettelse af aktiviteter med mulighed for begrænsning af antal deltagere]]


```mermaid
sequenceDiagram
	actor 
	
	
	
	participant State
	participant User
	
	->State: CreateNewSession
	 
	


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