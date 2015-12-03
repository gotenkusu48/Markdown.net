using System;
using System.Collections.Generic;
using System.Linq;
using MarkDown;
using System.Text;

namespace MarkDown
{
    public class MarkDown
    {

        public string Markdowntext { get; }

        public MarkDown(string text)
        {
            this.Markdowntext = text;

            var taginfos = new List<TagGenerater.TagInfo>();
            
            
        }

    }
}
