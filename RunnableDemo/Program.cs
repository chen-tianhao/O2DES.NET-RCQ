using RunnableDemo.Model;

namespace RunnableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var sim = new MySimModel();
            sim.Run(1000);
        }
    }
}