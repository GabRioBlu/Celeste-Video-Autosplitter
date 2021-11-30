﻿using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public class CelesteVideoAutoSplitterComponent : IComponent
    {
        public CelesteVideoAutoSplitterSettings Settings { get; set; }

        public string ComponentName => "Celeste Video Splitter";

        public float HorizontalWidth  { get { return 0; } }
        public float MinimumHeight { get { return 0; } }
        public float VerticalHeight { get { return 0; } }
        public float MinimumWidth { get { return 0; } }

        public float PaddingTop { get { return 0; } }
        public float PaddingBottom { get { return 0; } }
        public float PaddingLeft { get { return 0; } }
        public float PaddingRight { get { return 0; } }

        public IDictionary<string, Action> ContextMenuControls => null;

        public CelesteVideoAutoSplitterComponent(LiveSplitState state)
        {

        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion) {}

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion) {}

        public Control GetSettingsControl(LayoutMode mode)
        {
            Settings.Mode = mode;
            return Settings;
        }

        public System.Xml.XmlNode GetSettings(System.Xml.XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public void SetSettings(System.Xml.XmlNode settings)
        {
            Settings.SetSettings(settings);
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            
        }

        public void Dispose()
        {
            
        }
    }
}