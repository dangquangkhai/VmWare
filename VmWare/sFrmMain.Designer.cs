namespace VmWare
{
    partial class sFrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sFrmMain));
            this.sBtnStart = new MetroFramework.Controls.MetroButton();
            this.sBtnStop = new MetroFramework.Controls.MetroButton();
            this.sBtnOpen = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sLogBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sBtnCopy = new System.Windows.Forms.Button();
            this.sBtnClear = new System.Windows.Forms.Button();
            this.sTooltip = new MetroFramework.Components.MetroToolTip();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sBtnStart
            // 
            this.sBtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sBtnStart.Location = new System.Drawing.Point(60, 71);
            this.sBtnStart.Name = "sBtnStart";
            this.sBtnStart.Size = new System.Drawing.Size(138, 45);
            this.sBtnStart.TabIndex = 0;
            this.sBtnStart.Text = "Start Services";
            this.sBtnStart.Click += new System.EventHandler(this.sBtnStart_Click);
            // 
            // sBtnStop
            // 
            this.sBtnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sBtnStop.Location = new System.Drawing.Point(310, 71);
            this.sBtnStop.Name = "sBtnStop";
            this.sBtnStop.Size = new System.Drawing.Size(144, 45);
            this.sBtnStop.TabIndex = 2;
            this.sBtnStop.Text = "Stop Services";
            this.sBtnStop.Click += new System.EventHandler(this.sBtnStop_Click);
            // 
            // sBtnOpen
            // 
            this.sBtnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sBtnOpen.Location = new System.Drawing.Point(566, 71);
            this.sBtnOpen.Name = "sBtnOpen";
            this.sBtnOpen.Size = new System.Drawing.Size(138, 45);
            this.sBtnOpen.TabIndex = 3;
            this.sBtnOpen.Text = "Open VM Workstation";
            this.sBtnOpen.Click += new System.EventHandler(this.sBtnOpen_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.sBtnOpen);
            this.metroPanel1.Controls.Add(this.sBtnStop);
            this.metroPanel1.Controls.Add(this.sBtnStart);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(757, 202);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 321);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.sLogBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 281);
            this.panel3.TabIndex = 1;
            // 
            // sLogBox
            // 
            this.sLogBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.sLogBox.Cursor = System.Windows.Forms.Cursors.No;
            this.sLogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sLogBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLogBox.Location = new System.Drawing.Point(0, 0);
            this.sLogBox.Name = "sLogBox";
            this.sLogBox.Size = new System.Drawing.Size(753, 279);
            this.sLogBox.TabIndex = 0;
            this.sLogBox.Text = "";
            this.sLogBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sLogBox_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.sBtnCopy);
            this.panel2.Controls.Add(this.sBtnClear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 38);
            this.panel2.TabIndex = 0;
            // 
            // sBtnCopy
            // 
            this.sBtnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sBtnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sBtnCopy.Image = global::VmWare.Properties.Resources.CopyLongTextToClipboard_16x;
            this.sBtnCopy.Location = new System.Drawing.Point(727, 4);
            this.sBtnCopy.Name = "sBtnCopy";
            this.sBtnCopy.Size = new System.Drawing.Size(23, 29);
            this.sBtnCopy.TabIndex = 1;
            this.sBtnCopy.UseVisualStyleBackColor = true;
            // 
            // sBtnClear
            // 
            this.sBtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sBtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sBtnClear.Image = global::VmWare.Properties.Resources.ClearWindowContent_16x_32;
            this.sBtnClear.Location = new System.Drawing.Point(698, 4);
            this.sBtnClear.Name = "sBtnClear";
            this.sBtnClear.Size = new System.Drawing.Size(23, 29);
            this.sBtnClear.TabIndex = 0;
            this.sBtnClear.UseVisualStyleBackColor = true;
            this.sBtnClear.Click += new System.EventHandler(this.sBtnClear_Click);
            // 
            // sFrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sFrmMain";
            this.Text = "VM Controller";
            this.metroPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton sBtnStart;
        private MetroFramework.Controls.MetroButton sBtnStop;
        private MetroFramework.Controls.MetroButton sBtnOpen;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sBtnClear;
        private System.Windows.Forms.RichTextBox sLogBox;
        private System.Windows.Forms.Button sBtnCopy;
        private MetroFramework.Components.MetroToolTip sTooltip;
    }
}

