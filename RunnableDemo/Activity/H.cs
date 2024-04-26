using O2DESNet.Activity;
using RunnableDemo.Entity;

namespace RunnableDemo.Activity
{
    public class H : BaseActivity<Traveller>
    {
        public H(bool debugMode = false, int seed = 0) : base(nameof(H), debugMode, seed)
        {

        }
    }
}
