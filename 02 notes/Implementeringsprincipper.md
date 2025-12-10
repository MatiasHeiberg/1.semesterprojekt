
> [!NOTE] 
> Redegørende afsnit  for OO søjlerne og DRY, CommandQuery, Centraliserings kontrol vs Distribuerings kontrol (Fowler)
> - Indkapsling og abstraktion har fyldt mest
> - Brugte nedarvning i første iteration, så simplificerede vi og fokuserede hårdt 
> - 

Mulighederne for hvordan vi har kunne omsætte vores ideer i  objekt orientret design og implementering har været mange, hvilket skabte tvivl og meget forvirring tidligt i projektet. Med fare for at få *descision fatique* over hele tiden at skulle tage beslutninger som vi svært kunne begrunde, udvalgte vi nogle principper som retningslinje for vores implementering. Som en integreret del af Unified Process og den objekt orienteret tradition vi bliver undervist i, har vi fulgt de fire OO søjler 
1. Abstraktion
2. Indkapsling
3. Arv 
4. Polymorfi  

Derudover har vi også orienteret os efter 
- Don't Repeat Yourself (DRY) (INDSÆT KILDE: PRAGMATIC PROGRAMMER)
- CommandQuery (INDSÆT KILDE: Fowler)
- Logical Architecture (INDSÆT KILDE: Larman kap. 13)
- Distrubuted Control (INDSÆT KILDE: Fowler).

Abstraktion gør at detaljegraden af koden skjules sådan at kun den nødvendige information er tilgængelig for at kunne forstå den del af koden, eksempelvis en metode, der kigges på. Indkapsling fordrer at en hvilken som helst del af koden kun skal have adgang til det der er strengt 
