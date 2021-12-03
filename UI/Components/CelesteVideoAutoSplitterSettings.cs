using LiveSplit.ComponentUtil;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Linq;
using System.Diagnostics;

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
            return SettingsHelper.CreateSetting(document, parent, "Version", "0.1") ^
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
            Trace.WriteLine("does this ever... even happen?");
            for (int i = 0; i < UsedSplits.Count; i++)
            {
                Trace.WriteLine(UsedSplits.ElementAt(i));
            }
            LoadSplits();
            Trace.WriteLine("does it make it all the way through??");
        }

        private void LoadSplits()
        {
            if (UsedSplits == null)
            {
                UsedSplits = new List<VideoSplit>();
            }

            this.splitsPanel.Controls.Clear();

            for (int i = 0; i < UsedSplits.Count; i++)
            {
                ComboBox splitTypeBox = new ComboBox()
                {
                    Anchor = AnchorStyles.Top | AnchorStyles.Left,
                    Location = new Point(0, i * 25),
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Size = new Size(250, 21),
                    Name = "splitTypeBox" + i
                };

                VideoSplit[] splits = SplitInit.possibleSplits.ToArray();
                string[] names = new string[splits.Length];

                for (int ii = 0; ii < splits.Length; ii++)
                {
                    names[ii] = splits[ii].description;

                }

                splitTypeBox.Items.AddRange(names);
                splitTypeBox.Text = UsedSplits.ElementAt(i).description;

                CheckBox startTimerBox = new CheckBox()
                {
                    Text = "Start Timer",
                    Anchor = AnchorStyles.Top | AnchorStyles.Left,
                    Location = new Point(379, i * 25),
                    Checked = UsedSplits.ElementAt(i).startTimer,
                    Name = "startTimerBox" + i
                };
                CheckBox splitTimerBox = new CheckBox()
                {
                    Text = "Split Timer",
                    Anchor = AnchorStyles.Top | AnchorStyles.Left,
                    Location = new Point(504, i * 25),
                    Checked = UsedSplits.ElementAt(i).splitTimer,
                    Name = "splitTimerBox" + i
                };
                CheckBox pauseTimerBox = new CheckBox()
                {
                    Text = "Pause Timer",
                    Anchor = AnchorStyles.Top | AnchorStyles.Left,
                    Location = new Point(629, i * 25),
                    Checked = UsedSplits.ElementAt(i).pauseTimer,
                    Name = "pauseTimerBox" + i
                };

                Button removeSplitButton = new Button()
                {
                    Anchor = AnchorStyles.Top | AnchorStyles.Left,
                    Location = new Point(254, i * 25),
                    Text = "Remove Split",
                    Name = "removeSplitButton" + i
                };

                splitTypeBox.SelectionChangeCommitted += SplitTypeBox_CommitSelection;
                startTimerBox.Click += StartButton_Click;
                splitTimerBox.Click += SplitButton_Click;
                pauseTimerBox.Click += PauseButton_Click;
                removeSplitButton.Click += RemoveSplitButton_Click;


                this.splitsPanel.Controls.Add(splitTypeBox);
                this.splitsPanel.Controls.Add(startTimerBox);
                this.splitsPanel.Controls.Add(splitTimerBox);
                this.splitsPanel.Controls.Add(pauseTimerBox);
                this.splitsPanel.Controls.Add(removeSplitButton);
            }
        }

        private void CelesteVideoAutoSplitterSettings_Load(object sender, EventArgs e)
        {

        }

        private void SplitTypeBox_CommitSelection(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int splitIndex = comboBox.Location.Y / 25;
            UsedSplits.ElementAt(splitIndex).description = comboBox.Text;
            UsedSplits.ElementAt(splitIndex).startTimer = SplitInit.possibleSplits.Find(split => split.description == comboBox.Text).startTimer;
            UsedSplits.ElementAt(splitIndex).splitTimer = SplitInit.possibleSplits.Find(split => split.description == comboBox.Text).splitTimer;
            UsedSplits.ElementAt(splitIndex).pauseTimer = SplitInit.possibleSplits.Find(split => split.description == comboBox.Text).pauseTimer;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int splitIndex = checkBox.Location.Y / 25;
            UsedSplits.ElementAt(splitIndex).startTimer = checkBox.Checked;
        }

        private void SplitButton_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int splitIndex = checkBox.Location.Y / 25;
            UsedSplits.ElementAt(splitIndex).splitTimer = checkBox.Checked;
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int splitIndex = checkBox.Location.Y / 25;
            UsedSplits.ElementAt(splitIndex).pauseTimer = checkBox.Checked;
        }

        private void RemoveSplitButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int splitIndex = button.Location.Y / 25;
            this.splitsPanel.Controls.RemoveByKey("splitTypeBox" + splitIndex);
            this.splitsPanel.Controls.RemoveByKey("startTimerBox" + splitIndex);
            this.splitsPanel.Controls.RemoveByKey("splitTimerBox" + splitIndex);
            this.splitsPanel.Controls.RemoveByKey("pauseTimerBox" + splitIndex);

            if (UsedSplits.Count - splitIndex > 0)
            {
                for (int i = splitIndex + 1; i < UsedSplits.Count; i++)
                {
                    Trace.WriteLine("name: splitTypeBox" + i);

                    this.splitsPanel.Controls.Find("splitTypeBox" + i, true)[0].Location = new Point()
                    {
                        X = this.splitsPanel.Controls.Find("splitTypeBox" + i, true)[0].Location.X,
                        Y = this.splitsPanel.Controls.Find("splitTypeBox" + i, true)[0].Location.Y - 25
                    };
                    this.splitsPanel.Controls.Find("splitTypeBox" + i, true)[0].Name = "splitTypeBox" + (i - 1);
                    this.splitsPanel.Controls.Find("startTimerBox" + i, true)[0].Location = new Point()
                    {
                        X = this.splitsPanel.Controls.Find("startTimerBox" + i, true)[0].Location.X,
                        Y = this.splitsPanel.Controls.Find("startTimerBox" + i, true)[0].Location.Y - 25
                    };
                    this.splitsPanel.Controls.Find("startTimerBox" + i, true)[0].Name = "startTimerBox" + (i - 1);
                    this.splitsPanel.Controls.Find("splitTimerBox" + i, true)[0].Location = new Point()
                    {
                        X = this.splitsPanel.Controls.Find("splitTimerBox" + i, true)[0].Location.X,
                        Y = this.splitsPanel.Controls.Find("splitTimerBox" + i, true)[0].Location.Y - 25
                    };
                    this.splitsPanel.Controls.Find("splitTimerBox" + i, true)[0].Name = "splitTimerBox" + (i - 1);
                    this.splitsPanel.Controls.Find("pauseTimerBox" + i, true)[0].Location = new Point()
                    {
                        X = this.splitsPanel.Controls.Find("pauseTimerBox" + i, true)[0].Location.X,
                        Y = this.splitsPanel.Controls.Find("pauseTimerBox" + i, true)[0].Location.Y - 25
                    };
                    this.splitsPanel.Controls.Find("pauseTimerBox" + i, true)[0].Name = "pauseTimerBox" + (i - 1);
                    this.splitsPanel.Controls.Find("removeSplitButton" + i, true)[0].Location = new Point()
                    {
                        X = this.splitsPanel.Controls.Find("removeSplitButton" + i, true)[0].Location.X,
                        Y = this.splitsPanel.Controls.Find("removeSplitButton" + i, true)[0].Location.Y - 25
                    };
                    this.splitsPanel.Controls.Find("removeSplitButton" + i, true)[0].Name = "removeSplitButton" + (i - 1);
                }
            }

            UsedSplits.RemoveAt(splitIndex);

            this.splitsPanel.Controls.Remove(button);
        }

        private void btnAddSplit_Click(object sender, EventArgs e)
        {
            Trace.WriteLine("hm");
            if (UsedSplits == null)
            {
                UsedSplits = new List<VideoSplit>();
            }
            
            if (UsedSplits.Count > 0)
            {
                if (UsedSplits.Count < SplitInit.possibleSplits.Count)
                {
                    UsedSplits.Add(new VideoSplit()
                    {
                        description = SplitInit.possibleSplits.ElementAt(SplitInit.possibleSplits.IndexOf
                    (SplitInit.possibleSplits.Find(split => split.description == UsedSplits.ElementAt(UsedSplits.Count - 1)
                    .description)) + 1).description,
                        startTimer = SplitInit.possibleSplits.ElementAt(SplitInit.possibleSplits.IndexOf
                    (SplitInit.possibleSplits.Find(split => split.description == UsedSplits.ElementAt(UsedSplits.Count - 1)
                    .description)) + 1).startTimer,
                        splitTimer = SplitInit.possibleSplits.ElementAt(SplitInit.possibleSplits.IndexOf
                    (SplitInit.possibleSplits.Find(split => split.description == UsedSplits.ElementAt(UsedSplits.Count - 1)
                    .description)) + 1).splitTimer,
                        pauseTimer = SplitInit.possibleSplits.ElementAt(SplitInit.possibleSplits.IndexOf
                    (SplitInit.possibleSplits.Find(split => split.description == UsedSplits.ElementAt(UsedSplits.Count - 1)
                    .description)) + 1).pauseTimer
                    });
                }
                else
                {
                    UsedSplits.Add(SplitInit.possibleSplits.Last());
                }
            }
            else
            {
                UsedSplits.Add(SplitInit.possibleSplits.First());
            }

            Trace.WriteLine("does it add a split?");

            int comboBoxYPos = (UsedSplits.Count - 1) * 25;
            Trace.WriteLine("combobox pos calculated");

            int splitCount = UsedSplits.Count - 1;

            Trace.WriteLine("name: splitTypeBox" + splitCount);

            ComboBox splitTypeBox = new ComboBox()
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Location = new Point(0, comboBoxYPos),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Size = new Size(250, 21),
                Name = "splitTypeBox" + splitCount
            };

            Trace.WriteLine("splitTypeBox created");

            VideoSplit[] splits = SplitInit.possibleSplits.ToArray();
            string[] names = new string[splits.Length];

            for (int i = 0; i < splits.Length; i++)
            {
                names[i] = splits[i].description;
            }

            splitTypeBox.Items.AddRange(names);

            splitTypeBox.SelectionChangeCommitted += SplitTypeBox_CommitSelection;

            splitTypeBox.Text = UsedSplits.Last().description;

            Trace.WriteLine("splitTypeBox fully done");

            this.splitsPanel.Controls.Add(splitTypeBox);

            int checkBoxYPos = (UsedSplits.Count - 1) * 25;

            CheckBox startTimerBox = new CheckBox()
            {
                Text = "Start Timer",
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Location = new Point(379, checkBoxYPos),
                Checked = UsedSplits.Last().startTimer,
                Name = "startTimerBox" + splitCount
            };
            CheckBox splitTimerBox = new CheckBox()
            {
                Text = "Split Timer",
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Location = new Point(504, checkBoxYPos),
                Checked = UsedSplits.Last().splitTimer,
                Name = "splitTimerBox" + splitCount
            };
            CheckBox pauseTimerBox = new CheckBox()
            {
                Text = "Pause Timer",
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Location = new Point(629, checkBoxYPos),
                Checked = UsedSplits.Last().pauseTimer,
                Name = "pauseTimerBox" + splitCount
            };

            Trace.WriteLine("checkboxes created");

            Button removeSplitButton = new Button()
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Left,
                Location = new Point(254, comboBoxYPos),
                Text = "Remove Split",
                Name = "removeSplitButton" + splitCount
            };

            Trace.WriteLine("button created");

            startTimerBox.Click += StartButton_Click;
            splitTimerBox.Click += SplitButton_Click;
            pauseTimerBox.Click += PauseButton_Click;
            removeSplitButton.Click += RemoveSplitButton_Click;

            this.splitsPanel.Controls.Add(startTimerBox);
            this.splitsPanel.Controls.Add(splitTimerBox);
            this.splitsPanel.Controls.Add(pauseTimerBox);
            this.splitsPanel.Controls.Add(removeSplitButton);
        }
    }
}
