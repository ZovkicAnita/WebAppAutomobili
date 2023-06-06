
Software Requirements Specification
(Specifikacija softverskih zahtjeva)
za projekt
Aplikacija za automobile
Verzija 1.0

Autor:

Anita Zovkić



Ekonomski fakultet u Osijeku

Kolegij: Razvoj poslovnih aplikacija
05.06.2023.
 
Sadržaj
1.	Uvod	1
1.1	Svrha aplikacije	1
1.2	Korisnici aplikacije	1
1.3	Koristi (benefiti) od aplikacije	1
2.	Zahtjevi	1
2.1	Funkcijski zahtjevi	1
2.2	Sistemski, hardverski i mrežni zahtjevi	1
2.3	Sigurnost	1
2.4	Korisnički zahtjevi	1
2.5	Slučajevi (scenariji) korištenja (use-case dijagrami)	2
2.5.1. Slučaj korištenja 1: Pregled automobila	2
2.5.2.	Slučaj korištenja 2: Dodavanje novog automobila	3
2.5.3.	Slučaj korištenja 3: Uređivanje automobila	3
2.5.4.	Slučaj korištenja 4: Brisanje automobila	3
2.6.	Dijagrami klasa	4
3.	Dizajn korisničkog sučelja	5
3.5.	Wireframe-ovi i Mockup-i	6




 
1.	Uvod
1.1	Svrha aplikacije 
Kroz vježbe kolegija “Razvoj poslovnih aplikacija” razvit će se jednostavna aplikacija za automobile koja podržava unos, uređivanje, brisanje, pretragu i popis automobila u bazi. Aplikacija također treba omogućiti brisanje i prikaz detalja pojedinog automobila. Svaki unos podataka kroz aplikaciju treba uključivati provjeru valjanosti i za brisanje podataka je potrebna posebna potvrda korisnika.
1.2	Korisnici aplikacije
Aplikaciji trebaju moći pristupiti svi korisnici koji imaju internet i internet preglednik te žele pristupiti svim bitnim informacijama  o raznim automobilima na jednom centraliziranom mjestu.
1.3	Koristi (benefiti) od aplikacije
Stvorit će se jedna centralna baza podataka o automobilima dostupna svima. Korisnici kada budu htjeli potražiti informacije o automobilima, neće više morati pretraživati putem Google-a i koristiti više izvora za dobivanje informacija o nekom automobilu jer će kroz aplikaciju moći dobiti sve potrebne informacije na jednom mjestu. Aplikacija će biti dostupna putem interneta, zahvaljujući tome, korisnik ima mogućnost korištenja aplikacije u bilo koje vrijeme. 

2.	Zahtjevi
2.1	Funkcijski zahtjevi
Aplikacija mora omogućiti spremanje, uređivanje, pretraživanje, prikaz, traženje i  brisanje automobile u bazi podataka.
2.2	Sistemski, hardverski i mrežni zahtjevi
Budući da će aplikacija biti razvijena u ASP.NET Core MVC-u, ona treba biti smještena na Microsoft Web poslužitelju (eng. server). Preporučuju se sljedeće hardverske specifikacije:

Minimum četverojezgreni procesor radnog takta 2.2 GHz
Minimum 32GB RAM memorije
Minimum 1TB diskovnog prostora
Operativni sustav Windows server 2019





2.2.1  Web server
Preporučuje se korištenje windows azure-a za hostanje aplikacije.
Windows azure može hostati bilo koju ASP.NET Core MVC aplikaciju, uključujući i našu predloženu aplikaciju u ovom dokumentu. Skaliranje je vrlo jednostavno jer je Microsoft odgovoran za dodavanje resursa na poslužitelju za vrijeme visokog prometa. Troškovi su minimalni, oni ovise o količini podataka koji se prikazuju posjetiteljima te održavanje hardware nije uključeno u njih. 

2.2.2  Baza podataka
Preporučuje se korištenje SQL SERVER baze podataka unutar WA za temljenu bazu podataka aplikacije. Što se tiče web poslužitelja, ova preporuka osigurava visoku dostupnost hostinga za bazu podataka s dobrim omjerom vrijednosti za uloženi novac. To posebno ima smisla ako je i web aplikacija hostana na Windows azure-u.
2.3	Sigurnost
U kasnijem razvoju aplikacije, razvit će se sigurna identifikacija i zaštićena autentifikacja gdje korisnička imena i lozinke ne smiju biti spremljena u obična tekstualna polja ili datoteke, a osobni podaci korisnika, kao što su adresa, tel brojevi i brojevi kreditnih kartica neće biti dostupni anonimnim pristupom.  
2.4	Korisnički zahtjevi
Tablica. Korisnički zahtjevi
Rb.	Zahtjev	Vrsta korisnika (user / admin)
1.	Prikaz svih autombila	Anonimni korisnik
2.	Pretraga automobila po modelu i nazivu	Anonimni korisnik
3.	Unos automobila	Registrirani korisnik
4. 	Uređivanje automobila	Registrirani korsnik
5.	Brisanje automobila	Administrator 
6.	Provjera valjanosti podataka kod unosa i uređivanja 	Registrirani korisnik
7.	Potvrda s pitanjem “Jeste li sigurni?” prije brisanja automobila	Administrator 
8.	Prikaz detalja pojedinog automobile 	Anonimni korisnik 
9.	Početna stranica dolaska na aplikaciju mora sadržavati osnovne informacije o svrsi aplikacije	Anonimni korisnik 






2.5	Slučajevi (scenariji) korištenja (use-case dijagrami) 
Sljedeći slučajevi korištenja opisuju scenarije u kojima korisnici web aplikacije koriste predloženu aplikaciju za upravljanje automobilima. U tim slučajevima korištenja su uključene osnovne operacije, stoga ih ne treba smatrati konačnim. Kako napreduje razvoj dodatna funkcionalnost može biti dodana prema odluci SCRUM mastera.

2.5.1. Slučaj korištenja 1: Pregled automobila	
Kada posjetitelj stranice pregledava Automobile koji se nalaze u web aplikaciji, odvijaju se sljedeći koraci:
1.	Posjetitelj dolazi na početnu stranicu web mjesta kao anonimni korisnik ili klikne na link Početna stranica u izborniku ako se nalazio na drugoj stranici na istom web mjestu.
2.	Početna stranica prikazuje osnovni opis web aplikacije i sadrži gumbe za prikaz, pretraživanje i dodavanje novih automobila. 
3.	Prikaz osnovnih informacija o razvojnom timu moguće je dobiti putem stranica O meni.
4.	Ako anonimni korisnik želi vidjeti sve Automobile u bazi, mora kliknuti na link Popis automobila u glavnom izborniku.
5.	Web aplikacija prikazuje popis automobila. Za svaki Automobil se prikazuje Naziv automobila, Godina proizvodnje automobila, Model te Cijena.
6.	Ako anonimni korisnik želi pretraživati Automobile u bazi po Modelu i Nazivu, mora kliknuti na link Tražilica automobila u glavnom izborniku.
2.5.2.	Slučaj korištenja 2: Dodavanje novog Automobila
Svi korisnici trebaju moći dodati novi Automobil. Kada korisnik dodaje novi Automobil, sljedeći koraci se odvijaju:
1.	Korisnik klikne na gumb Unos na Početnoj stranici ili na link Novi automobil na stranicama Popis automobila ili Tražilica automobila.
2.	Korisnik upisuje podatke o novom Automobilu.
3.	Korisnik klikne na gumb Spremi.
4.	Ako su upisani podaci ispravni, web aplikacija sprema Automobil u bazu i vraća korisnika na stranicu Popis automobila.

2.5.3.	 Slučaj korištenja 3: Uređivanje automobila

Kada korisnik uređuje Automobil, sljedeći koraci se odvijaju:
1.	Korisnik klikne na link Uredi u popisu automobila na stranicama Popis automobila ili  Tražilica automobila.
2.	Korisnik mijenja postojeće podatke o automobilu.
3.	Korisnik klikne gumb Spremi promjene.
4.	Ako su upisani podaci točni, web aplikacija sprema promjene u bazi i prikazuje stranicu za Popis automobila.

2.5.4.	Slučaj korištenja 4: Brisanje Automobila
Kad korisnik briše Automobile iz baze podataka web aplikacije, sljedeći koraci se odvijaju:

1.	Korisnik klikne na link Obriši u popisu automobila na stranicama Popis automobila ili  Tražilica automobila.
2.	Web aplikacija zahtijeva potvrdu o brisanju automobila.
3.	Ako korisnik potvrđuje brisanje, Automobil je uklonjen iz baze.
4.	Web aplikacija prikazuje stranicu Popis automobila.

 ![image](https://github.com/ZovkicAnita/WebAppAutomobili/assets/135700572/b37a5e3b-1174-4a38-8255-cf593735805d)
Slika 1: Dijagram slučajeva korištenja



2.6.	Dijagrami klasa 
Klasa Automobil je potrebna kako bi se u aplikaciji evidentirali matični podaci za svaki automobil. Svojstva koja opisuju neki automobil su: ID (identifikator automobila), Name (naziv automobila, tekstualni podatak), Model (model, tekstualni podatak), Price (cijena, decimalni broj), ReleaseYear (godina izdavanja, integer). 
Kako bi se podaci o automobilima mogli spremiti u bazu podataka, potrebno je napraviti klasu AppDBContext koja koristi klasu Automobil kao model za izradu tablice u bazi pomoću Entity frameworka pa zbog toga i nasljeđuje klasu DbContext. Nakon toga treba pristupiti razvoju kontrolera AutomobilController koji mora naslijediti baznu klasu Controller s pripadajućim metodama za manipulaciju nad bazom.  

![image](https://github.com/ZovkicAnita/WebAppAutomobili/assets/135700572/0b770ed8-bd17-48a3-872e-3bc1711fd998)
Slika 2: Dijagram klasa









3.	Dizajn korisničkog sučelja
3.5.	Wireframe-ovi i Mockup-i

![image](https://github.com/ZovkicAnita/WebAppAutomobili/assets/135700572/4d093c01-6997-4a94-a115-6d8dc4922a3b)
Slika 3. Mockup početne stranice

Slika 3 prikazuje elemente početne stranice, odnosno prve stranice koja se učitava u internet pregledniku kada korisnik upiše link web aplikacije. Početna stranica povezana je s prvim i drugim korakom prvog slučaja korištenja. Vidljivo je da ona sadrži na vrhu horizontalnu traku izbornika, zatim ispod toga sliku, a ispod slike u tri stupca glavne operacije koje se mogu izvršiti u aplikaciji, i to putem dugmadi koje vode na posebne poglede za svaku operaciju: Prikaži, Pretraživanje i Unos.










![image](https://github.com/ZovkicAnita/WebAppAutomobili/assets/135700572/c143ea59-7485-4492-8d31-dc27afd0c5b3)







Slika 4. Mockup stranice “O meni”

Sliak 4 prikazuje elemente stranice koja sadrži informacije o razvojnom timu. Opis je pružen u prvom slučaju korištenja.











![image](https://github.com/ZovkicAnita/WebAppAutomobili/assets/135700572/78864f95-468e-4a58-8531-0a1c72ad0496)
















Slika 5. Mockup stranice s popisom automobila

Slika 5 prikazuje elemente stranice “Popis automobila”. Stranica “Popis automobila povezana je s prvim slučajem korištenja I služi za prikaz svih automobila u bazi.
Popis automobila prikazivat će se u obliku jednostavne tablice sa svim poljima o svakom automobilu, s tim da se iza svakog retka nalaze linkovi na posebne stranice  za operacije “Uredi” i “Obriši” koje se odnose na automobil u tom retku. 














![image](https://github.com/ZovkicAnita/WebAppAutomobili/assets/135700572/396dd875-f0c5-463a-b9b7-266614632e09)









Slika 6. Mockup stranice za dodavanje novog automobila

Slika 6 prikazuje elemente stranice koja se koristi za unos novog Automobila u bazi. Sva polja, prikazana kroz elemente, je potrebno ispuniti kako bi Automobil bio uspješno spremljen u bazu. Detaljan opis pružen je u drugom slučaju korištenja. Osim unosa i spremanja automobila korisnik ima prikazan i link na povratak na popis svih automobila.














![image](https://github.com/ZovkicAnita/WebAppAutomobili/assets/135700572/848d5fe3-2686-4789-935a-220137ebac3d)











Slika 7. Mockup stranice za dodavanje novog automobila

Slika 7 prikazuje elemente stranice koja se koristi za izmjene postojećeg automobila u bazi. Detaljan opis pružen je u trećem slučaju korištenja. Obrazac ima isti oblik kao i za unos novog autmobila, kako bi korisniku omogućio lakše snalaženje u aplikaciji, kao i dugme za spremanje promjena i ispod toga link na povratak na popis svih automobila.












![image](https://github.com/ZovkicAnita/WebAppAutomobili/assets/135700572/d3da8ecc-a5b4-4431-9b34-53219fadade0)














Slika 8. Mockup stranice za dodavanje novog automobile

Slika 8 prikazuje elemente stranice koja se koristi za korisnikovu potvrdu brisanja postojećeg automobila u bazi. Detaljan opis pružen je u četvrtom slučaju korištenja. Korisnik ima mogućnost brisanja ili povratka na popis svih automobila.











![image](https://github.com/ZovkicAnita/WebAppAutomobili/assets/135700572/565d7cdd-9f88-439e-8a64-a76e86017742)















Slika 9. Mockup stranice s popisom kategorija

Slika 9 prikazuje elemente stranice “Popis kategorija”. Stranica “Popis kategorija povezana je s prvim slučajem korištenja I služi za prikaz svih kategorija u bazi.
Popis kategorija prikazivat će se u obliku jednostavne tablice sa svim poljima o svakoj kategoriji, s tim da se iza svakog retka nalaze linkovi na posebne stranice  za operacije “Uredi” i “Obriši” koje se odnose na kategoriju u tom retku. 









![image](https://github.com/ZovkicAnita/WebAppAutomobili/assets/135700572/c0bcdf3a-f2e9-406c-9998-a7e680fefe08)















Slika 10. Mockup stranice za dodavanje nove kategorije

Slika 10 prikazuje elemente stranice koja se koristi za unos nove Kategorije u bazi. Sva polja, prikazana kroz elemente, je potrebno ispuniti kako bi Kategorija bila uspješno spremljena u bazu. Detaljan opis pružen je u drugom slučaju korištenja. Osim unosa i spremanja kategorije korisnik ima prikazan i link na povratak na popis svih kategorija.













![image](https://github.com/ZovkicAnita/WebAppAutomobili/assets/135700572/cf3072ad-f4f1-4075-9c54-95072ea0de29)












Slika 11. Mockup stranice za pretraživanje autombila

Slika 11 prikazuje elemente stranice “Tražilica automobila”. Stranica “Tražilica automobila” povezana je s prvim slučajem korištenja i služi za pretraživanje automobila po Modelu i Nazivu u bazi. Filter za pretraživanje po modelu je napravljen kao combo box s ponuđenim modelima iz baze, a filter po nazivu automobila je prikazan kao textbox u koji korisnik upisuje dio naziva automobila ili cijeli naziv automobila. Pretraživanje se aktivira nakon što korisnik klikne na dugme “Traži”, i tada se na istoj stranici ispod prikazuju samo oni automobili koji udovoljavaju traženim kriterijima. Filtrirani automobili se prikazuju u obliku iste tablice kao i kod popisa svih automobila.












