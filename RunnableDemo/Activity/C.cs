using O2DESNet.Activity;
using RunnableDemo.Entity;

namespace RunnableDemo.Activity
{
    public class C : BaseActivity<Traveller>
    {
        public C(bool debugMode = false, int seed = 0) : base(nameof(C), debugMode, seed)
        {
            TimeSpan = TimeSpan.FromSeconds(10);
        }

        protected override void Start(Traveller load)
        {
            base.Start(load);
        }
    }
}
