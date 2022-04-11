namespace Tp2
{
    public class Operation
    {
        public enum Type{Positif , Negatif}
        public Type type;
        public int amount;

        public Operation(Type type,int amount)
        {
            this.type = type;
            this.amount = amount;
        }
    }
}