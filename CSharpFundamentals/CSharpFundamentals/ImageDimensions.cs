using System;


namespace CSharpFundamentals
{
    public class ImageDimensions
    {
        public void Image()
        {
            Console.WriteLine("Enter the width of the Image: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height of the Image: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageType.Landscape : ImageType.Portrait;
            Console.WriteLine("Image orientation is " + orientation);

        }

        public enum ImageType 
        {
            Landscape,
            Portrait
        }
    }
}
