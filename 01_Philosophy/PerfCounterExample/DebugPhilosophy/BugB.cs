using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugPhilosophy {
  class BugB {

    public static void ShowBug() {
      var myGrades = new List<double> { 5, 4, 3, 2, 1 };

      // averageGrade should be 3.0
     var averageGrade =  CalculateAverage(myGrades);
    }

   static double CalculateAverage(List<double>grades) {
      // logic error in this code
      var workingTotal = 0.0;
      for (int i = 1; i < grades.Count; i++)
      {
        workingTotal += grades[i];
      }

      return workingTotal / grades.Count;

    }

    

  }
}
