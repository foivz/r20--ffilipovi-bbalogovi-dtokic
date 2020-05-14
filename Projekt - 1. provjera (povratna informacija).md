PROJEKTNA DOKUMENTACIJA
---------------------------
* RAZVOJNI PRISTUP - Ok, odabran vodopadni model
* PROJEKTNI PLAN - Ok, plan prati faze vodopadnog modela
* PONUDA - Ok

TEHNIČKA DOKUMENTACIJA
---------------------------
* SRS - Započeto po SRS-u ali fali treće - glavno poglavlje.
* USE CASE - Use case Ažuriraj je nepotreban, također i actor za bazu. Use case Dodaj sastojak je jedan korak u definiranju jela, to nije cijeli use case.
* DIJAGRAMI AKTIVNOSTI I SLIJEDA - Zašto ste koristili fork i join elemente? Tu se nešto odvija paralelno prilikom unosa? Bazu možete maknuti osim ako niste implementirali neku programsku logiku u samoj bazi. Dijagram aktivnosti se treba fokusirati na funkcionalnost koju opisuje. Ne treba navoditi druge funkcionalnosti kao korake. Npr. dijagram za detalje o korisniku ima akciju "Prijava".
* DIJAGRAM KLASA - Klase treba nazvati u jednini, npr. RegistriranaOsoba a ne RegistriraneOsobe. Fale klase za grafičko sučelje.
* ERA DIJAGRAM - Veza između tablica osoba i zaposlenik, te osoba i korisnik je 0..1 a ne 1..1. Korisnik ne mora imati dodijeljenu sobu? Veza između imaUslugu i korisnik na strani korisnika je 1..1 a ne 0..1. Isto tako i za tablicu usluga. Slično vrijedi i za ostale asocijativne entitete. Na narudžbi se naručuje 1 ili više proizvoda.

IMPLEMENTACIJA
---------------------------
Započeta implementacija, uglavnom grafičko sučelje.

OSTALI ARTEFAKTI
---------------------------


BODOVI
----------------
9 bodova
