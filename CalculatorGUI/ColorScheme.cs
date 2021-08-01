using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CalculatorGUI
{
    struct ColorContainer
    {
        public Color background;
        public Color foreground;
    }

    struct ColorScheme
    {
        public ColorContainer baseColors;
        public ColorContainer menuPanelColors;
        public ColorContainer buttonsColors;
        public ColorContainer historyColors;
        public ColorContainer displayFeildColors;
    }

    enum CurrentColorScheme
    {
        DARK = 0,
        LIGHT = 1
    }
}
