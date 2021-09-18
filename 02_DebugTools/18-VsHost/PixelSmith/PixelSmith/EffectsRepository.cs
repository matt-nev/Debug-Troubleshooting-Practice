using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelSmith
{
 public static class EffectsRepository
  {

    public static List<string> GetEffectNames()
    {
      var temp = new List<string>();
      temp.Add("Color Tone");
      temp.Add("Toon");
      temp.Add("Monochrome");
      return temp;
    }
  }
}
