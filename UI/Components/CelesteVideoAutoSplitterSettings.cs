using LiveSplit.ComponentUtil;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Linq;

namespace LiveSplit.UI.Components
{
    public partial class CelesteVideoAutoSplitterSettings : UserControl
    {
        public List<VideoSplit> UsedSplits { get; set; }

        public LayoutMode Mode { get; set; }

        public CelesteVideoAutoSplitterSettings()
        {
            InitializeComponent();
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "1.0") ^
                VideoSplitterSettingsHelper.CreateSetting(document, parent, "UsedSplits", UsedSplits);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement)node;
            UsedSplits = VideoSplitterSettingsHelper.ParseVideoSplitList(element["UsedSplits"]);
        }


        private List<VideoSplit> allSplits = new List<VideoSplit>();

        private void CelesteVideoAutoSplitterSettings_Load(object sender, EventArgs e)
        {
            allSplits = SplitInit.possibleSplits;

            for (int i = 0; i < UsedSplits.Count; i++)
            {
                ComboBox splitTypeBox = new ComboBox()
                {
                    Text = UsedSplits.ElementAt(i).description,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left,
                    Location = new Point(0, i * 25),
                    DropDownStyle = ComboBoxStyle.DropDownList
                };

                VideoSplit[] splits = allSplits.ToArray();
                string[] names = new string[splits.Length];

                for (int ii = 0; ii < splits.Length; ii++)
                {
                    names[ii] = splits[ii].description;
                }

                splitTypeBox.Items.AddRange(names);

                CheckBox startTimerBox = new CheckBox()
                {
                    Text = "Start Timer",
                    Anchor = AnchorStyles.Top | AnchorStyles.Left,
                    Location = new Point(125, i * 25 + 3),
                    Checked = UsedSplits.ElementAt(i).startTimer
                };
                CheckBox splitTimerBox = new CheckBox()
                {
                    Text = "Split Timer",
                    Anchor = AnchorStyles.Top | AnchorStyles.Left,
                    Location = new Point(205, i * 25 + 3),
                    Checked = UsedSplits.ElementAt(i).splitTimer
                };
                CheckBox pauseTimerBox = new CheckBox()
                {
                    Text = "Pause Timer",
                    Anchor = AnchorStyles.Top | AnchorStyles.Left,
                    Location = new Point(285, i * 25 + 3),
                    Checked = UsedSplits.ElementAt(i).pauseTimer
                };

                splitTypeBox.SelectionChangeCommitted += SplitTypeBox_CommitSelection;
                startTimerBox.Click += StartButton_Click;
                splitTimerBox.Click += SplitButton_Click;
                pauseTimerBox.Click += PauseButton_Click;


                this.splitsPanel.Controls.Add(splitTypeBox);
                this.splitsPanel.Controls.Add(startTimerBox);
                this.splitsPanel.Controls.Add(splitTimerBox);
                this.splitsPanel.Controls.Add(pauseTimerBox);
            }
        }

        private void SplitTypeBox_CommitSelection(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int splitIndex = comboBox.Location.Y / 25;
            UsedSplits.ElementAt(splitIndex).description = comboBox.Text;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int splitIndex = (checkBox.Location.Y - 3) / 25;
            UsedSplits.ElementAt(splitIndex).startTimer = checkBox.Checked;
        }

        private void SplitButton_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int splitIndex = (checkBox.Location.Y - 3) / 25;
            UsedSplits.ElementAt(splitIndex).splitTimer = checkBox.Checked;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int splitIndex = (checkBox.Location.Y - 3) / 25;
            UsedSplits.ElementAt(splitIndex).pauseTimer = checkBox.Checked;
        }

        private void btnAddSplit_Click(object sender, EventArgs e)
        {
            ComboBox splitTypeBox = new ComboBox()
            {
                Text = "Prologue (Start)",
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Location = new Point(0, UsedSplits.Count * 25),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            
            VideoSplit[] splits = allSplits.ToArray();
            string[] names = new string[splits.Length];

            for (int i = 0; i < splits.Length; i++)
            {
                names[i] = splits[i].description;
            }

            splitTypeBox.Items.AddRange(names);

            splitTypeBox.SelectionChangeCommitted += SplitTypeBox_CommitSelection;

            this.splitsPanel.Controls.Add(splitTypeBox);

            CheckBox startTimerBox = new CheckBox()
            {
                Text = "Start Timer",
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Location = new Point(125, UsedSplits.Count * 25 + 3),
                Checked = false
            };
            CheckBox splitTimerBox = new CheckBox()
            {
                Text = "Split Timer",
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Location = new Point(205, UsedSplits.Count * 25 + 3),
                Checked = false
            };
            CheckBox pauseTimerBox = new CheckBox()
            {
                Text = "Pause Timer",
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Location = new Point(285, UsedSplits.Count * 25 + 3),
                Checked = false
            };

            startTimerBox.Click += StartButton_Click;
            splitTimerBox.Click += SplitButton_Click;
            pauseTimerBox.Click += PauseButton_Click;

            this.splitsPanel.Controls.Add(startTimerBox);
            this.splitsPanel.Controls.Add(splitTimerBox);
            this.splitsPanel.Controls.Add(pauseTimerBox);
        }
    }
}
