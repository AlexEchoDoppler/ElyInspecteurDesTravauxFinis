namespace Tp2
{
    public abstract class Compte
    {
        public virtual double balance
        {
            get
            {
                int tempAmount = 0;
                foreach (var operation in operations)
                {
                    if(operation.type == Operation.Type.Positif)
                        tempAmount += operation.amount;
                    else   
                        tempAmount -= operation.amount;
                }
                return tempAmount;
            ;}}

        public Client? client;
        protected List<Operation> operations = new List<Operation>();

        public void Crediter(int amount)
        {
            Operation operation = new Operation(Operation.Type.Positif,amount);
            operations.Add(operation);
        }

         public void Crediter(int amount, Compte compte)
        {
            Crediter(amount);
            compte.Debiter(amount);
        }

         public void Debiter(int amount)
        {
            Operation operation = new Operation(Operation.Type.Negatif,amount);
            operations.Add(operation);
        }

         public void Debiter(int amount, Compte compte)
        {
            Debiter(amount);
            compte.Crediter(amount);
        }
    }
}