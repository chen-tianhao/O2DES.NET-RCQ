using O2DESNet.Activity;
using RunnableDemo.Entity;

namespace RunnableDemo.Activity
{
    public class G : BaseActivity<Traveller>
    {
        public G(bool debugMode = false, int seed = 0) : base(nameof(G), debugMode, seed)
        {

        }
    }
}
