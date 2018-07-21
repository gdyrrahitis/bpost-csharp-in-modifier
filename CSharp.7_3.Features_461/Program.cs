namespace CSharp._7_3.Features_461
{
    using System;
    using System.Drawing;

    class Program
    {
        static void Main(string[] args)
        {
            var bitmap = new Bitmap(600, 400);
            var graphics = Graphics.FromImage(bitmap);
            var label = new Label();

            for (var i = 0; i < 10; i++)
            {
                label.Draw(graphics, "Some random title");
            }

            Console.ReadLine();
        }
    }
}
