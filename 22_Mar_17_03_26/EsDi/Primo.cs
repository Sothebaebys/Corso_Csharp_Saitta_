/*Esercizio 1
Crea un'applicazione in cui una classe GreetingService riceve
tramite costruttore un'interfaccia IGreeter.
L'implementazione concreta ConsoleGreeter stampa un messaggio di
benvenuto.
Inietta IGreeter nel costruttore e chiama il metodo Greet.
*/

public interface IGreeter
{
   void Msg(string msg);

}


public class GreetingService
{
   private readonly IGreeter _greeter ;

   public GreetingService(IGreeter greeter)
   {
      _greeter = greeter;
   }

   public void Saluta(string msg)
   {
      _greeter.Msg($"Ciao {msg}!");
   }
}
