﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottPlot.Config
{
    public class Grid
    {
        public bool enableHorizontal = true;
        public bool enableVertical = true;
        public Color color = Color.LightGray;
        public LineStyle lineStyle = LineStyle.Solid;
        public double lineWidth = 1;
        public bool snapToNearestPixel = true;
    }
}
