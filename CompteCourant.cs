namespace Tp2
{
    public class CompteCourant : Compte
    {
        public int debitMax;
        public bool isBlocked;

        public void PrintInfos()
        {
            if(base.client != null)
            {
                Console.WriteLine($"Compte courant de {base.client.name}");
                Console.WriteLine($"Solde : {balance} euros");
                Console.WriteLine($"Decouvert autorisé : {debitMax} euros");
                Console.WriteLine("Operations : ");

                foreach (var operation in operations)
                {
                    if(operation.type == Operation.Type.Positif)
                        Console.WriteLine("+" + operation.amount);
                    else
                        Console.WriteLine("-" + operation.amount);
                }
                Console.WriteLine("**************************************************************");
            }
        }
    }
}