using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wasp
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void btn_instruct_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "instruction")
                {
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Normal;
                    }
                    frm.BringToFront();
                    return;
                }
            }

            instruction a = new instruction();
            a.Show();
        }

        private void btn_instruct_MouseEnter(object sender, EventArgs e)
        {
            btn_instruct.BackColor = SystemColors.ControlDarkDark;
        }

        private void btn_instruct_MouseLeave(object sender, EventArgs e)
        {
            btn_instruct.BackColor = SystemColors.ControlText;
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            aboutprog a = new aboutprog();
            a.ShowDialog();
        }

        private void btn_about_MouseEnter(object sender, EventArgs e)
        {
            btn_about.BackColor = SystemColors.ControlDarkDark;
        }

        private void btn_about_MouseLeave(object sender, EventArgs e)
        {
            btn_about.BackColor = SystemColors.ControlText;
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_quit_MouseEnter(object sender, EventArgs e)
        {
            btn_quit.BackColor = Color.CadetBlue;
        }

        private void btn_quit_MouseLeave(object sender, EventArgs e)
        {
            btn_quit.BackColor = Color.Teal;
        }

        bool abort = false;

        private async void btn_submit_ClickAsync(object sender, EventArgs e)
        {
            bool attach_file = false;
            Bitmap img = null;
            if (file_open.FileName != "")
            {
                if (File.Exists(file_open.FileName) == false)
                {
                    lbl_filename.Text = "File does not exist!";
                    attach_file = false;
                }
                else
                {
                    img = new Bitmap(file_open.FileName);
                    attach_file = true;
                }
            }

            abort = false;
            btn_submit.Visible = false;
            btn_abort.Visible = true;

            Clipboard.SetDataObject(tb_msg.Text, true);
            decimal delay = 1 / num_rate.Value * 1000;

            for(double t = 5; t > 0; t -= 0.1)
            {

                if (abort) return;
                string str = "Preparation time: " + t.ToString("N2");
                lbl_status.Text = str;
                await Task.Delay(100);
            }

            for(int i = 0; i < num_cnt.Value; ++i)
            {
                if (abort) return;
                string str = "No. of messages sent: " + i.ToString();
                lbl_status.Text = str;
                SendKeys.Send("^{v}");
                if (attach_file)
                {
                    Clipboard.SetImage(img);

                    await Task.Delay(400);
                    SendKeys.Send("^{v}");

                    await Task.Delay(1200);
                    SendKeys.Send("{ENTER}");

                    Clipboard.SetText(tb_msg.Text);
                    await Task.Delay(900);
                }
                else
                {
                    SendKeys.Send("{ENTER}");
                    await Task.Delay(Decimal.ToInt32(delay));
                }
            }

            btn_abort.Visible = false;
            btn_submit.Visible = true;

            lbl_status.Text = "All done!";
            await Task.Delay(1000);
            lbl_status.Text = "";

            btn_abort.Visible = false;
            btn_submit.Visible = true;
        }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            abort = true;
            lbl_status.Text = "";
            btn_abort.Visible = false;
            btn_submit.Visible = true;
        }

        private void btn_openfile_Click(object sender, EventArgs e)
        {
            file_open.ShowDialog();
            string str = file_open.FileName;
            if (str != "")
            {
                if(str.Length > 31)
                {
                    int count = 0;
                    for(count = str.Length - 1; count >= 0; count--)
                    {
                        if (str[count] == '\\' || str[count] == '/') break;
                    }
                    str = str.Substring(count + 1);
                    if (str.Length > 31)
                    {
                        lbl_filename.Text = str.Substring(0,14) + "..." + str.Substring(str.Length-14);
                    }
                    else
                    {
                        lbl_filename.Text = str.Substring(count + 1);
                    }
                    
                }
                else
                {
                    lbl_filename.Text = str;
                }
            }
            num_rate.Value = 0.4M;
            num_rate.Maximum = 0.4M;
            num_rate.Minimum = 0.4M;
            num_rate.ReadOnly = true;
        }
    }
}
