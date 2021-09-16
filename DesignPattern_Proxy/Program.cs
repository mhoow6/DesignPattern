using System;
using System.Collections.Generic;

// Proxy 패턴
// - 대리인 패턴
// - 가벼운 일은 대리인을 생성해서 맡기고, 무거운 일은 대표가 나와서 해결

namespace DesignPattern_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Thumbnail> thumbnails = new List<Thumbnail>();

            thumbnails.Add(new ProxyThumbnail("영상 제목 1", "/movie1.mp4"));
            thumbnails.Add(new ProxyThumbnail("영상 제목 2", "/movie2.mp4"));
            thumbnails.Add(new ProxyThumbnail("영상 제목 3", "/movie3.mp4"));

            foreach (var thumb in thumbnails)
            {
                thumb.ShowTitle();
            }

            thumbnails[0].ShowPreview();
        }
    }
}
