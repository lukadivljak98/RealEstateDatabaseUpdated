use nekretnine_database;

-- Mjesto
insert into Mjesto(BrPoste, Naziv) values ('78000', 'Banja Luka');
insert into Mjesto(BrPoste, Naziv) values ('78250', 'Laktaši');
insert into Mjesto(BrPoste, Naziv) values ('78200', 'Gradiška');
insert into Mjesto(BrPoste, Naziv) values ('11000', 'Beograd');
insert into Mjesto(BrPoste, Naziv) values ('70000', 'Istočno Sarajevo');

-- Osoba
insert into Osoba(JMB, Ime, Prezime, BrTelefona, Pol, BrPoste, Adresa) 
	values ('4587652154876', 'Marko', 'Markovic', '065254789', 0, (select BrPoste from Mjesto where Naziv = 'Banja Luka'), 'Karadjordjeva 355');
insert into Osoba(JMB, Ime, Prezime, BrTelefona, Pol, BrPoste, Adresa) 
	values ('8546325789521', 'Nikola', 'Nikolic', '066365874', 0, (select BrPoste from Mjesto where Naziv = 'Laktaši'), 'Kralja Petra 23');
insert into Osoba(JMB, Ime, Prezime, BrTelefona, Pol, BrPoste, Adresa) 
	values ('4348652154876', 'Jovan', 'Jovic', '066254321', 0, (select BrPoste from Mjesto where Naziv = 'Gradiška'), 'Duska Koscice 355');
insert into Osoba(JMB, Ime, Prezime, BrTelefona, Pol, BrPoste, Adresa) 
	values ('4587649854876', 'Mirko', 'Mitrovic', '065254478', 0, (select BrPoste from Mjesto where Naziv = 'Beograd'), 'Nikole Tesle 290');
insert into Osoba(JMB, Ime, Prezime, BrTelefona, Pol, BrPoste, Adresa) 
	values ('4587654584876', 'Nemanja', 'Nemanjic', '065236989', 0, (select BrPoste from Mjesto where Naziv = 'Istočno Sarajevo'), 'Kralja Alfonsa 355');
insert into Osoba(JMB, Ime, Prezime, BrTelefona, Pol, BrPoste, Adresa) 
	values ('5587654584876', 'Mitar', 'Lukic', '065236986', 0, (select BrPoste from Mjesto where Naziv = 'Gradiška'), 'Kralja Alfonsa 35');
insert into Osoba(JMB, Ime, Prezime, BrTelefona, Pol, BrPoste, Adresa) 
	values ('6587654584876', 'Zoran', 'Dragelji', '065236985', 0, (select BrPoste from Mjesto where Naziv = 'Laktaši'), 'Cara Lazara 3');
    
-- Klijent
insert into Klijent(JMB) values ('4587652154876');
insert into Klijent(JMB) values ('8546325789521');

-- Agencija
insert into Agencija(Naziv, BrTelefona, Adresa, BrPoste) 
	values('Senzor nekretnine', '065666342', 'Bana Milosavljevica 36', (select BrPoste from Mjesto where Naziv = 'Banja Luka'));
insert into Agencija(Naziv, BrTelefona, Adresa, BrPoste) 
	values('RE/MAX', '065122323', 'Jug Bogdana 122', (select BrPoste from Mjesto where Naziv = 'Istocno Sarajevo'));
insert into Agencija(Naziv, BrTelefona, Adresa, BrPoste) 
	values('Agencija za nekretnine CONDO', '066893432', 'Knez Mihailova 55', (select BrPoste from Mjesto where Naziv = 'Beograd'));
    
-- Agent
insert into Agent(JMB, Plata, idAgencija) 
	values('4348652154876', 1500.000, 1);
insert into Agent(JMB, Plata, idAgencija) 
	values('4587649854876', 1750.000, 2);
    
-- Vlasnik
insert into Vlasnik(JMB) values('4587654584876');
insert into Vlasnik(JMB) values('5587654584876');
insert into Vlasnik(JMB) values('6587654584876');

-- KarakteristikaNekretnine
insert into KarakteristikaNekretnine(Naziv) values('Ima Interent');
insert into KarakteristikaNekretnine(Naziv) values('Kvadratura');
insert into KarakteristikaNekretnine(Naziv) values('Broj soba');
insert into KarakteristikaNekretnine(Naziv) values('Tip grijanja');
insert into KarakteristikaNekretnine(Naziv) values('Broj garaznih mijesta');
insert into KarakteristikaNekretnine(Naziv) values('Ima balkon');

-- Klijent_zahtjeva_KarakteristikaNekretnine
insert into Klijent_zahtjeva_KarakteristikaNekretnine(Klijent_JMB, KarakteristikaNekretnine_idKarakteristikaNekretnine) 
	values('4587652154876', 1);
insert into Klijent_zahtjeva_KarakteristikaNekretnine(Klijent_JMB, KarakteristikaNekretnine_idKarakteristikaNekretnine) 
	values('8546325789521', 2);
    
-- Nekretnina
insert into Nekretnina(idNekretnina, BrPoste, Adresa, Vlasnik_JMB) 
	values (1, (select BrPoste from Mjesto where Naziv = 'Banja Luka'), 'Bana Milosavljevica 33', '4587654584876');
insert into Nekretnina(idNekretnina, BrPoste, Adresa, Vlasnik_JMB) 
	values (2, (select BrPoste from Mjesto where Naziv = 'Istocno Sarajevo'), 'D. i V. Kopanje 4', '4587654584876');
insert into Nekretnina(idNekretnina, BrPoste, Adresa, Vlasnik_JMB)
	values (3, (select BrPoste from Mjesto where Naziv = 'Beograd'), 'Kralja Aleksandra III 222', '4587654584876');
insert into Nekretnina(idNekretnina, BrPoste, Adresa, Vlasnik_JMB)
	values (4, (select BrPoste from Mjesto where Naziv = 'Gradiška'), 'Kralja Aleksandra I 111', '5587654584876');
insert into Nekretnina(idNekretnina, BrPoste, Adresa, Vlasnik_JMB)
	values (5, (select BrPoste from Mjesto where Naziv = 'Laktaši'), 'Kralja Petra II 333', '6587654584876');
    
-- Nekretnina_ima_KrakteristikaNekretnine
insert into Nekretnina_ima_KarakteristikaNekretnine(Nekretnina_idNekretnina, KarakteristikaNekretnine_idKarakteristikaNekretnine, DodatniOpis) values (1, 1, 'opis nekretnine');
insert into Nekretnina_ima_KarakteristikaNekretnine(Nekretnina_idNekretnina, KarakteristikaNekretnine_idKarakteristikaNekretnine, DodatniOpis) values (2, 2, 'opis nekretnine');
insert into Nekretnina_ima_KarakteristikaNekretnine(Nekretnina_idNekretnina, KarakteristikaNekretnine_idKarakteristikaNekretnine, DodatniOpis) values (3, 3, 'opis nekretnine');

-- NekretninaProdaja
insert into NekretninaProdaja(idNekretnina, PredlozenaCijena) values(1, 100000.000);
insert into NekretninaProdaja(idNekretnina, PredlozenaCijena) values(2, 200000.000);

-- NekretninaIznajmljivanje
insert into NekretninaIznajmljivanje(idNekretnina, PredlozenaKirija, SlobodnoOd, SlobodnoDo, jeIznajmljena) 
	values (3, 400.000, CURRENT_DATE(), CURRENT_DATE(), 0);
insert into NekretninaIznajmljivanje(idNekretnina, PredlozenaKirija, SlobodnoOd, SlobodnoDo, jeIznajmljena) 
	values (4, 400.000, CURRENT_DATE(), CURRENT_DATE(), 0);
insert into NekretninaIznajmljivanje(idNekretnina, PredlozenaKirija, SlobodnoOd, SlobodnoDo, jeIznajmljena) 
	values (5, 400.000, CURRENT_DATE(), CURRENT_DATE(), 0);
    
-- KupoprodajniUgovor
insert into KupoprodajniUgovor(Klijent_JMB, Agent_JMB, NekretninaProdaja_idNekretnina, Datum, Cijena, Opis) 
	values('4587652154876', '4348652154876',  1, CURRENT_DATE(), 100000.000,'opis ugovora');
    
-- UgovorIznajmljivanje
insert into UgovorIznajmljivanje(NekretninaIznajmljivanje_idNekretnina, Klijent_JMB, Agent_JMB, Kirija, Datum, Opis, MinimalanPeriodIznajmljivanja) 
	values (3, '4587652154876', '4348652154876', 400.000, CURRENT_DATE(), 'opis', 10);
            
-- Posjeta
insert into Posjeta(Datum, Klijent_JMB, Agent_JMB, idNekretnina) 
	values(CURRENT_DATE(), '8546325789521', '4587649854876', 3);