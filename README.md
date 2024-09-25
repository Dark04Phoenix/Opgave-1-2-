Dette projekt er et simpelt Trofæhåndteringssystem designet til at hjælpe med at holde styr på trofær vundet af en sportsmand.
Systemet gør edt muligt for brugeren at adminstrere trofæinformation gennem et klassbibliotek og inkluderer enhedstest for at sikre korrekt funktionalitet. 

Teknologier : C#, Visual Studio og MSTest enhedstest. 

Opgaveoversigt : Projektet er opdelt i to hovedopgaver: 

Opgave1: Klassebibliotek og Enhedstest 
1. Implementering af Trophy-klasse: Oprettet en Trophy klasse med følgende egenskaber:
2. Id: Et helttal, der repræsenterer trofæets ID.
3. Competition: En tekststreng, der repræsenterer navnet på konkurrencen, med en minimumlængde på 3 tegn og må ikke være null.
4. Year: Et heltal, der repræsenterer året, hvor trofæet blev tildelt, begrænset mellem 1970 og 2024.
5. Implementeret valideringsmetoder for disse egenskaber, som kaster passende undtagelser, hvis begrænsningerne overtrædes.
6. Tilføjet en ToString()- metode til at vise trofæets detaljer.
7. Udviklet enhedstest med god kode dækning for at sikre korrekt funktionalitet og validering af Trophy-klassen.
8. 2. Valideringslogik: Trophy-klassen indeholder valideringslogik, der kaster: ArgumentException for ugyldig Id og Competition.
   3. ArgumentOutOfRangeException for ugyldigt Year.
  
   4. Opgave2: Repository klasse
   5. 1. Implementering af TropgiesRepository:
      2. Udviklet en TrophiesRepository-klasse, der opretholder en liste af Trophy.objekter.
      3. Forudfyldt repository'en med mindst fem torfæoptegnelser.
      4. Implementeret følgende metoder:
      5. Get() : Returnerer en kopi af listen over alle trofæer med mulighed for filtrering efter år og sortering efter konkurrence eller år.
      6. GetById(int id): Henter et trofæ efter efter dets ID eller returnerer null, hvis det ikke findes.
      7. Add(Trophy trophy): Tilføjer et nyt trofæ og tildeler automatisk et ID.
      8. Remove(int id): Fjerner et trofæ efter dets ID og returnerer det, eller returnerer null, hvis det ikke findes.
      9. Update(int id, Trophy values): Opdaterer detaljerne for eksisternde trofæ og returnerer det opdaterede trofæ eller null.
     
      10. Enhedstest for Repository: Implementeret enhedstest for TrophiesRepository-klassen, der dækker følgende metoder:
      11. Get(): Sikrerr, at alle trofæer returneres.
      12. Add(): Tester, tilføjelsen af et nyt trofæ.
      13. Update(): Verificerer, at et eksisterende trofæ kan opdateres korrekt.
     
      14. Kodestruktur: Projektet er struktureret i flere filer:
      15. Trophy.cs: Indeholder Trophy-klassen med egenskaber, validering og metoder.
      16. TrophiesRepository cs: Indeholder TrophiesRepository-klassen med metoder til at adminstrere trofæer.
      17. TrophyUnitTests.cs: Indeholder enhedstest for Trophy-klassen.
      18. TrophyRepositoryUnitTests.cs: Indeholder enhedstest for TrophiesRepository-klassen.
     
      19. Konklusion: Dette projekt opfylder kravene for begge opgaver ved at implementere et robust trofæhåndteringssystem,
      20. med fokus på dataintegritet og validering. Inkluderingen af enhedstest sikrer, at funktionaliteten er pålidelig,
      21. og overholder specifikationerne.
     
      22. 1. Sådan Kører Du Projektet: Åbn løsningen i Visual Studio.
          2. Byg løsningen for at sikre, at alle afhængigheder er opfyldt.
          3. Kør enhedstestene for at validere funktionaliteten.
