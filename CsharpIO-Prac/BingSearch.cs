using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpIO_Prac
{

    public class BingSearch
    {
        public Demo Demo { get; set; }
        public string RawJson { get; set; }
        public object QueryString { get; set; }
        public object Query { get; set; }
        public string Market { get; set; }
        public object Freshness { get; set; }
    }

    public class Demo
    {
        public string _type { get; set; }
        public string readLink { get; set; }
        public int totalEstimatedMatches { get; set; }
        public Value[] value { get; set; }
    }

    public class Value
    {
        public About[] about { get; set; }
        public Provider[] provider { get; set; }
        public DateTime datePublished { get; set; }
        public object clusteredArticles { get; set; }
        public object mentions { get; set; }
        public Video video { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public Image image { get; set; }
    }

    public class Video
    {
        public string name { get; set; }
        public string thumbnailUrl { get; set; }
        public bool allowHttpsEmbed { get; set; }
        public Thumbnail thumbnail { get; set; }
    }

    public class Thumbnail
    {
        public object contentUrl { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Image
    {
        public object contentUrl { get; set; }
        public Thumbnail1 thumbnail { get; set; }
    }

    public class Thumbnail1
    {
        public string contentUrl { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class About
    {
        public string readLink { get; set; }
        public string name { get; set; }
    }

    public class Provider
    {
        public string _type { get; set; }
        public string name { get; set; }
    }

}
