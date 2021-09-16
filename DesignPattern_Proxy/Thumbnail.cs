using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_Proxy
{
    interface Thumbnail
    {
        public void ShowTitle();
        public void ShowPreview();
    }

    class RealThumbnail : Thumbnail
    {
        private string title;
        private string movieUrl;

        public RealThumbnail(string _title, string _movieUrl)
        {
            title = _title;
            movieUrl = _movieUrl;

            Console.WriteLine(movieUrl + "로부터" + title + "의 영상 데이터 다운");
        }

        public void ShowPreview()
        {
            Console.WriteLine("제목: " + title);
        }

        public void ShowTitle()
        {
            Console.WriteLine(title + "의 프리뷰 재생");
        }
    }

    class ProxyThumbnail : Thumbnail
    {
        private string title;
        private string movieUrl;
        private RealThumbnail realThumbnail;

        public ProxyThumbnail(string _title, string _movieUrl)
        {
            title = _title;
            movieUrl = _movieUrl;
        }

        public void ShowPreview()
        {
            if (realThumbnail == null)
            {
                realThumbnail = new RealThumbnail(title, movieUrl);
            }
            realThumbnail.ShowPreview();
        }

        public void ShowTitle()
        {
            Console.WriteLine("제목: " + title);
        }
    }
}
