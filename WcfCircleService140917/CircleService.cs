using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfCircleService140917
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CircleService : ICircleService
    {
        public double CalcCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public double CalcDiameter(double radius)
        {
            return radius * 2;
        }
    }
}
