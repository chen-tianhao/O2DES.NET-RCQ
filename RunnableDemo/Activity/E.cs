using O2DESNet.Activity;
using RunnableDemo.Entity;

namespace RunnableDemo.Activity
{
    public class E : BaseActivity<Bus>
    {
        public E(bool debugMode = false, int seed = 0) : base(nameof(E), debugMode, seed)
        {
            
        }
    }
}
