
namespace LiveSplit.UI.Components
{
    partial class CelesteVideoAutoSplitterSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddSplit = new System.Windows.Forms.Button();
            this.splitsPanel = new System.Windows.Forms.Panel();
            this.mainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.AutoSize = true;
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.splitsPanel, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.btnAddSplit, 0, 1);
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 2;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(536, 357);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // btnAddSplit
            // 
            this.btnAddSplit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddSplit.Location = new System.Drawing.Point(6, 327);
            this.btnAddSplit.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.btnAddSplit.Name = "btnAddSplit";
            this.btnAddSplit.Size = new System.Drawing.Size(75, 25);
            this.btnAddSplit.TabIndex = 0;
            this.btnAddSplit.Text = "Add Split";
            this.btnAddSplit.UseVisualStyleBackColor = true;
            this.btnAddSplit.Click += new System.EventHandler(this.btnAddSplit_Click);
            // 
            // splitsPanel
            // 
            this.splitsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitsPanel.AutoSize = true;
            this.splitsPanel.Location = new System.Drawing.Point(3, 3);
            this.splitsPanel.Name = "splitsPanel";
            this.splitsPanel.Size = new System.Drawing.Size(530, 316);
            this.splitsPanel.TabIndex = 1;
            // 
            // CelesteVideoAutoSplitterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "CelesteVideoAutoSplitterSettings";
            this.Size = new System.Drawing.Size(539, 360);
            this.Load += new System.EventHandler(this.CelesteVideoAutoSplitterSettings_Load);
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.Button btnAddSplit;
        private System.Windows.Forms.Panel splitsPanel;
    }
}
