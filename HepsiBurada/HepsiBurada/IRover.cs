namespace HepsiBurada
{
    public interface IRover : IMoveable, ILeftRotate, IRightRotate
    {
        void DoInstractions(string instractions);
    }
}
