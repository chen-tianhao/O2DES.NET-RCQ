using O2DESNet.Activity;

namespace RunnableDemo.Activity
{
    public class G<T> : BaseActivity<T>
    {
        public G(bool debugMode = false, int seed = 0) : base(nameof(G<T>), debugMode, seed)
        {

        }
    }
}
