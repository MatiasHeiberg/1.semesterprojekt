
```mermaid

sequenceDiagram
     
    actor _ 
    participant P as Program
    participant A as Application
    participant I as IOFile
    participant F as File (Indbygget)
    participant U as User
    participant S as State
    
    _->>P: Log in
    Note right of _: message found
    P->>A: New() Application
    Activate A 
    A->>A: Run()
    Activate A
	A->>I: LoadUsers(Users.csv)
    Activate I
	I->>F: ReadAllLines()
	I->>A: New() List
	loop 
    I->>U: New() User
	I->>I: ExtractUser()
	I-->>I: return new() User split
	end
	I-->>A: return AllUser()
	Deactivate A
	Deactivate I
	A->>S: SetCurrentUser()
	Activate S
	S->>I: WriteCurrentUser()
	Activate I
	I->>F: WriteAllText()
	Deactivate I
	S-->>A: return 
	Deactivate S
	
	A->>S: GetCurrentUser()
	Activate S 
	
	S->>I: ReadCurrentUser()
	Activate I
	I->>U: New() User
	I->>F: ReadAllText()
	I->>I: ExtractUser()
	I-->>S: return
	Deactivate I
	S-->>A: return 
	Deactivate S
	Deactivate A
	
	
	
    
    


```


