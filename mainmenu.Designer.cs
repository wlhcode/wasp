namespace wasp
{
    partial class mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmenu));
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_title1 = new System.Windows.Forms.Label();
            this.tbl_info = new System.Windows.Forms.TableLayoutPanel();
            this.pic_line = new System.Windows.Forms.PictureBox();
            this.lbl_title2 = new System.Windows.Forms.Label();
            this.btn_instruct = new System.Windows.Forms.Label();
            this.btn_about = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Label();
            this.lbl_formtitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_q2 = new System.Windows.Forms.Label();
            this.lbl_q1 = new System.Windows.Forms.Label();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.lbl_q4 = new System.Windows.Forms.Label();
            this.num_rate = new System.Windows.Forms.NumericUpDown();
            this.lbl_q3 = new System.Windows.Forms.Label();
            this.num_cnt = new System.Windows.Forms.NumericUpDown();
            this.btn_openfile = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_abort = new System.Windows.Forms.Button();
            this.file_open = new System.Windows.Forms.OpenFileDialog();
            this.lbl_filename = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.tbl_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_line)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cnt)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_logo
            // 
            resources.ApplyResources(this.pic_logo, "pic_logo");
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.TabStop = false;
            // 
            // lbl_title1
            // 
            resources.ApplyResources(this.lbl_title1, "lbl_title1");
            this.lbl_title1.Name = "lbl_title1";
            // 
            // tbl_info
            // 
            resources.ApplyResources(this.tbl_info, "tbl_info");
            this.tbl_info.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbl_info.Controls.Add(this.pic_line, 0, 3);
            this.tbl_info.Controls.Add(this.lbl_title2, 0, 2);
            this.tbl_info.Controls.Add(this.pic_logo, 0, 0);
            this.tbl_info.Controls.Add(this.lbl_title1, 0, 1);
            this.tbl_info.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbl_info.Name = "tbl_info";
            // 
            // pic_line
            // 
            resources.ApplyResources(this.pic_line, "pic_line");
            this.pic_line.Name = "pic_line";
            this.pic_line.TabStop = false;
            // 
            // lbl_title2
            // 
            resources.ApplyResources(this.lbl_title2, "lbl_title2");
            this.lbl_title2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_title2.Name = "lbl_title2";
            // 
            // btn_instruct
            // 
            resources.ApplyResources(this.btn_instruct, "btn_instruct");
            this.btn_instruct.BackColor = System.Drawing.Color.Black;
            this.btn_instruct.ForeColor = System.Drawing.Color.White;
            this.btn_instruct.Name = "btn_instruct";
            this.btn_instruct.Click += new System.EventHandler(this.btn_instruct_Click);
            this.btn_instruct.MouseEnter += new System.EventHandler(this.btn_instruct_MouseEnter);
            this.btn_instruct.MouseLeave += new System.EventHandler(this.btn_instruct_MouseLeave);
            // 
            // btn_about
            // 
            resources.ApplyResources(this.btn_about, "btn_about");
            this.btn_about.BackColor = System.Drawing.Color.Black;
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.Name = "btn_about";
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            this.btn_about.MouseEnter += new System.EventHandler(this.btn_about_MouseEnter);
            this.btn_about.MouseLeave += new System.EventHandler(this.btn_about_MouseLeave);
            // 
            // btn_quit
            // 
            resources.ApplyResources(this.btn_quit, "btn_quit");
            this.btn_quit.BackColor = System.Drawing.Color.Teal;
            this.btn_quit.ForeColor = System.Drawing.Color.White;
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            this.btn_quit.MouseEnter += new System.EventHandler(this.btn_quit_MouseEnter);
            this.btn_quit.MouseLeave += new System.EventHandler(this.btn_quit_MouseLeave);
            // 
            // lbl_formtitle
            // 
            resources.ApplyResources(this.lbl_formtitle, "lbl_formtitle");
            this.lbl_formtitle.Name = "lbl_formtitle";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lbl_q2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_q1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_msg, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_q4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.num_rate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_q3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.num_cnt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_openfile, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lbl_q2
            // 
            resources.ApplyResources(this.lbl_q2, "lbl_q2");
            this.lbl_q2.Name = "lbl_q2";
            // 
            // lbl_q1
            // 
            resources.ApplyResources(this.lbl_q1, "lbl_q1");
            this.lbl_q1.Name = "lbl_q1";
            // 
            // tb_msg
            // 
            resources.ApplyResources(this.tb_msg, "tb_msg");
            this.tb_msg.Name = "tb_msg";
            // 
            // lbl_q4
            // 
            resources.ApplyResources(this.lbl_q4, "lbl_q4");
            this.lbl_q4.Name = "lbl_q4";
            // 
            // num_rate
            // 
            this.num_rate.DecimalPlaces = 2;
            resources.ApplyResources(this.num_rate, "num_rate");
            this.num_rate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_rate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_rate.Name = "num_rate";
            this.num_rate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbl_q3
            // 
            resources.ApplyResources(this.lbl_q3, "lbl_q3");
            this.lbl_q3.Name = "lbl_q3";
            // 
            // num_cnt
            // 
            resources.ApplyResources(this.num_cnt, "num_cnt");
            this.num_cnt.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_cnt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_cnt.Name = "num_cnt";
            this.num_cnt.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btn_openfile
            // 
            resources.ApplyResources(this.btn_openfile, "btn_openfile");
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // btn_submit
            // 
            resources.ApplyResources(this.btn_submit, "btn_submit");
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_ClickAsync);
            // 
            // lbl_status
            // 
            resources.ApplyResources(this.lbl_status, "lbl_status");
            this.lbl_status.Name = "lbl_status";
            // 
            // btn_abort
            // 
            resources.ApplyResources(this.btn_abort, "btn_abort");
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // file_open
            // 
            resources.ApplyResources(this.file_open, "file_open");
            // 
            // lbl_filename
            // 
            resources.ApplyResources(this.lbl_filename, "lbl_filename");
            this.lbl_filename.Name = "lbl_filename";
            // 
            // mainmenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_filename);
            this.Controls.Add(this.btn_abort);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_formtitle);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_instruct);
            this.Controls.Add(this.tbl_info);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainmenu";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.tbl_info.ResumeLayout(false);
            this.tbl_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_line)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_title1;
        private System.Windows.Forms.TableLayoutPanel tbl_info;
        private System.Windows.Forms.Label lbl_title2;
        private System.Windows.Forms.PictureBox pic_line;
        private System.Windows.Forms.Label btn_instruct;
        private System.Windows.Forms.Label btn_about;
        private System.Windows.Forms.Label btn_quit;
        private System.Windows.Forms.Label lbl_formtitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_q1;
        private System.Windows.Forms.TextBox tb_msg;
        private System.Windows.Forms.Label lbl_q3;
        private System.Windows.Forms.Label lbl_q4;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.NumericUpDown num_cnt;
        private System.Windows.Forms.NumericUpDown num_rate;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_abort;
        private System.Windows.Forms.Label lbl_q2;
        private System.Windows.Forms.Button btn_openfile;
        private System.Windows.Forms.OpenFileDialog file_open;
        private System.Windows.Forms.Label lbl_filename;
    }
}

