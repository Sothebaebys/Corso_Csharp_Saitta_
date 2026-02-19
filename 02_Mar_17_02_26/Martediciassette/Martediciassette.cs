using System;

class PrimiEsercizi
{
   //Dichiaro il prezzo di sconto come costante
   const int sconto = 20;

   //Primo esercizio
   public static void SommaNumeri()
   {
      // Prendo il primo valore in input
      Console.Write("Inserisci un numero intero");
      // Assegno il valore
      //string primoInput = Console.ReadLine();
      int primoNumero = int.Parse(Console.ReadLine());

      Console.Write("Inserisci un secondo numero intero");
      int secondoNumero = int.Parse(Console.ReadLine());

      Console.WriteLine($"La somma dei numeri {primoNumero} e {secondoNumero} è {primoNumero + secondoNumero}");
   }

   //Secondo esercizio
   public static void PrezzoScontato()
   {
      //Prendo il valore double in input
      Console.Write ("Inserisci il prezzo originale dell'articolo");
      //Assegno il valore
      double prezzo = Double.Parse(Console.ReadLine());

      //int sconto = 20;

      Console.WriteLine($"Il prezzo scontato del prodotto è {(prezzo * sconto)/100}");
   }

   //Terzo esercizio
   public static void NumeroPositivo()
   {
      //Prendo il valore float in input
      Console.Write("Inserisci il valore numerico: ");
      //Assegno il valore
      float numero =float.Parse(Console.ReadLine());

      Console.WriteLine($"Il numero è positivo ? {numero>=0}");
   }

   public static void SommaFloatToInt()
   {
      // Prendo il primo valore in input
      Console.Write("Inserisci un numero intero: ");
      // Assegno il valore
      int primoInput = int.Parse(Console.ReadLine());
      //int primoNumero = int.Parse(primoInput);

      Console.Write("Inserisci un secondo numero float: ");
      float secondoNumero = float.Parse(Console.ReadLine());

      int somma = primoInput + (int)secondoNumero;
      Console.WriteLine($"La somma dei numeri {primoInput} e {secondoNumero} è {somma}");
   }

   public static void AltezzaPeso()
   {
      // Prendo il primo valore in input
      Console.Write("Inserisci il peso: ");
      // Assegno il valore
      //string primoInput = Console.ReadLine();
      int primoNumero = int.Parse(Console.ReadLine());

      Console.Write("Inserisci la tua altezza: ");
      float secondoNumero = float.Parse(Console.ReadLine());

      int somma = primoNumero + (int)secondoNumero;
      Console.WriteLine($"La somma di peso {primoNumero} e altezza {secondoNumero} è {somma}");
   }

   public static void OperatoriLogici()
   {
      Console.Write("Inserisci il valore numerico: ");
      int inputUno = int.Parse(Console.ReadLine());

      Console.Write("Inserisci il valore numerico: ");
      int inputDue = int.Parse(Console.ReadLine());

      Console.WriteLine($"operatore and: {inputUno} > {inputDue}  e {inputUno} != {inputDue}? {inputUno > inputDue && inputUno != inputDue}");
      Console.WriteLine($"operatore or: {inputUno} > {inputDue} o {inputUno} < {inputDue} ? {inputUno > inputDue || inputUno < inputDue}");
      Console.WriteLine($"operatore not: {inputUno} non è > di {inputDue} ? {!(inputUno > inputDue)}");
   }
   static void Main(string[] args)
   {
      //Eseguiamo le funzioni nel main

      Console.WriteLine("Operatori logici:");
      OperatoriLogici();

      Console.WriteLine("Somma float to int:");
      SommaFloatToInt();
      
      Console.WriteLine("Altezza più peso:");
      AltezzaPeso();

      Console.WriteLine("Somma numeri:");
      SommaNumeri();

      Console.WriteLine("Prezzo scontato:");
      PrezzoScontato();

      Console.WriteLine("Numero positivo:");
      NumeroPositivo();
   }
}
