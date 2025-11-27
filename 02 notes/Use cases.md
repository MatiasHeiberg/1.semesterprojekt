
Formater

> [!example]- Brief
> One-liner der beskriver et handlingsforløb.


> [!example]- Casual
> **Titel:** Scenarie titel
> **Primær aktør:** Bruger
> **Successcenarie:** Brugeren gør noget og når i mål med opgaven.


> [!example]- Fully Dressed
> Valgfri prosatekst der introducerer use casen.
> 
> **Titel:** Scenarie titel 
> **Primær aktør:** Bruger
> **Sekundær aktør:** Admin
> **Forudsætninger:** 
> - Strøm på enheden
> - Pro medlemsskab
> - Sidder i sin bil
> 
> **Successcenarie:** Brugeren gør noget og når i mål med opgaven.
> **Stakeholders:**
> **Scope:**
> **Level:**
> **Hovedforløb:**
> 1. Brugeren åbner appen
> 2. Brugeren logger ind
> 3. Brugeren udvælger en rute
> 4. Brugeren følger ruten via appens guide
> 5. Brugeren finder eventyrkaraktererne undervejs på den guidede rute
> 6. Brugeren når til vejs ende af ruten, og er dermed færdig
> 7. Brugeren kan se hvilke eventyrkarakterer brugeren har fundet på ruten
> 8. Brugeren lukker appen ned
> 
> **Alternativer/extensions:**
> **Undtagelser**:

# Version 1

## 1. Håndtere medlemskab
#### Brief:
[[Admin]] fjerner bruger fra systemet.

#### Casual:
* **Titel**: [[Admin]] fjerner bruger fra systemet.  
* **Primær aktør:*** [[Admin]]  
* **Successcenarie:** [[Admin]] går ind på brugerprofilen og sletter brugeren. ^649c42

%% Version 1 
**2. Oprettelse af aktiviteter med mulighed for begrænsning af antal deltagere**
**Brief:**
Bruger opretter ny spilsession

**Casual:**
**Titel:** Bruger opretter ny spilsession  
**Primær aktør:** Bruger  
**Successcenarie:** Bruger klikker ind på et specifikt arrangement og trykker opret spilsession, vælger spil og deltagerbegrænsning.
 %%

%% Version 2 %%
## 2. Oprettelse af aktiviteter med mulighed for begrænsning af antal deltagere
**Brief:**
Bruger opretter ny spilsession

#### Casual:
**Titel:** Bruger opretter ny spilsession  
**Primær aktør:** Bruger  
**Successcenarie:** Bruger opretter spilsession, tilføjer beskrivelse, udvælger spil og dato .

## 3. Tilmelding til aktiviteter
#### Brief:
Bruger tilmelder sig spilsession

#### Casual:
**Titel:** Bruger tilmelder sig spilsession
**Primær aktør:**  Bruger
**Successcenarie:** Bruger vælger en spilsession, læser beskrivelse og tilmelder sig.

## 4. [[Admin]] ser information på tidligere [[Session]]s
#### Brief:
[[Admin]] åbner [[ListOfSession]] og ser de tidligere afholdte [[Session]]s.

#### Casual:
**Titel:** [[Admin]] ser [[ListOfSession]]  
**Primær aktør:** [[Admin]]
**Successcenarie:** [[Admin]] ser tidligere [[Session]]s og får overblik og historik over tidligere sessioner.

## 5. Oprettelse af [[Date]](s)
#### Brief:
[[Admin]] tilføjer datoer til listen over kommende [[Date]]s. 

#### Casual: 
**Titel:** [[Admin]] tilføjer en [[Date]] til [[ListOfDate]].
**Primær aktør:** [[Admin]]
**Successcenarie:** [[Admin]] opretter nyt [[Date]]. [[Date]] bliver synligt for alle [[User]] i [[ListOfDate]].

## 6. Tilføjelse af [[Game]]
#### Brief:
[[Admin]] tilføjer [[Game]] til listen over [[ListOfGame]]. 

#### Casual: 
**Titel:** Tilføjelse af [[Game]].
**Primær aktør:** [[Admin]]
**Successcenarie:** [[Admin]] logger ind og tilføjer Ludo som et spil medlemmerne kan bruge. Administratoren skriver en beskrivelse af spillet, vælger deltagerbegrænsning og hvor mange fysiske eksemplar der er tilgængelig. 


# Version 2


## 1. Håndtere medlemskab
#### Brief:
[[Admin]] fjerner bruger fra systemet.

#### Casual:
* **Titel**: [[Admin]] fjerner bruger fra systemet.  
* **Primær aktør:*** [[Admin]]  
* **Successcenarie:** [[Admin]] går ind på brugerprofilen og sletter brugeren. ^649c42
## 2. Oprettelse af aktiviteter med mulighed for begrænsning af antal deltagere
**Brief:**
Bruger opretter ny spilsession

#### Casual:
**Titel:** Bruger opretter ny spilsession  
**Primær aktør:** Bruger  
**Successcenarie:** Bruger opretter spilsession, tilføjer beskrivelse og sætter deltagerbegrænsning.

## 3. Tilmelding til aktiviteter
#### Brief:
Bruger tilmelder sig spilsession

#### Casual:
**Titel:** Bruger tilmelder sig spilsession
**Primær aktør:**  Bruger
**Successcenarie:** Bruger vælger en spilsession, læser beskrivelse og tilmelder sig.

## 4. [[Admin]] ser information på tidligere [[Session]]s
#### Brief:
[[Admin]] åbner [[ListOfSession]] og ser de tidligere afholdte [[Session]]s.

#### Casual:
**Titel:** [[Admin]] ser [[ListOfSession]]  
**Primær aktør:** [[Admin]]
**Successcenarie:** [[Admin]] ser tidligere [[Session]]s og får overblik og historik over tidligere sessioner.

## 5. Oprettelse af [[Date]](s)
#### Brief:
[[Admin]] tilføjer datoer til listen over kommende [[Date]]s. 

#### Casual: 
**Titel:** [[Admin]] tilføjer en [[Date]] til [[ListOfDate]].
**Primær aktør:** [[Admin]]
**Successcenarie:** [[Admin]] opretter nyt [[Date]]. [[Date]] bliver synligt for alle [[User]] i [[ListOfDate]].

## 6. Tilføjelse af [[Game]]
#### Brief:
[[Admin]] tilføjer [[Game]] til listen over [[ListOfGame]]. 

#### Casual: 
**Titel:** Tilføjelse af [[Game]].
**Primær aktør:** [[Admin]]
**Successcenarie:** [[Admin]] logger ind og tilføjer Ludo som et spil medlemmerne kan bruge. Administratoren skriver en beskrivelse af spillet, vælger deltagerbegrænsning og hvor mange fysiske eksemplar der er tilgængelig. 

