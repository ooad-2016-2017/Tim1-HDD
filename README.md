# eBolnica - *"Pacijent na prvom mjestu"*

### Tim1-HDD su:

  1. Dejan Acimovic
  2. Damir Bojadzic
  3. Hanna Bojadzic
  
#### Opis teme:

eBolnica je aplikacija čiji primarni zadatak je upravljati, olakšati i rastetetiti rad bolnice i njenih uposlenika. Sistem će u sebi sadržavati profil pacijenta na kom će biti pohranjene sve informacije bitne doktorima kao što su prošla i trenutna oboljenja, terapije, alergije i druge informacije kao što su dijagnoze i rezultati testiranja. Ovo je naročito bitno jer će dati svim doktorima detaljan i pregledan uvid u stanje pacijenta, čim direktno izbjegavamo mogućnost nesporazuma ili gubljenja nalaza. Doktor će biti u stanju da na profilu pacijenta registruje pregled što podrazumijeva zapisivanje nalaza pretrage te uključivanje terapije i slanja na dalje pretrage. Sistem nakon toga, ovisno od pregleda doktora, sam zakazuje novi termin pregleda. Primjera radi, ukoliko doktor pošalje pacijenta na MRI i EEG, sistem sam stavlja pacijenta u red čekanja i zadaje vrijeme pregleda. Naravno vrijeme pregleda je podložno promjenama te će pacijent dobiti notifikaciju ako dođe do promjene. Ukoliko je pacijent spriječen da dođe na termin moći će otkazati, ali time gubi svoju poziciju u redu. Doktor će imati privilegiju da označi neki pregled kao 'URGENT', te će pacijent imati najveći prioritet i bit će primljen što je prije moguće. Prilikom uključenja terapije, apotekar može da vidi samo informacije bitne njemu, tj. vidi koje lijekove i u kojoj dozi treba dati pacijentu. Nakon toga checkira datum i vrijeme podizanja lijekova, te se šalje izvještaj osiguravajućoj kući.

#### Procesi:

  * Registracija pacijenata - Prilikom registracije svakom pacijentu se dodjeljuje jedinstveni kod koji će biti korišten za identifikaciju pacijenta, te pregled njegovog profila.
  
  * Registracija doktora - Svaki doktor prilikom registracije dobija svoj timetable gdje vidi naručene pacijente za taj dan te privilegije modifikovanja profila svojih pacijenata koji su na pregledu.

  * Raspoređivanje I - Pacijent može da zahtijeva termin za pregled kod doktora. Sistem pacijentu određuje vrijeme kada će da dođe ovisno o trenutnom prometu. Ovo se može zamisliti kao virtuelna kartoteka čime će se izbjeći i regulisati ogromne gužve u bolnicama. Doktor koji je u smjeni ima pristup svoj rasporedu gdje mu sistem prikazuje pacijente koji su u redu čekanja.

  * Raspoređivanje II - Doktor vrši pregled i šalje pacijenta na pretrage. Ovisno o vrsti pretraga i potrebama pacijenta, sistem rezerviše prostor u rasporedu za pacijenta vodeći računa o tome da se dva termina ne preklope. Prilikom slanja pacijenta na pretrage doktor može da utiče na prioritet pretraga, a sistem ovisno o prioritetu treba da kreira prostor za pacijenta.
  
  * Terapije - Ukoliko doktor pacijentu uključi neku terapiju i propiše lijekove, stanje pacijenta će se automatski ažuritati, te će u apoteci moći da podigne lijekove bez problema. Apotekar će imati pristup profilu pacijenta, ali samo toliko da označi da su lijekovi podignuti, čime se šalje izvještaj osiguravajućoj kući. Aplikacija će imati mogućnost slanja notifikacije pacijentu da je vrijeme uzimanja lijekova po propisu doktora.
  
  

#### Funkcionalnosti:
  * Mogucnost registracije pacijenata
  * Mogucnost registracije uposlenika
  * Mogucnost izvjestaja o rodjenju
  * Mogucnost izvjestaja o smrti pacijenta
  * Mogucnost izvjestaja o pregledu
  * Mogucnost izdavanja uputnica
  * Mogucnost propisivanja lijekova
  * Mogucnost izdavanja uputnica za lezanje u bolnici
  * Mogucnost odabira doktora
  * Mogucnost obavljanja pregleda sa uputnicom
  * Mogucnost obavljanja pregleda bez uputnice
  * Mogucnost obavljanja testova
  * Mogucnost izvjestaja o obavljenim testovima
  * Mogucnost zakazivanja pregleda
  * Mogucnost prijave na posao
  * Mogucnost odjave sa posla
  * Mogućnost identifikacije pacijenta na osnovu jedinstvenog koda
  * Mogućnost podizanja lijekova uz verifikaciju i validaciju lijekova


#### Akteri:

  * Menadzer - registruje uposlenike
  * Uposlenik - vrsi prijavu i odjavu sa posla
  * Medicinska sestra - registruje pacijente
  * Doktor - obavlja pregled sa pacijentom, daje izvjestaj o rodjenju i smrti pacijenata, te daje izvjestaj pregleda sto ukljucuje      propisivanje lijekova, izdavanje uputnice za dalje testove i izdavanje uputnice za lezanje u bolnici
  * Pacijent - posjecuje bolnicu gdje moze obaviti pregled sa ili bez uputnice, odabrati doktora ili se prijaviti za lezanje, pacijent takodjer zakazuje svoje preglede, podize lijekove, te posjecuje laboratoriju gdje obavlja testove i dobija njihove rezeultate
  * Dobavljac lijekova - registruje dostavljenu robu
  * Apotekar - izdaje lijekove
  * Admin - ima pristup i privilegiju promjene svih podataka o pacijentima i uposlenicima
  
  

#### To do list:
- [ ] Napisati opis teme, indentificirati i opisati procese u sistemu, navesti funkcionalnosti sistema, identificirati aktere u sistemu.
- [ ] Na osnovu tačke 1 dizajnirati Use Case dijagram koji će pokriti sve navedeno u tački 1.
- [ ] Napisati scenarij i tok događaja za use case navedenim u tački 2.
- [X] Kreirati blank windows universal projekat i uraditi commit na github
- [ ] Kreirati prototip koristeći neki od alata za skiciranje prototipa aplikacije
- [ ] ...
- [ ] PROFIT!
