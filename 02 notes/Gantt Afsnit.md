
> [!NOTE] Title
> [[Bilag 3 - Gantt diagram (original)]]
> [[Bilag 4 - Gantt diagram (opdateret)]]
> "Vi er bevidste om at det ikke er muligt at lave en realistisk tidsplan over et hele projektet" Henvis til Larman.
>Most requirements analysis occurs during the elaboration phase, in parallel
with early production-quality programming and testing."
"the purpose of the inception phase is not to define all the requirements, or generate a believable estimate or project plan

Som en del af projektets forberedelse valgte vi tidligt at benytte et Gantt-diagram som planlægningsværktøj. Hensigten var, at imødekomme udfordringer fra vores forrige projekt, hvor vi brugte for meget lang tid i analyse- og designfasen, i jagten på den perfekte løsning. Ved at fastsætte tidsrammer skulle Gantt-diagrammet tvinge os til at træffe beslutninger, også når de ikke var perfekte. Vi udledte opgaverne fra opgaveformulerings krav, ikke some endelige opgaver, men som pladsholdere der kunne justeres løbende. Vi var bevidste om, at det ikke er muligt at lave en præcis tidsplan for hele projektet på forhånd. 

Det oprindelige Gantt-diagram (INDSÆT ref BILAG 3) antog en relativ lineær process gennem faserne, selvom vi forsøgte at visualisere iteration ved at lade UML-design og implementering overlappe.
Vores forventning var at påbegynde implementering allerede efter én uge og derved have tid ekstra features.  Estimeret tid til use cases og domænemodel var sat meget lavt og lagde ikke op til gentagene revisioner.

Det opdaterede Gantt-diagram (INDSÆT ref BILAG 4) viser projektets faktiske forløb og afslører væsentlige afvigelser fra den oprindelige plan. Design-fasen blev markant længere: use cases arbejdede vi gentagene gange over 7 dage og domænemodel over 6 dage. tilføjelse af milepæle(vejledningsmøder) hvilke ændrede projektets retning. Herudover blev krav-nedskærring nødvendigt hvor vi reducerede vores ambitionsniveau betydeligt. Vi startede derfor implementeringen en uge senere og vi reducerede den til 3 centrale use cases. 

Når man sammenligner de to diagrammer, er det tydeligt, at jo mere vi lærte om problemdomænet gennem analyse og design, desto tydligere blev det, at vores oprindelige scope var urealistisk. Man kan argumentere for, at vi aldrig rigtigt forlod elaboration-fasen da vi kontinuerligt havde behov for at tilpasse vores krav og arkitektur ud fra den plan vi havde lavet i inception-fasen, hvilket netop ikke er hensigten jvf. Larman "the purpose of the inception phase is not to define all the requirements, or generate a believable estimate or project plan"(INDSÆT ?Larman, s. 47?)

Gantt-diagrammets styrke lå i at synliggøre vores afvigelser fra den oprindelige plan, men det viste sig utilstrækkeligt som styringsværktøj i den daglige projektudførelse. Diagrammet var effektivt til at dokumentere hvad der var planlagt og hvad der faktisk skete, men hjalp ikke ti beslutningstagning og prioritering af næste skridt. De mange afvigelser og justeringer krævede et mere dynamisk planlægningsværktøj.

På baggrund af vores tidligere projekt sammen (*Objekt Orienteret Design og Programmering*) erfarede vi at vores personligheder alle har en tendens til afklarende og organiserende aktiviteter, frem for producerende og målrettede aktiviteter. Derfor introducerede vi projektstyrings modellen *The Natural Planning Model* (INDSÆT KILDE) som en hjælp for os til at tænke, og blive bevidste om, hvad der var nødvendigt for at projektet kunne komme frem. Modellen er en laissez-faire tilgang til projektstyring der fordrer at der løbende bliver reflekteret over om der er klarhed nok til at projektholdet kan definere den næste logiske handling i projektet. Hvis ikke, skal fokusset bevæge sig op af modellens abstraktions niveauer indtil klarhed er fundet, hvor efter den næste handling besluttes og handles på. Modellen definerer fem særskilte abstraktioner i et projekt:

