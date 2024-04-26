using O2DESNet.Activity;
using RunnableDemo.Entity;

namespace RunnableDemo.Activity
{
    public class F : BaseActivity<Bus>
    {
        public F(bool debugMode = false, int seed = 0) : base(nameof(F), debugMode, seed)
        {
            NeedExtTryStart = true;
            NeedExtTryFinish = true;
        }

        public override void TryStart(Object obj)
        {
            Console.WriteLine($"{ClockTime.ToString("yyyy-MM-dd HH:mm:ss")}  {ActivityName}.TryStart({obj})");
            Traveller? traveller = (obj is Traveller) ? (obj as Traveller) : null;

            bool condition = traveller.Fee > 0;
            Bus? load = PendingList.Count > 0 ? PendingList[0] : default; // Caution: Need to sepcify a load according to certain logic about obj
            if (condition && load != null)
            {
                ReadyToStartList.Add(load);
            }
            AttemptToStart();
        }

        public override void TryFinish(Object obj)
        {
            Console.WriteLine($"{ClockTime.ToString("yyyy-MM-dd HH:mm:ss")}  {ActivityName}.TryFinish({obj})");
            Traveller? traveller = (obj is Traveller) ? (obj as Traveller) : null;

            bool condition = traveller.Fee > 0;
            Bus? load = CompletedList.Count > 0 ? CompletedList[0] : default; // Caution: Need to sepcify a load according to certain logic about obj
            if (condition && load != null)
            {
                ReadyToFinishList.Add(load);
            }
            AttemptToFinish(load);
        }
    }
}
