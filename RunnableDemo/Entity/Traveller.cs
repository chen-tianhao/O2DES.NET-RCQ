namespace RunnableDemo.Entity
{
    public class Traveller
    {
        public string Id;
        public double Fee = 1.09;
        public bool LikeHiking;
        public override string ToString()
        {
            return $"Traveller[{Id}]";
        }
    }
}
