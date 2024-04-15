using WSC_SimChallenge_2024_Net.Activity;

namespace WSC_SimChallenge_2024_Net.TestCase.Activity
{
    public class D<T> : BaseActivity<T>
    {
        public D(bool debugMode = false, int seed = 0) : base(nameof(D<T>), debugMode, seed)
        {
            TimeSpan = TimeSpan.FromSeconds(100);
        }
    }
}
