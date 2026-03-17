using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#region Classe parallela alla tabella del database
// Modello dominio
[Table("prodotti")]
public class Prodotti
{

   [Key]
   [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
   public int Id { get; set; }

   [Required] // Data annotation che applicano le regole del DB
   [MaxLength(50)]
   [Column("Nome")]
   public string Nome { get; set; } = default!;

   [Required]
   [MaxLength(50)]
   [Column("Prezzo")]
   public float Prezzo { get; set; } = default!;

}
#endregion


public class ProdottiContext : DbContext
{

   public DbSet<Prodotti> Prodotti => Set<Prodotti>();
   // Connection string centrale (adatta server/credenziali al tuo ambiente)
   private const string ConnString =
      //"Server=localhost;Database=Prodotti;Trusted_Connection=True;TrustServerCertificate=True;";
      "server=localhost;user=root;password=MioSequel1326;database=Prodotti";
   protected override void OnConfiguring(DbContextOptionsBuilder options)
   => options.UseMySql(ConnString,ServerVersion.AutoDetect(ConnString));

}

public class Program
{
   public static void Main()
   {
      using var db = new ProdottiContext();

      // Opzionale: crea il DB e le tabelle se non esistono
      db.Database.EnsureCreated();

      // 1) CREATE: inserisce un nuovo Prodotto
      var nuovo = new Prodotti { Nome = "Calze", Prezzo = 3.50f };
      db.Prodotti.Add(nuovo);
      db.SaveChanges();
      Console.WriteLine($"Creato prodotto Id={nuovo.Id}");

      // 2) READ (filtrato): legge tutti gli studenti con Cognome = "Rossi"
      var calze = db.Prodotti.Where(s => s.Nome == "Calze").ToList();
      Console.WriteLine("calze:");

      foreach (var s in calze)
      {
         Console.WriteLine($"{s.Id} - {s.Nome} {s.Prezzo}");
      }

      // 3) UPDATE: modifica il Nome del primo studente trovato
      var first = db.Prodotti.FirstOrDefault();

      if (first != null)
      {
         first.Nome = "cipolla";
         db.SaveChanges();
         Console.WriteLine($"Aggiornato Id={first.Id} -> Nome={first.Nome}");
      }
   }
}