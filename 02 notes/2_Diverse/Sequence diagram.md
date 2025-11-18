# Mermaid Sequence Diagram Guide (Obsidian)
> [!NOTE] Documentation
> [Sequence diagrams | Mermaid](https://mermaid.js.org/syntax/sequenceDiagram.html)
## Minimal Exchange
```mermaid
sequenceDiagram
  Alice->>Bob: Hello
```

## Arrow Types
- Sync: `A->>B`
- Async: `A-->>B`
- Solid: `A->B`
- Dashed: `A--B`

```mermaid
sequenceDiagram
  A->>B: Sync
  A-->>B: Async
  A->B: Solid
  A--B: Dashed
```

## Participants
```mermaid
sequenceDiagram
  participant User
  participant API
  User->>API: Request
```

## Activation / Deactivation
```mermaid
sequenceDiagram
  A->>B: Call
  activate B
  B->>A: Return
  deactivate B
```

## Loops & Conditionals
```mermaid
sequenceDiagram
  loop Retry
    User->>Server: Attempt
  end

  alt Success
    Server->>User: OK
  else Fail
    Server->>User: Denied
  end
```

## Notes
```mermaid
sequenceDiagram
  A->>B: Ping
  Note over A,B: Processing
```
