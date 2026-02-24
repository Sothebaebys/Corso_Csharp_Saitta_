List<string> parole = new List<string>();

parole.Add("Ciao");
parole.Add("come");
parole.Add("calcolatrice");

if (parole.Contains("Ciao"))
{
   Console.WriteLine($"Ecchilo!");
   
}

foreach (string parola in parole)
{
   Console.WriteLine($"Parola in lista: {parola}");
}

for(int i=0; i < parole.Count; i++)
{
   Console.WriteLine($"{i} {parole[i]}");
   
}