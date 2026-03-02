// Dichiarazione semplice 
Dictionary <string,string> studenti = new Dictionary<string, string>()
{
   {"0lapa","Pluto"},
   {"0lapa1","Paperino"}
};

//Aggiungere elemento
studenti.Add("0lapa6","Ciccio");

//Modificare il valore
studenti["alalal"] = "Franco";

Console.WriteLine($"{studenti["alalal"]}");

//Check sulla presenza del campo, bool
studenti.ContainsKey("alalal");//True
studenti.ContainsValue("Franco");//True
studenti.ContainsValue("Farfalla");//False

Console.WriteLine($"Il valore associato alla chiave (alalal) esiste? {studenti.ContainsKey("alalal")}");
Console.WriteLine($"La chiave associata alla chiave (alalal) esiste? {studenti.ContainsValue("alalal")}");


//Rimozione dell'elemento
studenti.Remove("alalal");

//Iterare tra i valori
foreach (var stud in studenti)
{
   Console.WriteLine($"matricola {stud.Key}, studente {stud.Value}");
}

//Accedere al chiave valore tramite indice
Console.WriteLine($"Indice 1: [chiave, valore] {studenti.ElementAt(1)}");

//Ritorna l'ultimo elemento
studenti.Last();
//Ritorna il primo elemento
studenti.First();