using O2DESNet;
using WSC_SimChallenge_2024_Net.TestCase.Activity;

namespace WSC_SimChallenge_2024_Net.TestCase.Model
{
    public class Bus
    {
        public string Id;
        public int Capacity = 40;
        public override string ToString()
        {
            return $"Bus[{Id}]";
        }
    }
}
