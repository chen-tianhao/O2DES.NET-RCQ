namespace RunnableDemo.Entity
{
    public class Bus
    {
        public string Id;
        public int Capacity = 40;
        public override string ToString()
        {
            return $"Bus[{Id}]";
        }
    }
}
