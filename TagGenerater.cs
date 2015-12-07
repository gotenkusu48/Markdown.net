using System;

namespace MarkDown
{

    public class TagGenerater
    {
        public enum TagType
        {
            H1, H2, H3, H4, H5,
            P, Strong
        }

        public enum LinkType
        {
            Page, Mail, Application
        }

        public class TagInfo
        {
            public TagType TagType { get; set; }
            public string Text { get; set; } = "";
            public string Link { get; set; } = "";
        }

        public static string TagGenerate(TagInfo info)
        {
            switch (info.TagType)
            {
                case TagType.H1:
                    return Hn(info, 1);

                case TagType.H2:
                    return Hn(info, 2);

                case TagType.H3:
                    return Hn(info, 3);

                case TagType.H4:
                    return Hn(info, 4);

                case TagType.H5:
                    return Hn(info, 5);

                case TagType.P:
                    return SingleText(info);

                case TagType.Strong:
                    return Strong(info);

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// this is a generate for h TAG
        /// </summary>
        /// <param name="info"></param>
        /// <param name="count">h type</param>
        /// <returns></returns>
        public static string Hn(TagInfo info, int count)
        {
            return $"<h{count}>{info.Text}</h{count}>";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static string SingleText(TagInfo info)
        {
            return $"<p>{info.Text}</p>";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static string Strong(TagInfo info)
        {
            return $"<strong>{info.Text}</strong>";
        }
    }
}
