using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Linq_To_Wiki_Example.Models
{
    public class WikiImage
    {
        public string Url { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public WikiImage(string url, int height, int width)
        {
            Url = url;
            Height = height;
            Width = width;
        }
    }
}