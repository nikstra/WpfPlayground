using System.Windows.Media;

namespace GridSharedSizeGroup
{
    public static class ColorExtensions
    {
        /// <summary>
        /// Returns black or white depending on which has the most contrast
        /// against the perceived brightness of the Color passed to the method.
        /// </summary>
        /// <param name="color">The Color to analyze brightness for</param>
        /// <returns>Colors.Black or Colors.White</returns>
        public static Color ContrastColor(this Color color)
        {
            // Calculate the perceptive luminance (aka luma) - human eye favors green color... 
            double luma = ((0.299 * color.R) + (0.587 * color.G) + (0.114 * color.B)) / 255;

            // Return black for bright colors, white for dark colors
            return luma > 0.5 ? Colors.Black : Colors.White;
        }
    }
}
