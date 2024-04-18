﻿using O2DESNet.Activity;
using RunnableDemo.Entity;

namespace RunnableDemo.Activity
{
    public class B<T> : BaseActivity<T>
{
    public B(bool debugMode = false, int seed = 0) : base(nameof(B<T>), debugMode, seed)
    {
        NeedExtTryStart = true;
    }

    public override void TryStart(object obj)
    {
        Console.WriteLine($"{ClockTime.ToString("yyyy-MM-dd HH:mm:ss")}  {ActivityName}.TryStart({obj})");
        Bus? bus = obj is Bus ? obj as Bus : null;
        if (bus == null) { return; }

        List<T> tmpPassengers = new List<T>();
        foreach (var passenger in PendingList)
        {
            ReadyToStartList.Add(passenger);
            tmpPassengers.Add(passenger);
            bus.Capacity--;
            if (bus.Capacity == 0) break;
        }

        for (int i = 0; i < tmpPassengers.Count; i++)
        {
            AttemptToStart();
        }
    }
}
}
