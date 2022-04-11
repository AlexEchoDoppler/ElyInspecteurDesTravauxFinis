using System;

namespace Tp2
{
    public class CompteEpargne : Compte
    {
        //public double tauxEpargne;
        public override double balance{get => CalculRandomEpargne();}
        Random rng = new Random();

        // public int CalculEpargne()
        // {
        //     double tempSolde = 0;
        //     double decimalEpargne = tauxEpargne / 100;
        //     tempSolde = base.balance * (1 + decimalEpargne);
        //     return Convert.ToInt32(tempSolde);
        // }

        public int CalculRandomEpargne()
        {
            double tempSolde = 0;
            decimal decimalEpargne = Decimal.Divide(rng.Next(0,100),100);
            tempSolde = base.balance * (1 + Convert.ToInt32(decimalEpargne));
            return Convert.ToInt32(tempSolde);
        }

          public void PrintInfos()
        {
            if(base.client != null)
            {
                Console.WriteLine($"Compte épargne de {base.client.name}");
                Console.WriteLine($"Solde : {balance} euros");
                Console.WriteLine($"Taux d'épargne : {rng} %");
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