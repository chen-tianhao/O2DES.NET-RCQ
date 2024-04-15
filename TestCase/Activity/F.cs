using WSC_SimChallenge_2024_Net.Activity;
using WSC_SimChallenge_2024_Net.TestCase.Model;

namespace WSC_SimChallenge_2024_Net.TestCase.Activity
{
    public class F<T> : BaseActivity<T>
    {
        public F(bool debugMode = false, int seed = 0) : base(nameof(F<T>), debugMode, seed)
        {
            NeedExtTryStart = true;
            NeedExtTryFinish = true;
        }

        public override void TryStart(Object obj)
        {
            Console.WriteLine($"{ClockTime.ToString("yyyy-MM-dd HH:mm:ss")}  {ActivityName}.TryStart({obj})");
            Traveller? traveller = (obj is Traveller) ? (obj as Traveller) : null;

            bool condition = traveller.Fee > 0;
            T? load = PendingList.Count > 0 ? PendingList[0] : default; // Caution: Need to sepcify a load according to certain logic about obj
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
            T? load = CompletedList.Count > 0 ? CompletedList[0] : default; // Caution: Need to sepcify a load according to certain logic about obj
            if (condition && load != null)
            {
                ReadyToFinishList.Add(load);
            }
			AttemptToFinish(load);
        }
    }
}
