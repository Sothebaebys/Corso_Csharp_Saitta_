class Program
{
   /*public static List<Film> listaFilm = new List<Film>();
   public void RicercaGenere(string genere)
   {
      foreach (Film item in listaFilm)
      {
         if (item.genere == genere)
         {
            Console.WriteLine($"{item.ToString()}");
         }
      }
   }
   */
   public static void Main(string[] args)
   {
      List<Film> listaFilm = new List<Film>();

      bool isGoing = true;
      bool isSearching = true;


      while (isGoing)
      {
         Console.WriteLine($"Vuoi inserire dei titoli nella videoteca? (Y/N)");
         string risposta = Console.ReadLine();

         if (risposta.ToLower() == "y")
         {
            Console.WriteLine($"Inserisci il titolo del film:");
            string titolo = Console.ReadLine();

            Console.WriteLine($"Inserisci il nome del regista:");
            string regista = Console.ReadLine();
            
            Console.WriteLine($"Inserisci l'anno di pubblicazione del film:");
            int anno= int.Parse(Console.ReadLine());

            Console.WriteLine($"Inserisci il genere del film:");
            string genere = Console.ReadLine();

            Film film = new Film(titolo,regista,anno,genere); 
            
            listaFilm.Add(film);
         }
         else
         {
            isGoing = false;
         }
         
      }

      Console.WriteLine($"Lista aggiornata dei film in videoteca:");
      foreach (Film film in listaFilm)
      {
         Console.WriteLine($"{film.ToString()}");
         
      }
   
      Console.WriteLine($"Vuoi fare una ricerca per genere? (Y/N)");
      string scelta = Console.ReadLine();
      if (scelta.ToLower() == "y")
      {
         while (isSearching)
         {
            Console.WriteLine($"Inserisci il genere da cercare:");
            string ricercaGenere = Console.ReadLine();

            foreach (Film item in listaFilm)
            {
            if (item.genere == ricercaGenere)
            {
               Console.WriteLine($"{item.ToString()}");
            }
            }

            Console.WriteLine($"Vuoi cercare altro?");
            string altro = Console.ReadLine();
         
            if (altro.ToLower() != "y")
            {
               isSearching = false;
            }
         }
      }
      
   }
}
