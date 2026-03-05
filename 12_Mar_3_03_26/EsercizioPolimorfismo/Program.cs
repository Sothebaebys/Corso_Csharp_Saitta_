class Program
{
   public static void Main(string[] args)
   {
      List<Veicolo> listaVeicoli = new List<Veicolo>();

      const int N_ITER = 3;

      for (var i = 0; i < N_ITER; i++)
      {
         Console.WriteLine($"Inserisci la targa:");
         string targa = Console.ReadLine();
         Console.WriteLine($"Inserisci il tipo tra:\n-1 auto\n-2 moto\n-3 camion");
         string scelta = Console.ReadLine();
         switch (scelta)
         {
            case ("1"):
               listaVeicoli.Add(new Auto(targa));
               break;

            case ("2"):
               listaVeicoli.Add(new Moto(targa));
               break;

            case ("3"):
               listaVeicoli.Add(new Camion(targa));
               break;
                                          
            default:
               Console.WriteLine($"Scelta non valida..");
               break;
         }
         
         
      }

      foreach (Veicolo item in listaVeicoli)
      {
         //Console.WriteLine($"Targa mezzo: {item.Targa}");
         item.Ripara();
      }
   }

}