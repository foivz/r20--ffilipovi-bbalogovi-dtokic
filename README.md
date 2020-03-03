# Aplikacija Doma za starije i nemoćne osobe "Vedrana"

## Projektni tim
Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Filip Filipović | ffilipovi@foi.hr | 0016129682 | filipovicf2105
Branimir Balogović | bbalogovi@foi.hr | 0016129640 | bbalogovi
Danijel Tokić | dtokic@foi.hr | 0016129661 | dtokic25

## Opis domene
Ideja je izrada aplikacije za Dom za starije i nemoćne osobe "Vedrana" koja bi pomogla u svakodnevnom poslovanju poduzeća. Glavna zamisao je digitalizacija poslovanja te digitalna evidencija korisnika i zaposlenika Doma i povezanost svega navedenog.

## Specifikacija projekta
Kako su specifikacije projekta opisane u donjoj tablici, valja napomenuti da je zamišljen rad s bazom podataka, tako da će se svi podaci čuvati na serveru i bit će dostupni u bilo kojem trenutku. Specifikacije projekta su sljedeće:

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login | Za pristup aplikaciji potrebno se je ulogirati preko login forme koja na kraju sama raspoznaje ulogu prijavljene osobe u Domu te na temelju toga prikazuje drugačije sučelje (npr. njegovateljica neće imati pristup svim specifikacijama aplikacije kao administrator). | Filip Filipović
F02 | Registracija zaposlenika | Registraciju zaposlenika obavlja administrator, a sama registracija radi na način da zaposlenik na mail dobije automatski generiranu privremenu lozinku s kojom se prijavljuje u aplikaciju. | Filip Filipović
F03 | Evidencija zaposlenika | Pregled sadašnjih i prošlih zaposlenika i mogućnost dodavanja novog u aplikaciju, kao i zabrana pristupa bivšem zaposleniku. | Filip Filipović
F04 | Evidencija korisnika | Pregled sadašnjih i prošlih korisnika i mogućnost dodavanja novog u aplikaciju i pregled usluga njege koju je svaki od korisnika zaprimio (evidencija zdravstvenog stanja svakog korisnika). | Branimir Balogović
F05 | Automatsko generiranje obrazaca | Automatsko generiranje obrazaca za svakog od korisnika (ugovor, suglasnost, GDPR obrzac i dr.). | Branimir Balogović
F06 | Izrada jelovnika | Izrada i uređivanje (ukoliko je to potrebno) jelovnika, izdrada se radi tjedan dana unaprijed. | Danijel Tokić
F07 | Evidencija skladišta | Evidencija proizvoda na skladištu, od hrane do proizvoda potrebnih za uslugu njege uz grafički prikaz podataka. | Danijel Tokić
F08 | Nabava proizvoda | Automatsko generiranje liste sa potrebnim proizvodima koji se naručuju: kada se dosegne niska količina određenog proizvoda ili namirnice potrebne za jelovnik. | Danijel Tokić
F09 | Korisničko sučelje | Izrada i dizajn korisničkog sučelja primjereno korisnicima aplikacije. | Branimir Balogović
F10 | Baza podataka | Izrada baze podataka i komunikacija iste s aplikacijom. | Danijel Tokić
F11 | Korisničke upute | Korisničke upute za lakše snalaženje korisnika u aplikaciji. | Filip Filipović

## Tehnologije i oprema
Za bazu podataka koristit ćemo MySql, MySql Workbench, MySql Server. Za izradu aplikacije koristit ćemo MS Visual Studio kao IDE i C# kao programski jezik za realizaciju iste (za pomoć u programiranju služit ćemo se službenom C# dokumentacijom). Od ostalih tehnologija koristi ćemo Differ za komunikaciju te GitHub za verzioniranje projekta, odnosno aplikacije.
