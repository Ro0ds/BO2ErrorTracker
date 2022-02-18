using System;
using Memory;
using System.Windows.Forms;

namespace BO2_ERROR_TRACKER {
    public partial class TrackerMain : Form {
        /* main variables */
        /* Credits to lveez Bo2ErrorTracker for some of these offsets */
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public string ParentVarBase = "0x2DEA400";
        public string ParentVarNext = "0x2";
        public string ChildBase = "0x2DEA580";
        public string ChildNext = "0x4";
        public string AnimInfo = "0x2B3F14A";
        public string AnimInfoSize = "0x2B3F14A";
        public string numSnapEntities = "0x1278020";
        public string numEntities = "0x1278010";
        public string ComFrametime = "0x0019FCD8";
        public string Game = string.Empty;
        public int PID;
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        Mem Mem = new Mem(); //starting memory.dll

        public TrackerMain() {
            InitializeComponent();
            LoadTracker();
            ProgressTimer();
            FrameTimer(); 
            /* 
               created this third timer because com_frametime was going crazy with negative number, still glitches 
               when you close or pause the game lol
            */
        }

        public void Clock_Tick(object sender, EventArgs e) {
            if (Mem.GetProcIdFromName("t6zmv41") > 1) {
                PID = Mem.GetProcIdFromName("t6zmv41");
            }
            else if (Mem.GetProcIdFromName("t6zm") > 1) {
                PID = Mem.GetProcIdFromName("t6zm");
            }

            Mem.OpenProcess(PID);

            string parent_next = $"{ParentVarBase}, {ParentVarNext}";
            string parent_size = $"{ParentVarBase}";
            string child_next = $"{ChildBase}, {ChildNext}";
            string child_size = $"{ChildBase} + {ChildNext}";
            string xaniminfo_next = $"{AnimInfo}";
            string xaniminfo_size = $"{AnimInfoSize}";
            string num_snapshot_entities = $"{numSnapEntities}";
            string num_entities = $"{numEntities}";

            lbl_parentNext.Text = Mem.Read2Byte(parent_next).ToString();
            lbl_parentSize.Text = Mem.ReadInt(parent_size).ToString() + " / 16384"; /* not working */
            lbl_childNext.Text = Mem.Read2Byte(child_next).ToString();
            lbl_childSize.Text = Mem.ReadInt(child_size).ToString() + " / 65536"; /* not working */
            lbl_xanNext.Text = Mem.ReadInt(xaniminfo_next).ToString();
            lbl_xanSize.Text = Mem.ReadInt(xaniminfo_size).ToString() + " / 4096"; /* not working/implemented */
            lbl_SnapEntities.Text = Mem.ReadInt(num_snapshot_entities).ToString() + " / 2147483647";
            lbl_numEntities.Text = Mem.ReadInt(num_entities).ToString() + " / 2147483647";

            // not implemented 'cause it's too ugly lol
            /* if(Mem.ReadInt(num_snapshot_entities) >= 1900000000) {
                barSnapEnt.ForeColor = Color.Red;
            } */
        }

        private void TimerProgress_Tick(object sender, EventArgs e) {
            //* Progress bar *//
            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            //* Parent_next *//
            barParentNext.Minimum = 0;
            barParentNext.Maximum = 16384;
            string pSizeN = $"{ParentVarBase}, {ParentVarNext}";
            string pSizeN1 = Mem.Read2Byte(pSizeN).ToString();
            barParentNext.Value = int.Parse(pSizeN1);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            /* Parent_size */
            barParentSize.Minimum = 0;
            barParentSize.Maximum = 16384;
            string pSize = $"{ParentVarBase}"; //created but not working
            string pSize1 = Mem.Read2Byte(pSize).ToString();
            barParentSize.Value = int.Parse(pSize1);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            /* Child_next */
            barChildNext.Minimum = 0;
            barChildNext.Maximum = 65536;
            string cNextN = $"{ChildBase}, {ChildNext}";
            string cNextN1 = Mem.Read2Byte(cNextN).ToString();
            barChildNext.Value = int.Parse(cNextN1);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            /* Child_size */
            barChildSize.Minimum = 0;
            barChildSize.Maximum = 65536; 
            string cSize = Mem.Read2Byte(ChildBase).ToString(); //using child_next value/not working
            barChildSize.Value = int.Parse(cSize);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            /* xAnimInfo_next */
            barXanNext.Minimum = 0;
            barXanNext.Maximum = 4096;
            string xNext = Mem.ReadInt(AnimInfo).ToString();
            barXanNext.Value = int.Parse(xNext);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            /* xAnimInfo_Size */
            barXanSize.Minimum = 0;
            barXanSize.Maximum = 4096;
            string xSize = Mem.ReadInt(AnimInfoSize).ToString(); //not working
            barXanSize.Value = int.Parse(xSize);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            /* NumSnapshotEntities */
            barSnapEnt.Minimum = 0;
            barSnapEnt.Maximum = int.MaxValue;
            string snEnt = Mem.ReadInt(numSnapEntities).ToString();
            barSnapEnt.Value = int.Parse(snEnt);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            /* Num_Entities */
            barEnt.Minimum = 0;
            barEnt.Maximum = int.MaxValue;
            string Ent = Mem.ReadInt(numEntities).ToString();
            barEnt.Value = int.Parse(Ent);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
            /* Com_Frametime */
            barFrameTime.Minimum = 0;
            barFrameTime.Maximum = 2147483647;
            string FrameTime = Mem.ReadInt(ComFrametime).ToString();
            barFrameTime.Value = (int)long.Parse(FrameTime);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        public void TimerFrameTime_Tick(object sender, EventArgs e) {
            string com_frametime = $"{ComFrametime}";
            lbl_comFrametime.Text = Mem.ReadInt(com_frametime).ToString() + " / 2147483647";
        }

        public void LoadTracker() {
            Clock.Interval = 100;
            Clock.Enabled = true;
        }

        public void ProgressTimer() {
            TimerProgress.Interval = 100;
            TimerProgress.Enabled = true;
        }

        public void FrameTimer() {
            TimerFrameTime.Interval = 500;
            TimerFrameTime.Enabled = true;
        }
    }
}