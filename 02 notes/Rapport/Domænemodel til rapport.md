
> [!NOTE]- Title


Med udgangspunkt i vores use cases og vores MUST-krav fra MOSCOW har vi identificeret centrale objekter (eks. Spil) og begreber (eks. Session) i den virkelige verden og hvad deres relationer er. Domænemodellen viser altså selve bibliotekets brætspilscafe, så den kan hjælpe os til at forstå det konkrete domæne vi udvikler vores software til. 

I løbet af processen har vi udviklet domænemodellen fra version 1(INDSÆT [[Bilag 7 - Domænemodel version 1]]) til version 2 (INDSÆT [[Bilag 6 - Domænemodel version 2]]. Vores første model var for systemorienteret og brugte begreber som Bruger, Administrator og Tilmelding. Den første version bar præg af, at vi allerede havde et klart billede af hvad vores løsning skulle indeholde inden vi havde den nødvendige forståelse af domænet. Version 2 blev derfor udarbejdet for at give os en bedre forståelse af domænet.
# HUSK AT FORKLARE AI BRUG HER
![[Domænemodel version 2.png|800]]

I domænemodel version 2 har vi identificeret følgende:
**Bibliotek:** Det fysiske sted hvor arrangementet afholdes - de ejer endvidere de spil der udlånes til sessioner.
**Brætspilscafe:** Det konkrete arrangement der organiseres af ansatte og består af flere Sessioner.
**Ansat:** Fungerer som organisator af brætspilscafeen og er ansat af biblioteket. Denne rolle er vigtig ifm. Use Case 4, der beskriver en administrator der har overblik over tidligere sessioner.
**Session:** Den spilsession hvori der spilles med enten medbragt eller biblioteksspil. Use case 2 (oprettelse) og Use case 3 tager begge udgangspunkt i Sessioner. Sessionen kan desuden bestå af 1 til flere spillere men kun ét spil.
**Spillere:** De personer der deltager i brætspilscafeen og sessionerne.
**Gamemaster:** En rolle som en spiller kan have denne tager initiativ til en session.
**Spil**: De brætspil der benyttes under sessionerne.  Opdelt i to undertyper, Biblioteks Spil og Medbragte Spil. Denne differentiering er vigtig for senere udvidelser af systemet hvor vi ønsker at implementere COULD-krav fra MOSCOW hvori vi gerne vil have inventarstyring og overblik over hvilke spil der er tilgængelige.