# Hardware-Shop-Testing
Projektni zadatak iz kolegija Metode i tehnike testiranja programske podrške

Korišten je Katalon Recorder extension za web browsere.
Testovi su pisani u C# na NUnit frameworku.

Testiran je Web shop napravljen u php-u koji se nalazi na gitu: https://github.com/LG64BIT/WebShop.git

KORACI ZA KORIŠTENJE:
    1. Povući lokalno webshop za testiranje: https://github.com/LG64BIT/WebShop.git<br>
    2. Postaviti localhost za webshop (najjednostavnije preko Xampp-a, te u htdocs folder staviti projekt).<br>
    3. U phpMyAdmin importati bazu "shop.sql" koja se također nalazi u repo-u projekta.<br>
    4. Pokrenuti localhost na portu 80.<br>
    5. Pokrenuti testove.<br>

Ukoliko se testovi pokreću više puta, neće biti očekivani rezultati pošto izmjenjuju stanje baze.
Poželjno je revertati bazu na početno stanje prilikom svakog pokretanja testa (ili ručno brisati dodane korisnike).
