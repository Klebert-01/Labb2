Spec:

1. ANVÄND KÖKSAPPARAT [X]

	- skriv ut undermeny val av köksapparat
	- låt användaren välja köksapparat
	- OM köksapparaten trasig, skriv ut det till användare <----------
		ANNARS skriv ut att apparaten används
	- gå tillbaka till huvudmenyn

2. LÄGG TILL NY KÖKSAPPARAT [X]

	- användare får mata in typ, märke, skick samt "j" eller "n"
		OM "j" betyder det att apparaten fungerar, OM "n" betyder det att apparaten är trasig
	- lagrar apparaten i en lista och skriver ut att apparaten har lagts till 
	- gå tillbaka till huvudmenyn

3. LISTA BEFINTLIGA KÖKSAPPARATER [X]

	- skriver ut listan med alla köksapparater (alla objekt i listan)
		i utskriften ska typ, märke och skick samt trasig eller hel skrivas ut
	- tillbaka till huvudmenyn

4. TA BORT KÖKSAPPARAT [X]

	- skriv ut numrerad lista över alla apparater
	- låt användaren ange vilken apparat i lista som ska tas bort och läs in valet
	- Tar bort apparaten ur listan och skriv ut att apparaten har tagits bort
	- tillbaka till menyn

5. AVSLUTA [X]

	- stäng ner programmet

Övrigt:

	- När programmet startas ska det redan finnas ett antal apparater lagrade i listan redo att användas
	- programmet ska felhantera all inmatning från användaren

KRAV: 

	- Variabler [X]
	- Properties (auto-implemented properties) [X]
	- Typkonvertering [X]
	- Felhantering med try-catch [X]
	- Klass/klasser [x]
	- Abstrakt klass/klasser [] behövs?
	- Interface: Använd bifogad kod (valfritt att utöka) [X]
	- Inkapsling [ ]
	- Metoder [x]
	- Iteration [x]
	- Selektion [x]

EGNA NOTES:

	- Lägga in metoder i egen klass/klasser /mvc(?) struktur
	- lägga till streamreader och läsa/spara ner listan med objekt till fil
