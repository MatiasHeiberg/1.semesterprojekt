# Mermaid Class Diagram Guide (Obsidian)

> [!Documentation]
> [Class diagrams | Mermaid](https://mermaid.js.org/syntax/classDiagram.html)

## Minimal Class
```mermaid
classDiagram
  class User
```

## Class With Fields & Methods
```mermaid
classDiagram
  class Person {
    string name
    int age
    +greet()
  }
```

## Relationships
- Inheritance: `A <|-- B`
- Association: `A --> B`
- Aggregation: `A o-- B`
- Composition: `A *-- B`
- Dependency: `A ..> B`

```mermaid
classDiagram
  Animal <|-- Dog
  Car o-- Wheel
  House *-- Room
  User ..> Logger
  Order --> Customer
```

## Multiplicity
```mermaid
classDiagram
  Person "1" --> "many" Pet
```

## Notes
```mermaid
classDiagram
  class Server
  note for Server "Handles requests"
```
