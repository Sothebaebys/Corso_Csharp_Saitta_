public class Corso
{
   public string nomeCorso;
   public int durataOre;
   public string docente;

   public List<string> studenti;

   public Corso(string nome, int durata, string docente)
   {
      this.nomeCorso = nome;
      this.durataOre = durata;
      this.docente = docente;
   }

   public void AggiungiStudente(string nomeStud)
   {
      studenti.Add(nomeStud);
   }

   public override string ToString()
   {
      return $"Il corso {nomeCorso} ha una durata di {durataOre} ore, il docente sarà {docente}.\n Ad ora gli studenti iscritti sono {studenti.Count()}";
   }

   public virtual void MetodoSpeciale()
   {
      Console.WriteLine($"");
      
   }
}

class CorsoMusica : Corso

{
   public string strumento;

   public CorsoMusica(string nome, int durata, string docente, string strumento) : base (nome, durata, docente)
   {
      this.strumento = strumento;
   }

   public override string ToString()
   {
      return $"Il corso di musica {nomeCorso} ha una durata di {durataOre} ore, il docente sarà {docente}.\n Ad ora gli studenti iscritti sono {studenti.Count()}.\nLo strumento musicale utilizzato sara: {strumento}";
   }

   public override void MetodoSpeciale()
   {
      Console.WriteLine($"Si terranno quotidianamente prove pratiche dello strumento: {strumento}");
   }
}


class CorsoPittura : Corso
{
   public string tecnica;

   public CorsoPittura(string nome, int durata, string docente, string tecnica) : base (nome, durata, docente)
   {
      this.tecnica = tecnica;
   }

   public override string ToString()
   {
      return $"Il corso di pittura ({nomeCorso}) ha una durata di {durataOre} ore, il docente sarà {docente}.\n Ad ora gli studenti iscritti sono {studenti.Count()}.\nE si dipingerà utilizzante la tecnica: {tecnica}";
   }

   public override void MetodoSpeciale()
   {
      Console.WriteLine($"Si terranno quotidianamente esercitazioni pittoriche con la seguente tecnica: {tecnica}");
   }
}


class CorsoDanza : Corso
{
   public string stile;

   public CorsoDanza(string nome, int durata, string docente, string stile) : base (nome, durata, docente)
   {
      this.stile = stile;
   }

   public override string ToString()
   {
      return $"Il corso di danza {nomeCorso} ha una durata di {durataOre} ore, il docente sarà {docente}.\n Ad ora gli studenti iscritti sono {studenti.Count()}.\nLo stile sarà: {stile}";
   }

   public override void MetodoSpeciale()
   {
      Console.WriteLine($"Si terranno quotidianamente prove coreografiche nello stile: {stile}");
   }
}


