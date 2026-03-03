
class Soldato
{
   private string _nome;
   public string Nome
   {
      get
      {
         return _nome;
      }
      set
      {
         _nome = Nome;
      }
   }
   private string _grado;
   public string Grado
   {
      get
      {
         return _grado;
      }
      set
      {
         _grado = Grado;
      }
   }

   private int _anniServizio;
   public int AnniServizio
   {
      get 
      {
         return _anniServizio;
      } 
      set
      {
         if(value > 0)
         {
            _anniServizio = value;
         }
      }
   }

   public Soldato(string nome, string grado, int anniS)
   {
      this.Nome = nome;
      this.Grado = grado;
      this.AnniServizio = anniS;
   }

   public virtual void Descrizione()
   {
      Console.WriteLine($"Nome: {Nome}\nIl soldato è in servizio da {AnniServizio} anni ed ha raggiunto il grado di : {Grado}");
   }

}
class Fante : Soldato
{
   private string _arma;
   public string Arma
   {
      get
      {
         return _arma;
      }
      set
      {
         _arma = Arma;
      }
   }

   public Fante (string Nome, string Grado, int AnniServizio, string Arma) : base (Nome, Grado, AnniServizio)
   {
      this.Arma = Arma;
   }
   //string nome, string grado, int anniS
   public override void Descrizione()
   {
      
      Console.WriteLine($"Nome: {Nome}\nIl fante è in servizio da {AnniServizio} anni ed ha raggiunto il grado di : {Grado}\nArma in dotazione : {Arma}");
      
   }
}

class Artigliere : Fante
{

   private int _calibro;
   public int Calibro
   {
      get
      {
         return _calibro;
      }
      set
      {
         if (value>0)
         {
            _calibro = value; 
         }
      }
   }

   public Artigliere (string Nome, string Grado, int AnniServizio, string Arma, int Calibro) : base (Nome, Grado, AnniServizio, Arma)
   {
      this.Calibro = Calibro;
   }

   public override void Descrizione()
   {
      Console.WriteLine($"Nome: {Nome}\nIl fante è in servizio da {AnniServizio} anni ed ha raggiunto il grado di : {Grado}\nArma in dotazione: {Arma}\nCalibro: {Calibro}");
   }
}
