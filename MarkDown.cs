using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MarkDown;
using System.Text;
using Windows.UI.Xaml.Shapes;

namespace MarkDown
{
    public class MarkDown
    {

        public string Markdowntext { get; }

        public MarkDown(string text)
        {
            this.Markdowntext = text;

            var taginfos = new List<TagInfo>();

            using (var rs = new StringReader(text))
            {

                try
                {
                    //ストリームの末端まで繰り返す
                    while (rs.ReadLineAsync() != null)
                    {
                        //一行読み込んで表示する
                        var linetext = rs.ReadLineAsync();
                    }
                }
                catch (Exception)
                {
                    
                    throw new ObjectDisposedException(nameof(rs));
                }
            }

        }

    }
}
