using O2DESNet.Activity;

namespace RunnableDemo.Activity
{
    public class H<T> : BaseActivity<T>
    {
        public H(bool debugMode = false, int seed = 0) : base(nameof(H<T>), debugMode, seed)
        {

        }
    }
}
