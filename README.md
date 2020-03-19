# PI20-031 Aplikacija Doma za starije i nemoćne osobe "Vedrana" (mentor: mag. inf. Marko Mijač)

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
F04 | Prijem novog korisnika | Prijem novog i pregled sadašnjih i prošlih korisnika Doma. | Branimir Balogović
F05 | Evidencija njege | Pregled usluga njege koju je svaki od korisnika zaprimio (evidencija zdravstvenog stanja svakog korisnika). | Branimir Balogović
F06 | Automatsko generiranje obrazaca | Automatsko generiranje obrazaca za svakog od korisnika (ugovor, suglasnost, GDPR obrzac i dr.). | Branimir Balogović
F07 | Izrada jelovnika | Izrada i uređivanje (ukoliko je to potrebno) jelovnika, izrada se vrši tjedan dana unaprijed. Mogućnost dodjeljivanja jelovnika korisnicima. | Danijel Tokić
F08 | Evidencija skladišta | Evidencija proizvoda na skladištu, od hrane do proizvoda potrebnih za uslugu njege uz grafički prikaz podataka. | Danijel Tokić
F09 | Nabava proizvoda | Automatsko generiranje liste sa potrebnim proizvodima koji se naručuju: kada se dosegne niska količina određenog proizvoda ili namirnice potrebne za jelovnik. | Danijel Tokić

## Tehnologije i oprema
Za bazu podataka koristit ćemo MySql, MySql Workbench, MySql Server. Za izradu aplikacije koristit ćemo MS Visual Studio kao IDE i C# kao programski jezik za realizaciju iste (za pomoć u programiranju služit ćemo se službenom C# dokumentacijom). Od ostalih tehnologija koristi ćemo Differ za komunikaciju te GitHub za verzioniranje projekta, odnosno aplikacije.
