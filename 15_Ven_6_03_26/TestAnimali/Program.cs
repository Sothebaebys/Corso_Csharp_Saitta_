
using System.Security.Cryptography.X509Certificates;

public class Program
{
      public static void Menu()
   {
      Console.WriteLine($"Benvenuto\n seleziona l'azione.\nPremi: ");
      Console.WriteLine($"-1 Per aggiungere un animale.");
      Console.WriteLine($"-2 Vedi le informazioni degli animali presenti");
      Console.WriteLine($"-3 Per conoscere il verso di ogni animale.");
      Console.WriteLine($"-0 Per uscire.");

   }
   public static void Main(string[] args)
   {
      List<Animale> listAnimali = new List<Animale>()
      {
      new Mucca("Carolina",3),
      new Gallina("Rosita",15)
      };

      string nome;
      int eta;
      int tipoAnim;
      Console.WriteLine($"Benvenuto nella fattoria");

      bool isAttivo = true;

      while (isAttivo)
      {
         Menu();
         int scelta = int.Parse(Console.ReadLine());

         switch (scelta)
         {
            case (1):
               Console.WriteLine($"scegli il tipo di animale tra:\n1. pecora\n2. gallina\n3. mucca\n4. maiale");
               tipoAnim = int.Parse(Console.ReadLine());
               //TipoAnimale anim =Enum.Parse<TipoAnimale>(Console.ReadLine(), true);
               Console.WriteLine($"Inserisci il nome della creatura:");
               nome = Console.ReadLine();
               Console.WriteLine($"Inserisci l'età della creatura:");
               eta = int.Parse(Console.ReadLine());
               switch (tipoAnim)
               {
                  //pecora
                  case (1):
                     listAnimali.Add( new Pecora(nome, eta) );
                     break;
                  //gallina
                  case (2):
                     listAnimali.Add( new Gallina(nome, eta) );
                     break;
                  //mucca
                  case (3):
                     listAnimali.Add( new Mucca(nome, eta) );
                     break;
                  //Maiale
                  case (4):
                     listAnimali.Add( new Maiale(nome, eta) );
                     break;

                  default:
                  Console.WriteLine($"Tipo non valido");
                  
                     break;
               }               
               break;
            //mostra le info
            case (2):
               foreach (Animale item in listAnimali)
               {
                  item.Info();
               }
               break;
            //mostra il verso degli animali
            case (3):
               foreach (Animale item in listAnimali)
               {
                  item.Verso();
               }
               break;
            //Esce
            case (0):
               Console.WriteLine($"Adiosss");
               isAttivo = false;
               break;
            default:
               Console.WriteLine($"Scelta non valida");
               
               break;
         }
         
      }
      
   }
}