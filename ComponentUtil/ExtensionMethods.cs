using System;
using System.Collections.Generic;
using System.Xml;
using LiveSplit.UI;
using System.Diagnostics;

namespace LiveSplit.ComponentUtil
{
    public class VideoSplitterSettingsHelper : SettingsHelper
    {
        public static int CreateSetting(XmlDocument document, XmlElement parent, string name, List<VideoSplit> videoSplits)
        {
            int hashCode = 53;
            if (document != null)
            {
                if (videoSplits != null)
                {
                    foreach (VideoSplit split in videoSplits)
                    {
                        var element = document.CreateElement(name);
                        element.InnerText = split.ToString();
                        parent.AppendChild(element);
                        hashCode = hashCode * 61 + split.GetHashCode();
                    }
                }
            }

            return hashCode;
        }

        public static List<VideoSplit> ParseVideoSplitList(XmlElement videoSplitElement)
        {
            List<VideoSplit> videoSplits = new List<VideoSplit>();

            if (videoSplitElement != null)
            {
                foreach (XmlElement split in videoSplitElement.ChildNodes)
                {
                    videoSplits.Add(VideoSplit.Parse(split.InnerText));
                }
            }

            return videoSplits;
        }
    }
}
