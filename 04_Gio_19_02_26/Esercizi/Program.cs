using System;

class NomeClasse
{

   // Primo esercizio
   private static void StampaSaluto(string nome)
   {
      Console.WriteLine($"Ciao {nome}!!");
   } 

   //Secondo esercizio
   public static void VerificaPari(int numero)
   {
      if ((numero % 2) == 0)
      {
         Console.WriteLine($"Il numero {numero} è pari");
      }
      else
      {
         Console.WriteLine($"Il numero {numero} è dispari");
      }
   }

   //Terzo esercizio
   private static int CalcoloPotenza(int baseNum, int esponente)
   {
      int potenza = baseNum;

      if(baseNum != 0 && esponente >1)
      {
         for(int i = 1; i< esponente; i++)
         //for(int i = (esponente-1); i> 0; i--)
         {
            potenza *= baseNum;
         }
         return potenza;
      }
      else
      {
         return baseNum;
      }
      
   }


   // Main
   static void Main(string [] args)
   {
      StampaSaluto("Ciccio");
      StampaSaluto("Fracchia");

      VerificaPari(7);
      VerificaPari(88);
      VerificaPari(15);

      Console.WriteLine($"2 elevato alla quinta dovrebbe corrispondere a : {CalcoloPotenza(2,5)}");
      Console.WriteLine($"3 elevato alla terza dovrebbe corrispondere a :{CalcoloPotenza(3,3)}");


   }

}