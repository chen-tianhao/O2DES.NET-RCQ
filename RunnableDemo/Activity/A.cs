using O2DESNet.Activity;
using RunnableDemo.Entity;

namespace RunnableDemo.Activity
{
    public class A : BaseActivity<Traveller>
    {
        public A(bool debugMode = false, int seed = 0) : base(nameof(A), debugMode, seed)
        {
            NeedExtTryFinish = true;
        }

        public override void TryFinish(Object obj)
        {
            Console.WriteLine($"{ClockTime.ToString("yyyy-MM-dd HH:mm:ss")}  {ActivityName}.TryFinish({obj})");
            Bus? bus = (obj is Bus) ? (obj as Bus) : null;
            if ( bus == null ) { return; }

            List<Traveller> tmpPassengers = new List<Traveller>();
            foreach (var passenger in CompletedList)
            {
                ReadyToFinishList.Add(passenger);
                tmpPassengers.Add(passenger);
                bus.Capacity--;
                if (bus.Capacity == 0) break;
            }

            foreach (var passenger in tmpPassengers)
            {
                AttemptToFinish(passenger);
            }
        }
    }
}
