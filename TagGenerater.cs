using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkDown
{
    public class TagInfo
    {
        public TagGenerater.TagType TagType { get; set; }
        public string text { get; set; } = "";
        public string link { get; set; } = "";
    }
    public class TagGenerater
    {
        public enum TagType
        {
            H1, H2, H3, H4, H5,
            P, Strong
        }

        

        public static string TagGenerate(TagInfo info)
        {
            return "";
        }

        /// <summary>
        /// this is a generate for h TAG
        /// </summary>
        /// <param name="text">inner Text</param>
        /// <param name="count">h type</param>
        /// <returns></returns>
        public string Hn(string text, int count)
        {
            return $"<h{count}>{text}</h{count}>";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string SingleText(string text)
        {
            return $"<p>{text}</p>";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string strong(string text)
        {
            return $"<strong>{text}</strong>";
        }



    }
}
