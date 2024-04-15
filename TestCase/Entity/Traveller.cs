using O2DESNet;
using WSC_SimChallenge_2024_Net.TestCase.Activity;

namespace WSC_SimChallenge_2024_Net.TestCase.Model
{
    public class Traveller
    {
        public string Id;
        public double Fee = 1.09;
        public bool LikeHiking;
        public override string ToString()
        {
            return $"Traveller[{Id}]";
        }
    }
}
