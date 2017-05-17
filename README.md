# eBolnica™ - *"Pacijent na prvom mjestu"*

### Tim1-HDD su:

  1. Dejan Aćimović
  2. Damir Bojadžić
  3. Hanna Bojadžić
  
#### Opis teme:

eBolnica™ je aplikacija čiji primarni zadatak je upravljati, olakšati i rastetetiti rad bolnice i njenih uposlenika. Sistem će u sebi sadržavati profil pacijenta na kom će biti pohranjene sve informacije bitne doktorima kao što su prošla i trenutna oboljenja, terapije, alergije i druge informacije kao što su dijagnoze i rezultati testiranja. Ovo je naročito bitno jer će dati svim doktorima detaljan i pregledan uvid u stanje pacijenta, čim direktno izbjegavamo mogućnost nesporazuma ili gubljenja nalaza. Doktor će biti u stanju da na profilu pacijenta registruje pregled što podrazumijeva zapisivanje nalaza pretrage te uključivanje terapije i slanja na dalje pretrage. Sistem nakon toga, ovisno od pregleda doktora, sam zakazuje novi termin pregleda. Primjera radi, ukoliko doktor pošalje pacijenta na MRI i EEG, sistem sam stavlja pacijenta u red čekanja i zadaje vrijeme pregleda. Naravno vrijeme pregleda je podložno promjenama te će pacijent dobiti notifikaciju ako dođe do promjene. Ukoliko je pacijent spriječen da dođe na termin moći će otkazati, ali time gubi svoju poziciju u redu. Doktor će imati privilegiju da označi neki pregled kao 'URGENT', te će pacijent imati najveći prioritet i bit će primljen što je prije moguće. Prilikom uključenja terapije, apotekar može da vidi samo informacije bitne njemu, tj. vidi koje lijekove i u kojoj dozi treba dati pacijentu. Nakon toga checkira datum i vrijeme podizanja lijekova, te se šalje izvještaj osiguravajućoj kući.


#### Procesi:

  * **Registracija pacijenata** - Prilikom registracije svakom pacijentu se dodjeljuje jedinstveni kod koji će biti korišten za identifikaciju pacijenta, te pregled njegovog profila.
  
  * **Registracija doktora** - Svaki doktor prilikom registracije dobija svoj timetable gdje vidi naručene pacijente za taj dan te privilegije modifikovanja profila svojih pacijenata koji su na pregledu.

  * **Raspoređivanje** - Pacijent može da zahtijeva termin za pregled kod doktora. Sistem pacijentu određuje vrijeme kada će da dođe ovisno o trenutnom prometu. Ovo se može zamisliti kao virtuelna kartoteka čime će se izbjeći i regulisati ogromne gužve u bolnicama. Doktor koji je u smjeni ima pristup svoj rasporedu gdje mu sistem prikazuje pacijente koji su u redu čekanja. Pored ovog raspoređivanja sistem vrši raspoređivanje i u slučaju kada doktor vrši pregled i šalje pacijenta na pretrage. Ovisno o vrsti pretraga i potrebama pacijenta, sistem rezerviše prostor u rasporedu za pacijenta vodeći računa o tome da se dva termina ne preklope. Prilikom slanja pacijenta na pretrage doktor može da utiče na prioritet pretraga, a sistem ovisno o prioritetu treba da kreira prostor za pacijenta.
  
  * **Terapije** - Ukoliko doktor pacijentu uključi neku terapiju i propiše lijekove, stanje pacijenta će se automatski ažuritati, te će u apoteci moći da podigne lijekove bez problema. Apotekar će imati pristup profilu pacijenta, ali samo toliko da označi da su lijekovi podignuti, čime se šalje izvještaj osiguravajućoj kući. Aplikacija će imati mogućnost slanja notifikacije pacijentu da je vrijeme uzimanja lijekova po propisu doktora.
  
  

#### Funkcionalnosti:
  * Mogućnost registracije pacijenata 
  * Mogućnost registracije uposlenika
  * Mogućnost izvještaja o rođenju
  * Mogućnost izvještaja o smrti pacijenta
  * Mogućnost izvještaja o pregledu
  * Mogućnost izdavanja uputnica
  * Mogućnost propisivanja lijekova
  * Mogućnost izdavanja uputnica za ležanje u bolnici
  * Mogućnost odabira doktora
  * Mogućnost obavljanja pregleda sa uputnicom
  * Mogućnost obavljanja pregleda bez uputnice
  * Mogućnost obavljanja testova
  * Mogućnost izvještaja o obavljenim testovima
  * Mogućnost zakazivanja pregleda
  * Mogućnost prijave na posao
  * Mogućnost odjave sa posla
  * Mogućnost identifikacije pacijenta na osnovu jedinstvenog koda
  * Mogućnost podizanja lijekova uz verifikaciju i validaciju lijekova
  * Mogućnost dobavljača za direktan pristup listi potrebnih lijekova/materijala za nabavku


#### Akteri:

  * **Menadžer** - registruje uposlenike
  * **Uposlenik** - vrši prijavu i odjavu sa posla
  * **Medicinska sestra** - registruje pacijente, vrši laboratorijske pretrage
  * **Doktor** - obavlja pregled sa pacijentom, daje izvještaj o rođenju i smrti pacijenata, te daje izvještaj pregleda što uključuje      propisivanje lijekova, izdavanje uputnice za dalje testove i izdavanje uputnice za ležanje u bolnici
  * **Pacijent** - posjećuje bolnicu gdje moze obaviti pregled sa ili bez uputnice, odabrati doktora ili se prijaviti za ležanje, pacijent također zakazuje svoje preglede, podiže lijekove, te posjećuje laboratoriju gdje obavlja testove i dobija njihove rezultate
  * **Dobavljač lijekova** - registruje dostavljenu robu. Pristupa listi potrebnih materijala za bolnicu.
  * **Apotekar** - izdaje lijekove
  * **Admin** - ima pristup i privilegiju promjene svih podataka o pacijentima i uposlenicima
  
