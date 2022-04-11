namespace Tp2
{
    public class Client
    {
        public string name;
        public CompteCourant compteCourant = new CompteCourant();
        public CompteEpargne compteEpargne = new CompteEpargne();
      
        public Client(string name)
        {
            this.name = name;
            compteCourant.client = this;
            compteEpargne.client = this;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Bienvenue {name} sur votre compte");
            Console.WriteLine("**************************************************************");
            compteCourant.PrintInfos();
            compteEpargne.PrintInfos();
        }
    }
}