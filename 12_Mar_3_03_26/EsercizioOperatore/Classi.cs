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
         _nome = Nome;
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
         if (value == "giorno" || value == "notte")
         {
            _turno = value;
         }
         else
         {
            Console.WriteLine($"Valore non valido.");
         }
      }
   }

   public Operatore (string nome, string turno)
   {
      this.Nome = nome;
      this.Turno = turno;
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

   public OperatoreEmergenza(string nome, string turno, int livelloUrgenza) : base(nome, turno)
   {
      this.LivelloUrgenza = livelloUrgenza;
   }
   
   public override void EseguiCompito()
   {
      base.EseguiCompito();
      Console.WriteLine($"Gestione emergenza di livello: {LivelloUrgenza}");
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
         _areaSorvegliata = AreaSorvegliata;
      }
   }


   public OperatoreSicurezza(string nome, string turno, string areasorvegliata) : base (nome, turno)
   {
      this.AreaSorvegliata = areasorvegliata;
   }

   public override void EseguiCompito()
   {
      base.EseguiCompito();
      Console.WriteLine($"Sorveglianza dell'area {AreaSorvegliata}.");
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
      Console.WriteLine($"Coordinamento di {NumeroConsegne} consegne");
   }
}