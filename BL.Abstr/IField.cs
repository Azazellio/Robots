﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Abstr
{
    public interface IField
    {
        public void ScanField();
        public Robot GetRobot();
        public int GetSizeX();
        public int GetSizeY();
        public IGameObject[,] GetField();
    }
}