public class Program
{
   public static void Main(string[] args)
   {
      #region Studente
      Studente stud = new Studente();
      Studente stud1 = new Studente();

      stud.Nome = "Pancrazio Bentivoglio";
      stud.Matricola = 22201543;
      stud.MediaVoti = 27;

      

      stud1.Nome = "Ludovico Ariosto";
      stud1.Matricola = 27701543;
      stud1.MediaVoti = 30;

      stud.Info();
      stud1.Info();

      #endregion
   
      #region  Persona
   
      Persona p = new Persona("Pippo","Franco",1802);
      Persona p2 = new Persona();
      Persona p3 = new Persona("Pippo","Franco",1802);
      
      p2.Nome = "Paperino";
      p2.Cognome = "Lafranca";
      p2.AnnoDiNascita = 1630;

      p.Info();
      p2.Info();

      Console.WriteLine(p.ToString());
      Console.WriteLine(p2.ToString());
      Console.WriteLine(p3.Equals(p));
      Console.WriteLine(p2.Equals(p));

      #endregion
   
      #region Operazioni

      Operazioni op = new Operazioni(15,18);

      op.Somma();
      op.Moltiplica();

      Operazioni op2 = new Operazioni(3,4);
      op2.Somma();
      op2.Moltiplica();
      
      #endregion
   }
}