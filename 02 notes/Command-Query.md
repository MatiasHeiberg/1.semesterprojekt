- **Commands**: Methods that **change the state** of an object but **do not return a value**.
    
    - Example: `deposit(amount)` in a bank account updates the balance but doesn’t return it.
        
- **Queries**: Methods that **return information** about the state **without changing it**.
    
    - Example: `getBalance()` returns the balance but does not modify it.
        

**Key Idea:**

> Don’t mix state-changing operations with return-value operations in the same method.