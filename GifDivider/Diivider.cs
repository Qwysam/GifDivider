using System;
namespace GifDivider
{

	public static class Divider
	{
        public static Image[] GifToFrames(Image img)
        {
            Image[] arr = new Image[img.Frames.Count];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = img.Frames.CloneFrame(i);
            return arr;
        }

        public static void SaveImages(Image[] arr, string outputDirectory)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].SaveAsJpeg(outputDirectory + $"/{i}.jpeg");
            }
        }
    }
}

