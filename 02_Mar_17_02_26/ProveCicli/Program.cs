using System;

class ProveCicli
{
   public static void CicloWhileBool()
   {
      bool continua = true;
      while (continua){
      Console.WriteLine("ciclo in esecuzione");
      continua = bool.Parse(Console.ReadLine());
      }
   }
   
   public static void CicloWhileCounter()
   {
      int continua2 = 0;
      while (continua2 < 10)
      {
      Console.WriteLine("Ciclo in esecuzione");
      continua2 += 1;
      Console.WriteLine(continua2);
      }
   }

   static void Main(string[] args)
{
   CicloWhileBool();
   CicloWhileCounter();
}
}