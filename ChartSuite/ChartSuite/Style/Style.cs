using System;
using System.Collections.Generic;
using System.Drawing;

namespace ChartSuite
{
    public class Style
    {
        private static List<Color> candidateColor = new List<Color>
        {
            Color.CornflowerBlue,
            Color.Tomato,
            Color.Red,
            Color.Goldenrod,
            Color.Gray,
            Color.Blue,
            Color.Chocolate,
            Color.Yellow,
            Color.HotPink,
            Color.Pink,
            Color.SaddleBrown,
            Color.Purple,
            Color.Peru,
            Color.Navy,
            Color.MediumTurquoise,
        };

        private Font font;
        private List<Color> colorList;
        private Color outLineColor;
        private StyleType type;

        public Style()
        {
            font = new Font("宋体", 9);
            outLineColor = Color.Gray;
        }

        public Font Font
        {
            get
            {
                return font;
            }

            set
            {
                font = value;
            }
        }

        public Color OutLineColor
        {
            get
            {
                return outLineColor;
            }

            set
            {
                outLineColor = value;
            }
        }

        public StyleType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
                CheckType(type);
            }
        }

        public List<Color> ColorList
        {
            get
            {
                if (colorList == null)
                    colorList = candidateColor;
                return colorList;
            }

        }

        private StyleType CheckType(StyleType type)
        {
            switch (type)
            {
                case StyleType.Normal:
                    type = StyleType.Normal;
                    SetStyle(type);
                    break;
                case StyleType.Light:
                    type = StyleType.Light;
                    SetStyle(type);
                    break;
            }
            return type;
        }

        private void SetStyle(StyleType type)
        {
            switch (type)
            {
                case StyleType.Normal:
                    font = new Font("宋体", 9);
                    colorList = SelectColor(0);
                    outLineColor = Color.Gray;
                    break;
                case StyleType.Light:
                    font = new Font("宋体", 9);
                    colorList = SelectColor(7);
                    outLineColor = Color.Gray;
                    break;
                default:
                    SystemException exception = new SystemException("No this type chart.");
                    break;
            }
        }

        private List<Color> SelectColor(int i)
        {
            List<Color> tmpColorList = new List<Color>();
            for (int j = 0; j < candidateColor.Count; j++)
            {
                tmpColorList.Add(candidateColor[((i++) % (candidateColor.Count - 1))]);
            }
            return tmpColorList;
        }
    }
}
