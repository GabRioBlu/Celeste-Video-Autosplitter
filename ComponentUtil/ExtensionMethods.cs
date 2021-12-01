using System;
using System.Collections.Generic;
using System.Xml;
using LiveSplit.UI;

namespace LiveSplit.ComponentUtil
{
    public class VideoSplitterSettingsHelper : SettingsHelper
    {
        public static int CreateSetting(XmlDocument document, XmlElement parent, string name, List<VideoSplit> videoSplits)
        {
            int hashCode = 0;

            if (document != null)
            {
                foreach (VideoSplit split in videoSplits)
                {
                    var element = document.CreateElement(name);
                    element.InnerText = split.ToString();
                    parent.AppendChild(element);
                    hashCode ^= split.GetHashCode();
                }
            }

            return hashCode;
        }

        public static List<VideoSplit> ParseVideoSplitList(XmlElement videoSplitElement)
        {
            List<VideoSplit> videoSplits = new List<VideoSplit>();

            foreach (XmlElement split in videoSplitElement.ChildNodes)
            {
                videoSplits.Add(VideoSplit.Parse(split.InnerText));
            }

            return videoSplits;
        }
    }
}
