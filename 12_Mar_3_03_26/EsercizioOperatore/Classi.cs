public class Operatore
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
         if (!string.IsNullOrEmpty(value))
         {
            _nome = value;
         }
      }
   }


   private string _turno;
   public string Turno
   {
      get
      {
         return _turno;
      }
      set
      {
         if (value.ToLower() == "giorno" || value.ToLower() == "notte")
         {
            _turno = value;
         }
         else
         {
            Console.WriteLine($"Valore non valido.");
         }
      }
   }

   public Operatore (string Nome, string Turno)
   {
      this.Nome = Nome;
      this.Turno = Turno;
   }
   
   
   public virtual void EseguiCompito()
   {
      Console.WriteLine($"Operatore generico in servizio..");
      
   }
}

public class OperatoreEmergenza : Operatore
{
   private int _livelloUrgenza;
   public int LivelloUrgenza
   {
      get
      {
         return _livelloUrgenza;
      }
      set
      {
         if ((value >= 1)&&(value<= 5))
         {
            _livelloUrgenza = value;
         }
         else
         {
            Console.WriteLine($"Valore non valido");
         }
      }
   }

   public OperatoreEmergenza(string Nome, string Turno, int livelloUrgenza) : base(Nome, Turno)
   {
      this.LivelloUrgenza = livelloUrgenza;
   }

   public override void EseguiCompito()
   {
      base.EseguiCompito();
      Console.WriteLine($"L'operatore {Nome}, sta gestendo un'emergenza di livello {LivelloUrgenza}");
   }

}

public class OperatoreSicurezza : Operatore
{
   private string _areaSorvegliata;
   public string AreaSorvegliata
   {
      get
      {
         return _areaSorvegliata;
      }
      set
      {
         if (!string.IsNullOrEmpty(value))
         {
            _areaSorvegliata = value;
         }
      }
   }


   public OperatoreSicurezza(string nome, string turno, string areasorvegliata) : base (nome, turno)
   {
      this.AreaSorvegliata = areasorvegliata;
   }

   public override void EseguiCompito()
   {
      base.EseguiCompito();
      Console.WriteLine($"L'operatore {Nome}, sta effettuando la sorveglianza dell'area {AreaSorvegliata}.");
   }
}

public class OperatoreLogistica : Operatore
{
   private int _numeroConsegne;
   public int NumeroConsegne
   {
      get
      {
         return _numeroConsegne;
      }
      set
      {
         if (value > 0)
         {
            _numeroConsegne = value;
         }
      }
   }

   public OperatoreLogistica(string nome, string turno, int nConsegne) : base (nome, turno)
   {
      this.NumeroConsegne = nConsegne;
   }
   public override void EseguiCompito()
   {
      base.EseguiCompito();
      Console.WriteLine($"L'operatore {Nome}, sta effettuando il coordinamento di {NumeroConsegne} consegne");
   }
}