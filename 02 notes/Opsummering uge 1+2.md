# [[2025-11-18]]
- "Vi valgte at gå med biblioteks casen fremfor DND fordi:
	Vi lagde os næsten fast på en idé (Tilmeldingssystem til brætspilsaften på Silkeborg Bibliotek) længere tids brainstorm. Vi overvejede at lave et matchmaking system til Dungeons and Dragons, men lagde os fast på den anden idé fordi vi var bange for at gå ud af vores scope og det derved hurtigt blev alt for omfattende til et 4 ugers projekt."
- Vi lavede gruppekontrakt
- Vi har valgt at bruge Obsidian, Typst.
- Vi har droppet Git-plugin til Obsidian da det blev for rodet og tog for meget tid.
- Vi har valgt at arbejde ud fra disse principper:
	- Definere nogle arbejds titler fra starten og udfylder dem med udkast løbende gennem projektet.
	- daily session based process logs kilde: 1 Donald Schön’s _Reflective Practitioner_ framework (MIT Press)  
	- descision log kilde: ADR (Architecture Decision Record) format
# [[2025-11-19]]
- Lave første problemformuleringer ud fra biblioteks tekst Kilde: ==Mangler==
- Problemstillinger, Ordbog, Gantt, Første udkast til BMC,
- **Administrator skal kunne sætte datoer samt definere spilbeholdning.**
```mermaid
flowchart TD

A[Start] --> B[Brainstorm og idefase]

B --> C[Idé: DnD matchmaking]
B --> D[Idé: Brætspilscafe tilmeldingssystem]

C --> C1{Er scope realistisk}
C1 -->|Nej| D
C1 -->|Ja| C2[Fravalgt alligevel]

D --> E[Valgt projekt: Brætspilscafe på Silkeborg Bibliotek]

E --> F[Analyse: BMC, vision, krav]
F --> G[Domænemodel version 1]
G --> H{Bliver kravene for komplekse}
H -->|Ja| I[Skar MUST-krav helt ned]
H -->|Nej| J[Domænemodel fastholdes]

I --> J[Domænemodel version 2 godkendt]

J --> K[Klassediagram version 1]
K --> L{Matcher klassediagrammet kravene}
L -->|Nej| M[Revideret klassediagram]
L -->|Ja| N[Grønt lys til implementering]

M --> N

N --> O[Console først, WPF senere]
O --> P[Interview med Andreas]
P --> Q[Sekvensdiagram, UI-skitser og kode]
Q --> R[Implementering og dokumentation]

```