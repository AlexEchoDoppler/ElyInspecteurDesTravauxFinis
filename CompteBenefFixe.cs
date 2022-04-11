namespace Tp2
{
    public class CompteBenefFixe : Compte , ICalculateurDeBenefice
    {
        public override double balance{get => CalculBenef();}
        public double taux => 2.75;

        public double CalculBenef()
        {
            double tempSolde = 0;
            double decimalEpargne = taux / 100;
            tempSolde = base.balance * (1 + decimalEpargne);
            return Convert.ToInt32(tempSolde);
        }
    }
}