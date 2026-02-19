using System;
using System.Security.Cryptography.X509Certificates;

//single line 
class Program
{

   /// <summary>
   /// 
   /// Sommario XML
   /// 
   /// </summary>
   /// <param name="args"></param>

   //       //Costanti :

   // C O S T A N T I
   const float PI_GRECO = 3.1415f;
   public static readonly String Nomez = "Ciccio";

   static void Main(string[] args){
   /*
      Multi line commment
      Console.WriteLine("HelloWorldsssss");
*/
      Console.WriteLine("HelloWorldsssss");


      /*     
      //DICHIARAZIONE VARIABILE, IN QUESTO CASO UN INT 
      int contatore;
      //ASSEGNAZIONE VARIABILE, IN QUESTO CASO 0
      contatore = 0;
      //DICHIARAZIONE E ASSEGNAZIONE DELLA VARIABILE 
      int somma = 10;
      // TIPO DEDOTTO DAL COMPILATORE
      var nome = "Adam"; 
      */

      //tipo di dato :

      // Integer
      int numero = 10;
      // float con viergola mobile
      float decimaleFloat = 3.14f;

      //double decimaleDouble = 3.14d;
      // carattere singolo
      char lettera = 'A';

      // bit 0 o 1 (True o False)
      bool  isCondizione = true;

      //Concatenazione di caratteri
      string saluto = "Ciao a tutti!";

      Console.WriteLine("Numero intero: " + numero);
      Console.WriteLine("Numero decimale: " + decimaleFloat);
      Console.WriteLine("Lettera char: " + lettera);
      Console.WriteLine("Condizione booleana: " + isCondizione);
      Console.WriteLine("Stringa saluto: " + saluto);



      Console.WriteLine("Valore costante pi: " +  PI_GRECO);


      Console.WriteLine("Nome costante in readonly" + Nomez );

      //    C A S T I N G

      //Casting implicito (Il metodo più sicuro, da uno slot di memoria più piccolo ad uno più grande)
      int numeroX = 3;
      float numeroXX = numeroX; //Widening

      //Casting esplicito (Può portare a eccezioni o errori, Si passa da uno slot più grande ad uno più piccolo)
      // Il contenuto verrà troncato 
      float piCaster = 3.14f;
      int piCastato = (int)piCaster; //Narrowing


      // Gestione input 
      Console.Write("Come ti chiami ?");

      string nome = Console.ReadLine();

      Console.WriteLine("Ciao" + nome);

      Console.Write("Dammi un numero, dai ");
      string numero1 = Console.ReadLine();

      Console.Write("Dammene un altro altrimenti non ci muoviamo ");
      string numero2 = Console.ReadLine();

      int numeroUno = int.Parse(numero1);
      int numeroDue = int.Parse(numero2);

      Console.WriteLine($"Somma: {numeroUno + numeroDue}");


      //O P E R A T O R I 

      //Operatori Aritmetici
      Console.WriteLine(" Operatori artimetici: \n");
      Console.WriteLine($"a = {numeroUno}, b = {numeroDue}");
      Console.WriteLine($"Addizione: a + b = {numeroUno + numeroDue}");
      Console.WriteLine($"Sottrazione: a - b = {numeroUno + numeroDue}");
      Console.WriteLine($"Moltiplicazione: a * b = {numeroUno * numeroDue}");
      Console.WriteLine($"Divisione: a / b = {numeroUno / numeroDue}");
      Console.WriteLine($"modulo (Resto): a % b = {numeroUno % numeroDue}");

      //Operatori di Assegnamento
      Console.WriteLine("\nOperatori di Assegnamento:\n");
      Console.WriteLine($"Incremento: a++ = {numeroUno ++}");
      Console.WriteLine($"Ora a = {numeroUno}");
      Console.WriteLine($"Decremento: b-- = {numeroDue ++}");
      Console.WriteLine($"Ora b = {numeroDue}");

      int a = 10;
      int b = 15;

      //Operatori Logici Comparativi
      Console.WriteLine("Operatori Logici:\n");
      Console.WriteLine($"a = {a}, b = {b}"); 
      Console.WriteLine($"AND: {a < b && a>= b}");  // True
      Console.WriteLine($"OR: {a > b || a >= 10}"); // True
      Console.WriteLine($"NOT: {!(a < b)}");        // False

   }
}



/*
Variabili

   {
      
      //DICHIARAZIONE VARIABILE, IN QUESTO CASO UN INT 
      int contatore;
      //ASSEGNAZIONE VARIABILE, IN QUESTO CASO 0
      contatore = 0;
      //DICHIARAZIONE E ASSEGNAZIONE DELLA VARIABILE 
      int somma = 10;
      // TIPO DEDOTTO DAL COMPILATORE
      var nome = "Adam"; 

   }

*/