public abstract class Corso
{
   private string _titolo;

   private int _durataOre;
   
   public string titolo
   {
      get{return _titolo;}
      set
      {
         _titolo = value;
      }
   }
   
   public int durataOre
   {
      get
      {
         return _durataOre;
      }
      set
      {
         if (value >= 1)
         {
            _durataOre = value;
         }
         else
         {
            _durataOre = 1;
         }
      }
   }
   
   public Corso(string titolo, int durataOre)
   {
      this.titolo =  titolo;
      this.durataOre = durataOre;
   }

   public abstract void ErogaCorso();

   public abstract void StampaDettagli();

}

public class CorsoPresenza : Corso
{
   //aula numeroPosti
   private string _aula;
   private int _numeroPosti;

   public string aula
   {
      get{ return _aula;}
      set{ if (!string.IsNullOrEmpty(value))
         {
            _aula = value.ToLower();
         }
         else{ _aula = "magna";}
      }
   }

   public int numeroPosti
   {
      get {return _numeroPosti;}
      set
      {
         if(value > 0)
         {
            _numeroPosti = value;
         }
         else
         {
            _numeroPosti = 1;
         }
      }
   }
   //ErogaCorso StampaDettagli

   public CorsoPresenza (string titolo, int durataOre, string aula, int numeroPosti) : base (titolo, durataOre)
   {
      this.aula = aula;
      this.numeroPosti = numeroPosti;
   }
   public override void ErogaCorso()
   {
      Console.WriteLine($"Corso in presenza di {titolo} erogato correttamente.");
   }

   public override void StampaDettagli()
   {
      Console.WriteLine($"Il corso di ({titolo}) si terrà in presenza, nell'aula {aula} ed avrà una durata di {durataOre}h.");
      Console.WriteLine($"Il corso è predisposto per {numeroPosti} studenti.");
      
   }
}

public class CorsoOnline : Corso
{
   //piattaforma linkAccesso
   private string _piattaforma;
   private string _linkAccesso;

   public string piattaforma
   {
      get {return _piattaforma;}
      set { if ((!string.IsNullOrEmpty(value))&& (value.ToLower() != "goto"))
         {
            _piattaforma = value.ToLower();
         }
         else{ _piattaforma = "teams";}}
   }

   public string linkAccesso
   {
      get {return _linkAccesso;}
      set { if (!string.IsNullOrEmpty(value))
         {
            _linkAccesso = value.ToLower();
         }
         else
         {
            _linkAccesso = "goto.com";
         }
      }
   }
   //ErogaCorso StampaDettagli

   public CorsoOnline (string titolo, int durataOre, string piattaforma, string linkAccesso) : base (titolo, durataOre)
   {
      this.piattaforma = piattaforma;
      this.linkAccesso = linkAccesso;
   }
   public override void ErogaCorso()
   {
      Console.WriteLine($"Corso online di {titolo} erogato correttamente.");
      
   }

   public override void StampaDettagli()
   {
      Console.WriteLine($"Il corso di ({titolo}) si terrà online sullla piattaforma {piattaforma} ed avrà una durata di {durataOre}h.");
      Console.WriteLine($"Il corso inoltre si terrà sulla piattaforma {piattaforma} accessibile al link: {linkAccesso}");
      
   }

}