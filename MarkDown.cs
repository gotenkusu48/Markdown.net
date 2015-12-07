using System;
using System.Collections.Generic;
using System.IO;

namespace MarkDown
{
    public class MarkDown
    {

        public string Markdowntext { get; }

        public MarkDown(string text)
        {
            Markdowntext = text;

            var taginfos = new List<TagGenerater.TagInfo>();

            using (var rs = new StringReader(text))
            {

                try
                {
                    //ストリームの末端まで繰り返す
                    while (rs.ReadLineAsync() != null)
                    {
                        //一行読み込んで表示する
                        var linetext = rs.ReadLineAsync().Result;

                        //Get Taginfo
                        taginfos.Add(Dicision(linetext));
                    }
                }
                catch (Exception)
                {

                    throw new ObjectDisposedException(nameof(rs));
                }
            }

        }

        protected static TagGenerater.TagInfo Dicision(string str)
        {
            return new TagGenerater.TagInfo();
        }

    }
}
