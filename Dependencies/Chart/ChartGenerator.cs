using System;
using System.Collections.Generic;
using System.Drawing;

namespace TechConnect
{
    class ChartGenerator
    {
        public List<Color> GetColors(string legend)
        {
            if (legend == "Current")
                return new List<Color> { Color.Teal };

            return new List<Color> { Color.DodgerBlue };
        }

        public List<string> GetLabels()
        {
            List<string> returnList = new List<string>();

            for (int hour = 0; hour < 23; hour++)
                returnList.Add(string.Concat(hour.ToString(), "h"));

            return returnList;
        }

        public List<double> GetCurrentRevenue()
        {
            List<double> returnList = new List<double>();
            Random rm = new Random();

            for (int hour = 0; hour < 23; hour++)
                returnList.Add(rm.Next(50, 100));

            return returnList;
        }
    }
}
