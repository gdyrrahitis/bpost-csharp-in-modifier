namespace CSharp._7_3.Features_461
{
    using System.Drawing;

    public readonly struct Font
    {
        private static Font _default = new Font("Times New Roman", 11.0f);
        public static ref readonly Font Default => ref _default;

        public Font(string fontFamily, float size)
        {
            System.Console.WriteLine("Called Font constructor.");
            FontFamily = fontFamily;
            Size = size;
        }

        public string FontFamily { get; }
        public float Size { get; }
    }

    public class Label
    {
        public string Title { get; private set; }
        public ref readonly Font DefaultFont => ref Font.Default;

        public void Draw(Graphics graphic, string title)
        {
            Title = title;
            ref readonly var font = ref DefaultFont;
            // Draw with font
            //graphic.DrawString(title, new System.Drawing.Font(font.FontFamily, font.Size), 
            //    Brushes.Black, new PointF());
            System.Console.WriteLine($"Drawing label with font: '{font.FontFamily}', size: {font.Size}");
        }
    }
}
