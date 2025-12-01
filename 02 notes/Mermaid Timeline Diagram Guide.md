> [!NOTE] Documentation  
> [Timeline | Mermaid](https://mermaid.js.org/syntax/timeline.html)

## Minimal Timeline

```mermaid
timeline
    title Project Timeline
    2024 : Start
```

## Multiple Events in a Single Year

```mermaid
timeline
    title Release Cycle
    2024 : Alpha Release : Beta Release
    2025 : Final Launch
```

## Multiple Date Formats

```mermaid
timeline
    title Mixed Dates
    2024 : Planning
    2024-05-01 : Kickoff
    May 2024 : Requirements
```

## Grouping by Sections

```mermaid
timeline
    title Product Development
    section Phase 1
      2024 : Research : Prototyping

    section Phase 2
      2025 : Development : Testing
```

## Styling (Basic)

```mermaid
timeline
    title Styled Example
    2024 : Event A
    2025 : Event B

    class EventA fill:#f9f,stroke:#333
```

## Notes / Descriptions

```mermaid
timeline
    title With Descriptions
    2024 : Start of project : "Initial setup and team formation"
    2025 : MVP Release : "First working version"
```