using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace CLI
{
    public partial class CLI : Form
    {
        public CLI()
        {
            InitializeComponent();
        }

        //Some desing UI stuff
        private void command_MouseClick(object sender, MouseEventArgs e)
        {
            command.BackColor = Color.Black;
            command.ForeColor = Color.Green;
        }

        private void command_MouseLeave(object sender, EventArgs e)
        {
            command.BackColor = Color.White;
            command.ForeColor = Color.SteelBlue;


        }

        private void command_MouseHover(object sender, EventArgs e)
        {
            command.BackColor = Color.Black;
            command.ForeColor = Color.Green;
        }

        private void CLI_Load(object sender, EventArgs e)
        {

        }

        //Here I build the entire process
        private void btn_Click(object sender, EventArgs e)
        {
            if (command.Text == "allApps")
            {
                Process.Start("allApps.bat");
            }
            else if (command.Text == "calculator")
            {
                Process.Start("calculator.bat");
            }
            else if (command.Text == "chrome")
            {
                Process.Start("googleChrome.bat");
            }
            else if (command.Text == "cmd")
            {
                Process.Start("command.bat");
            }
            else if (command.Text == "control")
            {
                Process.Start("controlPanel.bat");
            }
            else if (command.Text == "facebook")
            {
                Process.Start("https://www.facebook.com");
            }
            else if (command.Text == "fileEx")
            {
                Process.Start("files.bat");
            }
            else if (command.Text == "firefox")
            {
                Process.Start("openFirefox.bat");
            }
            else if (command.Text == "google")
            {
                Process.Start("https://www.google.com");
            }
            else if (command.Text == "magnify")
            {
                Process.Start("zoomINout.bat");
            }
            else if (command.Text == "notepad")
            {
                Process.Start("note.bat");
            }
            else if (command.Text == "paint")
            {
                Process.Start("paint.bat");
            }
            else if (command.Text == "registry")
            {
                Process.Start("registry.bat");
            }
            else if (command.Text == "services")
            {
                Process.Start("serv.bat");
            }
            else if (command.Text == "taskmanager")
            {
                Process.Start("task.bat");
            }
            else if (command.Text == "youtube")
            {
                Process.Start("https://www.youtube.com");
            }
            else if(command.Text != "allApps" || command.Text != "calculator" || command.Text != "chrome" || command.Text != "cmd" || command.Text != "control" || command.Text != "facebook" || command.Text != "fileEx" || command.Text != "firefox" || command.Text != "google" || command.Text != "magnify" || command.Text != "notepad" || command.Text != "paint" || command.Text != "registry" || command.Text != "services" || command.Text != "taskmanager" || command.Text != "youtube")
            {
                MessageBox.Show("Wrong command! Please try again :D", "||| Command Line Interface by Horja Robert Emanuel |||", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Specification on hover
        private void btn_MouseHover(object sender, EventArgs e)
        {
            ToolTip hov = new ToolTip();
            hov.SetToolTip(this.btn, "Please don't leave spaces ... Works only with click!");

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void commandName_Click(object sender, EventArgs e)
        {

        }

        private void command_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void stick_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip info = new ToolTip();
            info.SetToolTip(this.pictureBox1, "||CLI|| Write a command from below, don't use other words ...");
        }
    }
}
