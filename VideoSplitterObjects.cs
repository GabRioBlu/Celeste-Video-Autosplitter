using System;
using System.Drawing;
using System.ComponentModel;

namespace LiveSplit.ComponentUtil
{
    public class SplitType
    {
        public string description;
        public bool startTimer, splitTimer, pauseTimer, resumeTimer;
    }

    public class SplitImage
    {
        public string imageName;
        public int gameWidth;
        public int gameHeight;
        public int imageXOffset;
        public int imageYOffset;
    }

    public class VideoSplit
    {
        public SplitImage splitImage;
        public SplitType splitType;
        public int splitIndex;
    }
}