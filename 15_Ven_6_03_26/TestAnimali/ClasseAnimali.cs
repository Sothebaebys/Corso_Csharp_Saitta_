/*public enum TipoAnimale
{
   pecora,
   gallina,
   mucca,
   maiale
}*/

public abstract class Animale
{
   //Proprietà della classe 
   private string _nome;
   public string nome
   {
      get {return _nome;}
      set {if (!string.IsNullOrEmpty(value))
         {
            _nome = value;
         }
      }
   }
   private int _eta;

   public int eta
   {
      get {return _eta;}
      set { if (value > 0)
         {
            _eta = value;
         }
      }
   }

   //Costruttore
   public Animale(string nome,int eta)
   {
      this.nome = nome;
      this.eta = eta;
   }
   
   //Metodi di classe da overridare
   public virtual void Info()
   {
      Console.WriteLine($"Info:\n - Animale di tipo: {GetType().Name} \n - Nome: {nome}\n - Età: {eta}");
      
   }

   public abstract void Verso();
}

public class Mucca : Animale

{
   private string _verso = "Muuuuu..";

   public Mucca(string nome, int eta) : base (nome,eta)
   {
      
   }

   public override void Info()
   {
      base.Info();
      Console.WriteLine($" - Skill: latte ");
      
   }

   public override void Verso()
   {

      Console.WriteLine($"Le mucche fanno {_verso}, ma una fa mu mu");
      
   }
}

public class Gallina : Animale

{
   private string _verso = "coccodè..";

   public Gallina(string nome, int eta) : base (nome,eta)
   {
      
   }

      public override void Info()
   {
      base.Info();
      Console.WriteLine($" - Skill: Uova ");
      
   }

   public override void Verso()
   {

      Console.WriteLine($"A parte Rosita con Banderas, le gallinne fanno {_verso}");
      
   }
}

public class Pecora : Animale

{
   private string _verso = "Beeeeeeheeee..";

   public Pecora(string nome, int eta) : base (nome,eta)
   {
      
   }

   public override void Info()
   {
      base.Info();
      Console.WriteLine($" - Skill: Lana,latte ");
      
   }

   public override void Verso()
   {

      Console.WriteLine($"Le pecore {_verso}lano");
      
   }
}

public class Maiale : Animale

{
   private string _verso = "Oink..";

   public Maiale(string nome, int eta) : base (nome,eta)
   {
      
   }

      public override void Info()
   {
      base.Info();
      Console.WriteLine($" - Skill: prosciutto & porchetta ");
   }
   public override void Verso()
   {
      Console.WriteLine($"Il maiale fa {_verso}");
      
   }
}
