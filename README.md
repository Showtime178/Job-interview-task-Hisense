<h1>Job interview task za Hisense - Narejen po naslednjih navodilih:</h1>

Potrebno je pripraviti spletno aplikacijo, ki ima default .net MVC template, omogoča pa naj CRUD operacije za šifrant izdelkov. Znotraj iste rešitve je potrebno zagovotoviti REST enpoint, ki bo na podlagi vhodnega parametra vračal statičen response, endpoint pa bo možno testirati preko build-in swaggerja.

<h3>Uporabljene tehnologije</h3>

⦁	Aplikacija naj bo .net core MVC project, spisana v C# jeziku

⦁	Uporaba podatkovne baze ni potrebna

⦁	Frontend lahko oblikujete po svoje pri čemer lahko uporabite (ogrodje, knjižnice,..) kar želite sami. V osnovi je dovolj defaulf MVC dizajn pri čemer vključite Hisense logo (ga lahko vzamete iz glave tega dokumenta). V tem delu lahko pokažete svojo kreativnost

<h3>Struktura projekta</h3>

Pripravite 1 solution, ki naj vsebuje:

⦁	Library .net core projekt, ki bo služil za Infrastructure

⦁	MVC web .net core project, kjer bo poslovna logika aplikacije, frontend in REST endpoint

Infrastructure project naj vsebuje inmemory DB (statičen class) z naslednjimi lastnostmi:

⦁	Šifra izdelka (string)

⦁	Model izdelka (string)

⦁	Širina aparata (int)

⦁	Višina aparata (int)

⦁	Globina aparata (int)

V projektu naj bo interface IRepository za CRUD operacije ter implementacija interfaca. Inmemory objekt (statičen class) se lahko spreminja zgolj preko tega repozitorija.

<h3>REST endpoint</h3>

REST endpoint naj sprejme celo število med 1 in 7 ter vrne ime dneva v tednu pri čemer je 1 ponedeljek in 7 nedelja. Ime dneva v tednu je lahko v EN jeziku.  


<h3>SQL poizvedbe</h3>

Na Podlagi ER diagrama (ni prikazan) spišite SQL stavke, ki bodo vrnili:
⦁	Vse naslove knjig avtorja “J.K. Rowling”, ki so na zalogi v vsaj enem skladišču
⦁	Vse naslove knjig, katere ima stranka “Beli Zajec” v shopping basketu in je cena knjige večja od 52,2 EUR.
⦁	Vse knjige, ki so bile kupljene več kot 11 krat 
