using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NameGeneratorLib
{
  public class AppStressor
  {

    public static void AddCoreStressWithThreadPool(StressInfo data)
    {
      // ensure we don't use more cores than are available on the computer
      var coreCount = Math.Min(Environment.ProcessorCount, data.CoreCount);
      for (int i = 0; i < coreCount; i++)
      {
        ThreadPool.QueueUserWorkItem(new WaitCallback(ApplyCoreStress), data);
      }
    }

    private  static void ApplyCoreStress(Object stateInfo)
    {
      var info = (StressInfo)stateInfo;
      ApplyCoreStress(info);
    }

    private async static void ApplyCoreStress(StressInfo info)
    {
      for (int counter = 0; counter < info.RepeatCount; counter++)
      {
        var currentTime = DateTime.Now.AddMilliseconds(info.Milliseconds);
        while (currentTime > DateTime.Now) { };
        await Task.Delay(200);
      }
    }

    private static Random _ran = new Random();
    private static Int64[] _data;
    private static Int32 _counter = 0;

    /// <summary>
    ///  Add memory pressure to appdomain.
    ///  Each time this method is called, it increase the memory use by a factor of one
    /// </summary>
    public static void AddMemoryPressure()
    {
      _counter += 1;
      _data = new Int64[1000 * 1000 * _counter];
    }

    public async static Task SimulateWaitTime(int minMilliseconds, int maxMilliseconds)
    {
      await Task.Delay(_ran.Next(minMilliseconds, maxMilliseconds));
    }
    public struct StressInfo
    {
      public int Milliseconds { get; set; }
      public int CoreCount { get; set; }
      public int RepeatCount { get; set; }
    }
  }
}
