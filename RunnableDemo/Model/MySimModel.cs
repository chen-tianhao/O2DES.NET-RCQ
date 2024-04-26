using O2DESNet;
using RunnableDemo.Activity;
using RunnableDemo.Entity;

namespace RunnableDemo.Model
{
    class MySimModel : Sandbox
    {
        private A a;
        private B b;
        private C c;
        private D d;
        private E e;
        private F f;
        private G g;
        private H h;
        private readonly bool _debugMode = true;

        public MySimModel() : base()
        {
            a = AddChild(new A(_debugMode));
            b = AddChild(new B(_debugMode));
            c = AddChild(new C(_debugMode));
            d = AddChild(new D(_debugMode));
            e = AddChild(new E(_debugMode));
            f = AddChild(new F(_debugMode));
            g = AddChild(new G(_debugMode));
            h = AddChild(new H(_debugMode));

            a.FlowTo(b);
            b.FlowToBranch(c, (traveller) => !DoesTravellerLikeHiking(traveller));
            b.FlowToBranch(g, (traveller) => DoesTravellerLikeHiking(traveller));
            c.FlowTo(h);
            g.FlowTo(h);
            h.Terminate();
            d.FlowTo(e).FlowTo(f).Terminate();

            a.RequestToStart(new Traveller { Id = "Alice", LikeHiking = true });
            a.RequestToStart(new Traveller { Id = "Bob", LikeHiking = false });

            Schedule(() => d.RequestToStart(new Bus { Id = "SGD 8888A" }), TimeSpan.FromSeconds(100));

            d.OnStart += a.TryFinish;
            d.OnReadyToDepart += b.TryStart;

            c.OnStart += f.TryStart;
            c.OnReadyToDepart += f.TryFinish;
        }

        private bool DoesTravellerLikeHiking(Traveller t)
        {
            return t.LikeHiking;
        }
    }
}
