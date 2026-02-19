using System;

class EsercizoComplessivo
{
   /*
   //readonly string USERNAME = "";
   //readonly string PASSWORD ; 
   public static void RegistraUtente()
   {
      Console.WriteLine("Iniziamo la registrazione!");
      Console.Write("Inserisci il nome: ");
      string nomeReg = Console.ReadLine();
      Console.Write("Inserisci una password: ");
      string passwordReg = Console.ReadLine();
      Console.WriteLine($"Perfetto {nomeReg}, abbiamo impostato la password.");

   }
   public static void LogIn()
   {
      Console.WriteLine("Per accedere dovrai inserire nome e password:");
      Console.Write("Inserisci il nome: ");
      string nomeLog = Console.ReadLine();
      Console.Write("Inserisci una password: ");
      string passwordLog = Console.ReadLine();
   }

   public static void Countdown()
   {
      Console.WriteLine("Adesso un conto alla rovescia..\nInserisci un numero intero positivo:");
      int counter = int.Parse(Console.ReadLine());
      
      if (counter > 0)
      {
         for(int i = counter; i>=0; i--)
         {
            Console.WriteLine($" - {i}...");
         }
      }
      Console.WriteLine("BOOOM!");
   }
*/
   public static void Eserciccio()
   {  
      string nomeReg="";
      string passwordReg="";
      bool isRegistrd = false;
      bool isLogged = false;
      bool isActive = true;
      do
      {   
      Console.WriteLine("\n\nSeleziona la tipologia di attività tra le seguenti:\n - registra\n - login\n - countdown\n - esci");
      string scelta = Console.ReadLine();

      switch (scelta)
      {
         case "registra":
            if(!isRegistrd)
            {
            Console.WriteLine("Iniziamo la registrazione!");
            Console.Write("Inserisci il nome: ");
            nomeReg = Console.ReadLine();
            Console.Write("Inserisci una password: ");
            passwordReg = Console.ReadLine();
            Console.WriteLine($"Perfetto {nomeReg}, abbiamo impostato la password e username.");
            isRegistrd = true;
            }
            break;
         
         case "login":
            if (isRegistrd)
            {
               Console.WriteLine("Per accedere dovrai inserire nome e password:");
               Console.Write("Inserisci il nome: ");
               string nomeLog = Console.ReadLine();
               Console.Write("Inserisci una password: ");
               string passwordLog = Console.ReadLine();
               // Aggiungere il check sulla coerenza dei dati inseriti
               if (nomeLog == nomeReg && passwordLog == passwordReg)
               {
                  isLogged = true;
                  Console.WriteLine("Accesso effettuato!");
               }
               else if(nomeLog != nomeReg || passwordLog != passwordReg)
               {
                  Console.WriteLine("Nome utente o password errati!");
               }
            }
            else
               {
                  Console.WriteLine("Devi prima registrarti!");
               }
            break;
            
         case "countdown":
            if (isLogged)
            {
               Console.WriteLine("Adesso un conto alla rovescia..\nInserisci un numero intero positivo:");
               int counter = int.Parse(Console.ReadLine());

               if (counter > 0)
               {
                  for(int i = counter; i>=0; i--)
                  {
                     Console.WriteLine($" - {i}...");
                  }
               }
               Console.WriteLine("BOOOM!");
            }
            else
            {
               Console.WriteLine("Devi prima accedere..");
            }
            break;

         case "esci":
            isActive = false;
            break;
         
         default:
            Console.WriteLine("Scelta non valida..");
            break;
      }
   }
   while(isActive);
   }   
   
   
   static void Main(string[] args)
   {
      Eserciccio();
   }

}
