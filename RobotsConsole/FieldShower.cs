using BL.Abstr;
using System;

namespace RobotsConsole
{
    class FieldShower
    {
        public FieldShower() { }
        public string GetString(IField field)
        {
            int rowLength = field.GetField().GetLength(0);
            int colLength = field.GetField().GetLength(1);
            var res = "";
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    res += string.Format("{0}", field.GetField()[i, j].GetView());
                }
                res += Environment.NewLine + Environment.NewLine;
            }
            return res;
        }
    }
}
