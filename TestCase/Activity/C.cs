using WSC_SimChallenge_2024_Net.Activity;

namespace WSC_SimChallenge_2024_Net.TestCase.Activity
{
    public class C<T> : BaseActivity<T>
    {
        public C(bool debugMode = false, int seed = 0) : base(nameof(C<T>), debugMode, seed)
        {
            TimeSpan = TimeSpan.FromSeconds(10);
        }
    }
}
