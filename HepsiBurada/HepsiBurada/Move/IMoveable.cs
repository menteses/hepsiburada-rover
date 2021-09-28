namespace HepsiBurada
{
    public interface IMoveable
    {
        Directions Direction { get; set; }
        int PositionX { get; set; }
        int PositionY { get; set; }
        void Move();
    }

}
