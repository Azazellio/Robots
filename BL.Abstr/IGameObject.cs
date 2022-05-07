using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Abstr
{
    public interface IGameObject
    {
        //public string GetView();
        //public void Destroy();
        /*        public int GetPosX();
                public int GetPosY();*/

        public Type GetCompilerTimeType();
        public int GetPosX { get; set; }
        public int GetPosY { get; set; }

    }
}
