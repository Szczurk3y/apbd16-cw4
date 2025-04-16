Maciej Stoiński s24196 apbd-cw4
<br>url = http://localhost:5222
<br/>Example Usage with Postman:
<br>Animals:
<ol>
<li> Pobieranie listy zwierząt: <br>
    GET url/api/animals/
</li>
<li> Pobierania danych konkretnego zwierzęcia po id: <br>
    GET url/api/animals/1 <br>
</li>
<li> Dodawanie zwierzęcia: <br>
POST url/api/animals/ <br>
Body/raw->paste and decode token below <br>
%7B%0D%0A%20%20%20%20%22id%22%3A%20101%2C%0D%0A%20%20%20%20%22name%22%3A%20%22Test%20kot%20100%22%2C%0D%0A%20%20%20%20%22category%22%3A%20%22CAT%22%2C%0D%0A%20%20%20%20%22weight%22%3A%20100%2C%0D%0A%20%20%20%20%22color%22%3A%20%22Red%22%0D%0A%7D<br>
<br>
</li>
<li> Edycja danych zwierzęcia: <br>
PUT url/api/animals/ <br>
Body/raw->paste and decode token below <br>
%7B%0D%0A%20%20%20%20%22id%22%3A%20100%2C%0D%0A%20%20%20%20%22name%22%3A%20%22Test%20kot%20100%22%2C%0D%0A%20%20%20%20%22category%22%3A%20%22CAT%22%2C%0D%0A%20%20%20%20%22weight%22%3A%2020%2C%0D%0A%20%20%20%20%22color%22%3A%20%22Brown%22%0D%0A%7D<br>
</li>
<li> Usuwanie zwierzęcia: <br>
DELETE url/api/animals/100
</li>
<li> Wyszukiwanie wszystkich zwierząt na podstawie imienia: <br>
GET url/api/animals/getbyname/Test kot
</li>
</ol>
Schedules:
<ol>
<li> Pobranie listy wizyt powiązanych z danym zwierzęciem: <br>
GET url/api/schedules/animal/1
</li>
<li> Dodanie nowych wizyt: <br>
POST url/api/schedules/ <br>
Body/raw->paste and decode token below <br>
%7B%0D%0A%20%20%20%20%22date%22%3A%20%2215.04.2025%22%2C%0D%0A%20%20%20%20%22animalId%22%3A%201%2C%0D%0A%20%20%20%20%22description%22%3A%20%22Test%20dodanie%20wizyty%22%2C%0D%0A%20%20%20%20%22price%22%3A%2023.45%0D%0A%7D<br>
</li>
</ol>