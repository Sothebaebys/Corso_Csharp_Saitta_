using System;

class Iterazioni
{
   public static void CicloDoWhile()
   {
      Console.WriteLine("Do while: ");
      //bool continua = true;
      //La condizione viene valutata dopo l'esecuzione
      int numero = 1;

      do
      {
         Console.WriteLine("Ciclo in esecuzione..");
         Console.WriteLine("Valore: " + numero);
         
         numero++;
      }
      while (numero <= 5);
   }

   public static void CicloFor()
   {
      for (int i = 0; i< 10; i++)
      {
         Console.WriteLine(i);
      }
   }

   static void Main()
   {
      CicloDoWhile();

      CicloFor();
   }

}