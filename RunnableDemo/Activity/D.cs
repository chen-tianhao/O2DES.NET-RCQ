using O2DESNet.Activity;
using RunnableDemo.Entity;

namespace RunnableDemo.Activity
{
    public class D : BaseActivity<Bus>
    {
        public D(bool debugMode = false, int seed = 0) : base(nameof(D), debugMode, seed)
        {
            TimeSpan = TimeSpan.FromSeconds(100);
        }
    }
}
