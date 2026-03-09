class Program
{
   public static void Main(string[] args)
   {
      var istanza1 = Singleton.instance;

      istanza1.DoSomething();
   }
}