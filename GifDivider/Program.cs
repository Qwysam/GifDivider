using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using GifDivider;
string inputGifPath = "";
string outputDirectory = "";
Image tmp;
if(args.Length == 0)
{
    Console.WriteLine("Incorrect file path");
}
else
{
    inputGifPath = args[0];
    tmp = Image.Load(inputGifPath);
    if (args.Length == 1)
    {
        outputDirectory = Directory.GetParent(inputGifPath) + "/Images";
        Directory.CreateDirectory(outputDirectory);
    }
    else
        outputDirectory = args[1];
    if (Directory.Exists(outputDirectory))
        Divider.SaveImages(Divider.GifToFrames(tmp), outputDirectory);
    else
        Console.WriteLine("Incorrect output directory");
}