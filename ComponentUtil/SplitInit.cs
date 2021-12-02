using System;
using System.Collections.Generic;

namespace LiveSplit.ComponentUtil
{
    public static class SplitInit
    {
        public static List<VideoSplit> possibleSplits = new List<VideoSplit>();

        public static void InitSplits()
        {
            possibleSplits.Add(new VideoSplit()
            {
                description = "Prologue (Start)",
                startTimer = true,
                splitTimer = false,
                pauseTimer = false,
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Prologue (Complete)",
                startTimer = false,
                splitTimer = false,
                pauseTimer = true,
            });

            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 1 - Forsaken City A-Side (Start)",
                startTimer = true,
                splitTimer = true,
                pauseTimer = false,
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 1 - Forsaken City A-Side (Crossing)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 1 - Forsaken City A-Side (Chasm)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 1 - Forsaken City A-Side (Complete)",
                startTimer = false,
                splitTimer = false,
                pauseTimer = true
            });

            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 2 - Old Site A-Side (Start)",
                startTimer = true,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 2 - Old Site A-Side (Intervention)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 2 - Old Site A-Side (Awake)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 2 - Old Site A-Side (Complete)",
                startTimer = false,
                splitTimer = false,
                pauseTimer = true
            });

            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 3 - Celestial Resort A-Side (Start)",
                startTimer = true,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 3 - Celestial Resort A-Side (Huge Mess)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 3 - Celestial Resort A-Side (Elevator Shaft)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 3 - Celestial Resort A-Side (Presidential Suite)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 3 - Celestial Resort A-Side (Complete)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = true
            });

            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 4 - Golden Ridge A-Side (Start)",
                startTimer = true,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 4 - Golden Ridge A-Side (Shrine)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 4 - Golden Ridge A-Side (Old Trail)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 4 - Golden Ridge A-Side (Cliff Face)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 4 - Golden Ridge A-Side (Complete)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = true
            });

            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 5 - Mirror Temple A-Side (Start)",
                startTimer = true,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 5 - Mirror Temple A-Side (Depths)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 5 - Mirror Temple A-Side (Unravelling)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 5 - Mirror Temple A-Side (Search)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 5 - Mirror Temple A-Side (Rescue)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 5 - Mirror Temple A-Side (Complete)",
                startTimer = false,
                splitTimer = false,
                pauseTimer = true
            });

            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 6 - Reflection A-Side (Start)",
                startTimer = true,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 6 - Reflection A-Side (Lake)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 6 - Reflection A-Side (Hollows)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 6 - Reflection A-Side (Reflection)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 6 - Reflection A-Side (Rock Bottom)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 6 - Reflection A-Side (Resolution)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 6 - Reflection A-Side (Complete)",
                startTimer = false,
                splitTimer = false,
                pauseTimer = true
            });

            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 7 - The Summit A-Side (Start)",
                startTimer = true,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 7 - The Summit A-Side (500M)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 7 - The Summit A-Side (1000M)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 7 - The Summit A-Side (1500M)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 7 - The Summit A-Side (2000M)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 7 - The Summit A-Side (2500M)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 7 - The Summit A-Side (3000M)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 7 - The Summit A-Side (Complete)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });

            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 8 - Core A-Side (Start)",
                startTimer = true,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 8 - Core A-Side (Into the Core)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 8 - Core A-Side (Hot and Cold)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 8 - Core A-Side (Heart of the Mountain)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 8 - Core A-Side (Complete)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = true
            });

            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 9 - Farewell (Start)",
                startTimer = true,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 9 - Farewell (Singular)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 9 - Farewell (Power Source)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 9 - Farewell (Remembered)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 9 - Farewell (Event Horizon)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 9 - Farewell (Determination)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 9 - Farewell (Stubbornness)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 9 - Farewell (Reconciliation)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 9 - Farewell (Farewell)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
            possibleSplits.Add(new VideoSplit()
            {
                description = "Chapter 9 - Farewell (Complete)",
                startTimer = false,
                splitTimer = true,
                pauseTimer = false
            });
        }
    }
}
