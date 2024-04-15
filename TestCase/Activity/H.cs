using WSC_SimChallenge_2024_Net.Activity;

namespace WSC_SimChallenge_2024_Net.TestCase.Activity
{
    public class H<T> : BaseActivity<T>
    {
        public H(bool debugMode = false, int seed = 0) : base(nameof(H<T>), debugMode, seed)
        {

        }
    }
}
