# Mermaid Gantt Diagram Guide (Obsidian)
> [!NOTE] Documentation
> [Gantt diagrams | Mermaid](https://mermaid.js.org/syntax/gantt.html)
## Minimal Setup
```mermaid
gantt
  title Project Plan
  dateFormat YYYY-MM-DD
```

## Sections & Tasks
Syntax: `TaskName :id, start, duration`

```mermaid
gantt
  dateFormat YYYY-MM-DD

  section Planning
  Research :r1, 2025-01-01, 5d
  Draft    :after r1, 3d
```

## Dependencies
```mermaid
gantt
  dateFormat YYYY-MM-DD

  section Dev
  Backend :b1, 2025-02-01, 5d
  Frontend :after b1, 7d
```

## Milestones
```mermaid
gantt
  dateFormat YYYY-MM-DD

  section Release
  Launch :milestone, 2025-03-01, 0d
```

## Task States
- `crit`
- `active`
- `done`

```mermaid
gantt
  dateFormat YYYY-MM-DD

  section Work
  Core API   :crit, a1, 2025-02-01, 7d
  Frontend   :active, after a1, 6d
  Docs       :done, 2025-02-10, 2d
```
TODO
**Forberedelse**
- Repo (GitHub)
- Læse opgaveformulering sammen
- Obsidian opsætning
- Projektplanlægning
- Konktrakt?
- GANTT
**Ideudvikling**
- Udarbejd problemformulering
- Konceptbeskrivelse
- Fælles orbog
- Målgruppe
**Forretningsforståelse**
- BMC

**Rapport**
- Forside (se krav)
- Indholdsfortegnelse
- Indledning og problemformulering