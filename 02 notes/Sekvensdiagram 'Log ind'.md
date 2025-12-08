
```mermaid

sequenceDiagram
    
    participant P as Program
    participant A as Application
    participant I as IOFile
    participant 
    
    P->>A: New()
    Activate A 
    A->>A: Run()
	A->>
	A->>I: LoadUsers(Users.csv)
	
	
	Deactivate A
	
	
    
    


```


