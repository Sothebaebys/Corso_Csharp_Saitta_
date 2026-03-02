//using System;
class Program
{
   public static void Main(string[] args)
   {
      //Istanziamento della classe (creazione oggetto)
      Cane mioCane = new Cane();

      //Cambio di stato dell'oggetto (Modifica delle proprietà)
      mioCane.nome = "Maya";
      mioCane.eta = 2;

      mioCane.Abbaia();
      mioCane.Descrivi();

      Cane mioCane2 = new Cane();

      mioCane2.nome="Stilo";
      mioCane2.eta = 13;

      mioCane2.Abbaia();
      mioCane2.Descrivi();


      Persona p = new Persona("Ciccio",2);

      Console.WriteLine($"{p.Nome} ha {p.Eta} anni");
      
   }

} 
