using O2DESNet.Activity;

namespace RunnableDemo.Activity
{
    public class D<T> : BaseActivity<T>
    {
        public D(bool debugMode = false, int seed = 0) : base(nameof(D<T>), debugMode, seed)
        {
            TimeSpan = TimeSpan.FromSeconds(100);
        }
    }
}
