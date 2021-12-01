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
                splitImage = new SplitImage()
                {
                    imageName = "PrologueStart",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Prologue (Start)",
                    startTimer = true,
                    splitTimer = false,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "PrologueComplete",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Prologue (Complete)",
                    startTimer = false,
                    splitTimer = false,
                    pauseTimer = true
                }
            });

            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "ForsakenCityAStart",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 1 - Forsaken City A-Side (Start)",
                    startTimer = true,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "ForsakenCityACrossing",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 1 - Forsaken City A-Side (Crossing)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "ForsakenCityAChasm",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 1 - Forsaken City A-Side (Chasm)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "ForsakenCityAComplete",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 1 - Forsaken City A-Side (Complete)",
                    startTimer = false,
                    splitTimer = false,
                    pauseTimer = true
                }
            });

            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "OldSiteAStart",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 2 - Old Site A-Side (Start)",
                    startTimer = true,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "OldSiteAIntervention",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 2 - Old Site A-Side (Intervention)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "OldSiteAAwake",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 2 - Old Site A-Side (Awake)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "OldSiteAComplete",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 2 - Old Site A-Side (Complete)",
                    startTimer = false,
                    splitTimer = false,
                    pauseTimer = true
                }
            });

            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "CelestialResortAStart",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 3 - Celestial Resort A-Side (Start)",
                    startTimer = true,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "CelestialResortAHugeMess",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 3 - Celestial Resort A-Side (Huge Mess)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "CelestialResortAElevatorShaft",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 3 - Celestial Resort A-Side (Elevator Shaft)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "CelestialResortAPresidentialSuite",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 3 - Celestial Resort A-Side (Presidential Suite)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "CelestialResortAComplete",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 3 - Celestial Resort A-Side (Complete)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = true
                }
            });

            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "GoldenRidgeAStart",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 4 - Golden Ridge A-Side (Start)",
                    startTimer = true,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "GoldenRidgeAShrine",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 4 - Golden Ridge A-Side (Shrine)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "GoldenRidgeAOldTrail",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 4 - Golden Ridge A-Side (Old Trail)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "GoldenRidgeACliffFace",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 4 - Golden Ridge A-Side (Cliff Face)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "GoldenRidgeAComplete",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 4 - Golden Ridge A-Side (Complete)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = true
                }
            });

            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "MirrorTempleAStart",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 5 - Mirror Temple A-Side (Start)",
                    startTimer = true,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "MirrorTempleADepths",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 5 - Mirror Temple A-Side (Depths)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "MirrorTempleAUnravelling",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 5 - Mirror Temple A-Side (Unravelling)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "MirrorTempleASearch",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 5 - Mirror Temple A-Side (Search)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "MirrorTempleARescue",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 5 - Mirror Temple A-Side (Rescue)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "MirrorTempleAComplete",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 5 - Mirror Temple A-Side (Complete)",
                    startTimer = false,
                    splitTimer = false,
                    pauseTimer = true
                }
            });

            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "ReflectionAStart",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 6 - Reflection A-Side (Start)",
                    startTimer = true,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "ReflectionALake",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 6 - Reflection A-Side (Lake)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "ReflectionAHollows",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 6 - Reflection A-Side (Hollows)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "ReflectionAReflection",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 6 - Reflection A-Side (Reflection)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "ReflectionARockBottom",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 6 - Reflection A-Side (Rock Bottom)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "ReflectionAResolution",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 6 - Reflection A-Side (Resolution)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "ReflectionAComplete",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 6 - Reflection A-Side (Complete)",
                    startTimer = false,
                    splitTimer = false,
                    pauseTimer = true
                }
            });

            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "SummitAStart",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 7 - The Summit A-Side (Start)",
                    startTimer = true,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "SummitA500M",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 7 - The Summit A-Side (500M)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "SummitA1000M",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 7 - The Summit A-Side (1000M)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "SummitA1500M",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 7 - The Summit A-Side (1500M)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "SummitA2000M",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 7 - The Summit A-Side (2000M)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "SummitA2500M",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 7 - The Summit A-Side (2500M)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "SummitA3000M",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 7 - The Summit A-Side (3000M)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "SummitAComplete",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 7 - The Summit A-Side (Complete)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });

            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "CoreAStart",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 8 - Core A-Side (Start)",
                    startTimer = true,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "CoreAIntoTheCore",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 8 - Core A-Side (Into the Core)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "CoreAHotAndCold",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 8 - Core A-Side (Hot and Cold)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "CoreAHeartOfTheMountain",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 8 - Core A-Side (Heart of the Mountain)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "CoreAComplete",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 8 - Core A-Side (Complete)",
                    startTimer = false,
                    splitTimer = false,
                    pauseTimer = true
                }
            });

            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "FarewellStart",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 9 - Farewell (Start)",
                    startTimer = true,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "FarewellSingular",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 9 - Farewell (Singular)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "FarewellPowerSource",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 9 - Farewell (Power Source)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "FarewellRemembered",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 9 - Farewell (Remembered)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "FarewellEventHorizon",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 9 - Farewell (Event Horizon)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "FarewellDetermination",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 9 - Farewell (Determination)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "FarewellStubbornness",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 9 - Farewell (Stubbornness)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "FarewellReconciliation",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 9 - Farewell (Reconciliation)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "FarewellFarewell",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 9 - Farewell (Farewell)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
            possibleSplits.Add(new VideoSplit()
            {
                splitImage = new SplitImage()
                {
                    imageName = "FarewellComplete",
                    gameWidth = 1920,
                    gameHeight = 1080,
                    imageXOffset = 0,
                    imageYOffset = 0
                },
                splitType = new SplitType()
                {
                    description = "Chapter 9 - Farewell (Complete)",
                    startTimer = false,
                    splitTimer = true,
                    pauseTimer = false
                }
            });
        }
    }
}
