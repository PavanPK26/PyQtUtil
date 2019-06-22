using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyQtUtil
{
    public partial class MainForm : Form
    {

        #region Varialblea

        OpenFileDialog PathSel;

        List<string> Commands = new List<string>();


        #endregion

        #region Functions

        public bool RunCmdCommands()
        {
            bool result;
            try
            {
                using (Process cmd = new Process())
                {
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();
                    Commands.Add("exit");
                    foreach (var command in Commands)
                    {
                        cmd.StandardInput.WriteLine(command);
                    }
                    cmd.WaitForExit();
                    Commands.Clear();
                    cmd.Close();
                    result = true;
                }
            }
            catch(Exception e)
            {
                result = false;
            }
            return result;

        }

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void GenPy_btn_Click(object sender, EventArgs e)
        {
            String command = $"pyuic5 -x \"{UIPath.Text}\" -o \"{UIPath.Text.Replace(".ui", ".py")}\"";
            Commands.Add(command);
            RunCmdCommands();
        }

        private void UIBrowse_Btn_Click(object sender, EventArgs e)
        {
            PathSel?.Reset();
            PathSel = new OpenFileDialog()
            {
                CheckPathExists = true,
                Filter = "UI File|*.ui",
                Multiselect = false
            };

            if(PathSel.ShowDialog() == DialogResult.OK)
            {
                UIPath.Text = PathSel.FileName;
            }
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
