using O2DESNet;
using RunnableDemo.Activity;
using RunnableDemo.Entity;

namespace RunnableDemo.Model
{
    class MySimModel : Sandbox
    {
        private A<Traveller> a;
        private B<Traveller> b;
        private C<Traveller> c;
        private D<Bus> d;
        private E<Bus> e;
        private F<Bus> f;
        private G<Traveller> g;
        private H<Traveller> h;
        private readonly bool _debugMode = true;

        public MySimModel() : base()
        {
            a = AddChild(new A<Traveller>(_debugMode));
            b = AddChild(new B<Traveller>(_debugMode));
            c = AddChild(new C<Traveller>(_debugMode));
            d = AddChild(new D<Bus>(_debugMode));
            e = AddChild(new E<Bus>(_debugMode));
            f = AddChild(new F<Bus>(_debugMode));
            g = AddChild(new G<Traveller>(_debugMode));
            h = AddChild(new H<Traveller>(_debugMode));

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
