
namespace BO2_ERROR_TRACKER {
    partial class TrackerMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.GB = new System.Windows.Forms.GroupBox();
            this.barFrameTime = new System.Windows.Forms.ProgressBar();
            this.barEnt = new System.Windows.Forms.ProgressBar();
            this.barSnapEnt = new System.Windows.Forms.ProgressBar();
            this.barXanSize = new System.Windows.Forms.ProgressBar();
            this.barXanNext = new System.Windows.Forms.ProgressBar();
            this.barChildSize = new System.Windows.Forms.ProgressBar();
            this.barChildNext = new System.Windows.Forms.ProgressBar();
            this.barParentSize = new System.Windows.Forms.ProgressBar();
            this.barParentNext = new System.Windows.Forms.ProgressBar();
            this.lbl_comFrametime = new System.Windows.Forms.Label();
            this.lbl_numEntities = new System.Windows.Forms.Label();
            this.lbl_SnapEntities = new System.Windows.Forms.Label();
            this.lbl_xanSize = new System.Windows.Forms.Label();
            this.lbl_xanNext = new System.Windows.Forms.Label();
            this.lbl_childSize = new System.Windows.Forms.Label();
            this.lbl_childNext = new System.Windows.Forms.Label();
            this.lbl_parentSize = new System.Windows.Forms.Label();
            this.lbl_parentNext = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.TimerProgress = new System.Windows.Forms.Timer(this.components);
            this.TimerFrameTime = new System.Windows.Forms.Timer(this.components);
            this.GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB
            // 
            this.GB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GB.Controls.Add(this.barFrameTime);
            this.GB.Controls.Add(this.barEnt);
            this.GB.Controls.Add(this.barSnapEnt);
            this.GB.Controls.Add(this.barXanSize);
            this.GB.Controls.Add(this.barXanNext);
            this.GB.Controls.Add(this.barChildSize);
            this.GB.Controls.Add(this.barChildNext);
            this.GB.Controls.Add(this.barParentSize);
            this.GB.Controls.Add(this.barParentNext);
            this.GB.Controls.Add(this.lbl_comFrametime);
            this.GB.Controls.Add(this.lbl_numEntities);
            this.GB.Controls.Add(this.lbl_SnapEntities);
            this.GB.Controls.Add(this.lbl_xanSize);
            this.GB.Controls.Add(this.lbl_xanNext);
            this.GB.Controls.Add(this.lbl_childSize);
            this.GB.Controls.Add(this.lbl_childNext);
            this.GB.Controls.Add(this.lbl_parentSize);
            this.GB.Controls.Add(this.lbl_parentNext);
            this.GB.Controls.Add(this.label7);
            this.GB.Controls.Add(this.label8);
            this.GB.Controls.Add(this.label9);
            this.GB.Controls.Add(this.label5);
            this.GB.Controls.Add(this.label6);
            this.GB.Controls.Add(this.label3);
            this.GB.Controls.Add(this.label4);
            this.GB.Controls.Add(this.label2);
            this.GB.Controls.Add(this.label1);
            this.GB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB.Location = new System.Drawing.Point(12, 12);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(572, 292);
            this.GB.TabIndex = 0;
            this.GB.TabStop = false;
            this.GB.Text = "Error Tracker Infos";
            // 
            // barFrameTime
            // 
            this.barFrameTime.Location = new System.Drawing.Point(338, 248);
            this.barFrameTime.Name = "barFrameTime";
            this.barFrameTime.Size = new System.Drawing.Size(212, 23);
            this.barFrameTime.TabIndex = 26;
            // 
            // barEnt
            // 
            this.barEnt.Location = new System.Drawing.Point(338, 219);
            this.barEnt.Name = "barEnt";
            this.barEnt.Size = new System.Drawing.Size(212, 23);
            this.barEnt.TabIndex = 25;
            // 
            // barSnapEnt
            // 
            this.barSnapEnt.Location = new System.Drawing.Point(338, 190);
            this.barSnapEnt.Name = "barSnapEnt";
            this.barSnapEnt.Size = new System.Drawing.Size(212, 23);
            this.barSnapEnt.TabIndex = 24;
            // 
            // barXanSize
            // 
            this.barXanSize.Location = new System.Drawing.Point(338, 160);
            this.barXanSize.Name = "barXanSize";
            this.barXanSize.Size = new System.Drawing.Size(212, 23);
            this.barXanSize.TabIndex = 23;
            // 
            // barXanNext
            // 
            this.barXanNext.Location = new System.Drawing.Point(338, 131);
            this.barXanNext.Name = "barXanNext";
            this.barXanNext.Size = new System.Drawing.Size(212, 23);
            this.barXanNext.TabIndex = 22;
            // 
            // barChildSize
            // 
            this.barChildSize.Location = new System.Drawing.Point(338, 102);
            this.barChildSize.Name = "barChildSize";
            this.barChildSize.Size = new System.Drawing.Size(212, 23);
            this.barChildSize.TabIndex = 21;
            // 
            // barChildNext
            // 
            this.barChildNext.Location = new System.Drawing.Point(338, 73);
            this.barChildNext.Name = "barChildNext";
            this.barChildNext.Size = new System.Drawing.Size(212, 23);
            this.barChildNext.TabIndex = 20;
            // 
            // barParentSize
            // 
            this.barParentSize.Location = new System.Drawing.Point(338, 44);
            this.barParentSize.Name = "barParentSize";
            this.barParentSize.Size = new System.Drawing.Size(212, 23);
            this.barParentSize.TabIndex = 19;
            // 
            // barParentNext
            // 
            this.barParentNext.Location = new System.Drawing.Point(338, 15);
            this.barParentNext.Name = "barParentNext";
            this.barParentNext.Size = new System.Drawing.Size(212, 23);
            this.barParentNext.TabIndex = 18;
            // 
            // lbl_comFrametime
            // 
            this.lbl_comFrametime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comFrametime.Location = new System.Drawing.Point(155, 254);
            this.lbl_comFrametime.Name = "lbl_comFrametime";
            this.lbl_comFrametime.Size = new System.Drawing.Size(166, 17);
            this.lbl_comFrametime.TabIndex = 17;
            this.lbl_comFrametime.Text = "100000000";
            this.lbl_comFrametime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_numEntities
            // 
            this.lbl_numEntities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numEntities.Location = new System.Drawing.Point(155, 223);
            this.lbl_numEntities.Name = "lbl_numEntities";
            this.lbl_numEntities.Size = new System.Drawing.Size(166, 17);
            this.lbl_numEntities.TabIndex = 16;
            this.lbl_numEntities.Text = "100000000";
            this.lbl_numEntities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SnapEntities
            // 
            this.lbl_SnapEntities.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SnapEntities.Location = new System.Drawing.Point(155, 196);
            this.lbl_SnapEntities.Name = "lbl_SnapEntities";
            this.lbl_SnapEntities.Size = new System.Drawing.Size(166, 17);
            this.lbl_SnapEntities.TabIndex = 15;
            this.lbl_SnapEntities.Text = "100000000";
            this.lbl_SnapEntities.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_xanSize
            // 
            this.lbl_xanSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_xanSize.Location = new System.Drawing.Point(155, 166);
            this.lbl_xanSize.Name = "lbl_xanSize";
            this.lbl_xanSize.Size = new System.Drawing.Size(166, 17);
            this.lbl_xanSize.TabIndex = 14;
            this.lbl_xanSize.Text = "100000000";
            this.lbl_xanSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_xanNext
            // 
            this.lbl_xanNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_xanNext.Location = new System.Drawing.Point(155, 137);
            this.lbl_xanNext.Name = "lbl_xanNext";
            this.lbl_xanNext.Size = new System.Drawing.Size(166, 17);
            this.lbl_xanNext.TabIndex = 13;
            this.lbl_xanNext.Text = "100000000";
            this.lbl_xanNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_childSize
            // 
            this.lbl_childSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_childSize.Location = new System.Drawing.Point(155, 108);
            this.lbl_childSize.Name = "lbl_childSize";
            this.lbl_childSize.Size = new System.Drawing.Size(166, 17);
            this.lbl_childSize.TabIndex = 12;
            this.lbl_childSize.Text = "100000000";
            this.lbl_childSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_childNext
            // 
            this.lbl_childNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_childNext.Location = new System.Drawing.Point(155, 79);
            this.lbl_childNext.Name = "lbl_childNext";
            this.lbl_childNext.Size = new System.Drawing.Size(166, 17);
            this.lbl_childNext.TabIndex = 11;
            this.lbl_childNext.Text = "100000000";
            this.lbl_childNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_parentSize
            // 
            this.lbl_parentSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parentSize.Location = new System.Drawing.Point(155, 49);
            this.lbl_parentSize.Name = "lbl_parentSize";
            this.lbl_parentSize.Size = new System.Drawing.Size(166, 17);
            this.lbl_parentSize.TabIndex = 10;
            this.lbl_parentSize.Text = "100000000";
            this.lbl_parentSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_parentNext
            // 
            this.lbl_parentNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parentNext.Location = new System.Drawing.Point(155, 21);
            this.lbl_parentNext.Name = "lbl_parentNext";
            this.lbl_parentNext.Size = new System.Drawing.Size(166, 17);
            this.lbl_parentNext.TabIndex = 9;
            this.lbl_parentNext.Text = "100000000";
            this.lbl_parentNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Com Frametime: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Num Entities:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Num Snapshot Entities: ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Xaniminfo Size:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Xaniminfo Next:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Child Size:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Child Next:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parent Size:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parent Next:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Clock
            // 
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // TimerProgress
            // 
            this.TimerProgress.Tick += new System.EventHandler(this.TimerProgress_Tick);
            // 
            // TimerFrameTime
            // 
            this.TimerFrameTime.Interval = 500;
            this.TimerFrameTime.Tick += new System.EventHandler(this.TimerFrameTime_Tick);
            // 
            // TrackerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(599, 313);
            this.Controls.Add(this.GB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TrackerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BO2 ERROR TRACKER";
            this.GB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.Label lbl_comFrametime;
        private System.Windows.Forms.Label lbl_numEntities;
        private System.Windows.Forms.Label lbl_SnapEntities;
        private System.Windows.Forms.Label lbl_xanSize;
        private System.Windows.Forms.Label lbl_xanNext;
        private System.Windows.Forms.Label lbl_childSize;
        private System.Windows.Forms.Label lbl_childNext;
        private System.Windows.Forms.Label lbl_parentSize;
        private System.Windows.Forms.Label lbl_parentNext;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar barEnt;
        private System.Windows.Forms.ProgressBar barSnapEnt;
        private System.Windows.Forms.ProgressBar barXanSize;
        private System.Windows.Forms.ProgressBar barXanNext;
        private System.Windows.Forms.ProgressBar barChildSize;
        private System.Windows.Forms.ProgressBar barChildNext;
        private System.Windows.Forms.ProgressBar barParentSize;
        private System.Windows.Forms.ProgressBar barParentNext;
        private System.Windows.Forms.ProgressBar barFrameTime;
        public System.Windows.Forms.Timer Clock;
        public System.Windows.Forms.Timer TimerProgress;
        private System.Windows.Forms.Timer TimerFrameTime;
    }
}

