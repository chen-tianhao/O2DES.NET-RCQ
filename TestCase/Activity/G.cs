using WSC_SimChallenge_2024_Net.Activity;

namespace WSC_SimChallenge_2024_Net.TestCase.Activity
{
    public class G<T> : BaseActivity<T>
    {
        public G(bool debugMode = false, int seed = 0) : base(nameof(G<T>), debugMode, seed)
        {

        }
    }
}
