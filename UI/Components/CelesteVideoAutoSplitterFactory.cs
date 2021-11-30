using LiveSplit.Model;
using System;

namespace LiveSplit.UI.Components
{
    class CelesteVideoAutoSplitterFactory : IComponentFactory
    {
        public string ComponentName => "Celeste Video Splitter";

        public string Description => "A Microsoft Store compatible Celeste autospliitter! Yay!!";

        public ComponentCategory Category => ComponentCategory.Control;

        public IComponent Create(LiveSplitState state) => new CelesteVideoAutoSplitterComponent(state);

        public string UpdateName => ComponentName;

        public string UpdateURL => "https://github.com/GabRioBlu/Celeste-Video-Autosplitter";

        public string XMLURL => "";

        public Version Version => Version.Parse("0.0.1");
    }
}
