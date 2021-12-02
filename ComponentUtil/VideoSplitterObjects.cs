﻿using System;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;

namespace LiveSplit.ComponentUtil
{
    public class VideoSplit
    {
        public string description;
        public bool startTimer, splitTimer, pauseTimer;

        public int splitIndex;

        public override string ToString()
        {
            return description + "," + startTimer.ToString() + "," + splitTimer.ToString() + "," + pauseTimer.ToString() + "," + splitIndex.ToString();
        }

        public override int GetHashCode()
        {
            int hashCode = -195936162;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(description);
            hashCode = hashCode * -1521134295 + startTimer.GetHashCode();
            hashCode = hashCode * -1521134295 + splitTimer.GetHashCode();
            hashCode = hashCode * -1521134295 + pauseTimer.GetHashCode();
            hashCode = hashCode * -1521134295 + splitIndex.GetHashCode();
            return hashCode;
        }

        public static VideoSplit Parse(string videoSplitString)
        {
            return new VideoSplit()
            {
                description = videoSplitString.Split(',')[0],
                startTimer = bool.Parse(videoSplitString.Split(',')[1]),
                splitTimer = bool.Parse(videoSplitString.Split(',')[2]),
                pauseTimer = bool.Parse(videoSplitString.Split(',')[3]),
                splitIndex = int.Parse(videoSplitString.Split(',')[4])
            };
        }
    }

    public class Colour
    {
        public int blue;
        public int green;
        public int red;

        public float Compare(Colour colour2)
        {
            int blueDiff = Math.Abs(this.blue - colour2.blue);
            int greenDiff = Math.Abs(this.green - colour2.green);
            int redDiff = Math.Abs(this.red - colour2.red);

            float bluePercent = blueDiff / 255 * 100;
            float greenPercent = greenDiff / 255 * 100;
            float redPercent = redDiff / 255 * 100;

            return 100 - (bluePercent + greenPercent + redPercent) / 3;
        }
    }
}