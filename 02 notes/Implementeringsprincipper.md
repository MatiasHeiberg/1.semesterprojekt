
> [!NOTE] 
> Redegørende afsnit  for OO søjlerne og DRY, CommandQuery, Centraliserings kontrol vs Distribuerings kontrol (Fowler)
> - Indkapsling og abstraktion har fyldt mest
> - Brugte nedarvning i første iteration, så simplificerede vi og fokuserede hårdt 
> - Vi opnår DRY med abstraktion.

Mulighederne for hvordan vi har kunne omsætte vores ideer i  objekt orientret design og implementering har været mange, hvilket skabte tvivl og meget forvirring tidligt i projektet. Med fare for at få *descision fatique* over hele tiden at skulle tage beslutninger som vi svært kunne begrunde, udvalgte vi nogle principper som retningslinje for vores implementering. Som en integreret del af Unified Process og den objekt orienteret tradition vi bliver undervist i, har vi fulgt de fire OO søjler 
1. Abstraktion
2. Indkapsling
3. Arv 
4. Polymorfi  

Derudover har vi også orienteret os efter 
- Don't Repeat Yourself (DRY) 
- Command-Query 
- Logical Architecture
- Distributed Control

*Abstraktion* gør at detaljegraden af koden skjules sådan at kun den nødvendige information er tilgængelig for at kunne forstå den del af koden, eksempelvis en metode, der kigges på. *Indkapsling* fordrer at en hvilken som helst del af koden kun skal have adgang til de dele af programmet der er nødvendig for dens egen funktionalitet. *Arv* er når en subklasse bygger ovenpå en superklasse, sådan at subklassen samlet set består af alle medlemmer tilhørende begge klasser. *Polymorfi* er når den samme metode kan have forskellig funktionalitet afhængig af hvor og hvordan i koden den kaldes. *DRY* er den simple ide at den samme logik ikke skal gentages i kildekoden (INDSÆT KILDE: PRAGMATIC PROGRAMMER). *Command-Query* siger at metoder skal være forudsigelige og let forståelige ved kun at gøre en af to ting: ændre noget, eller hente noget (INDSÆT KILDE: Fowler). *Logical Architecture* er en måde at fordele ansvar i programmet ud på lag (INDSÆT KILDE: Larman kap. 13). *Distributed Control* er en arkitektur der fordeler ansvaret i programmet på tværs af klasser for at undgå enkelte, eller få, *gudeklasser* som bliveren flaskehals der sammenfiltrer hele kildekoden sammen (INDSÆT KILDE: Fowler).
