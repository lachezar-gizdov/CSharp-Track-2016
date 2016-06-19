namespace Defining_classes
{
    using System;

    class Display
    {
        public double Size { get; set; }
        public int Colors { get; set; }

        public Display(double size, int colors)
        {
            this.Size = size;
            this.Colors = colors;
        }
    }
}
