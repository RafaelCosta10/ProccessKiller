using ProccessKiller.Properties;
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

namespace ProccessKiller
{
    public partial class frmKill : Form
    {
        public frmKill()
        {
            InitializeComponent();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                //aqui, pega a lista previamente escrita no "forms"
                //string[] procs = this.txtMotherFuckers.Text.Split(Environment.NewLine.ToCharArray());

                //neste caso, é apenas para 4 processos
                var procs = new List<string>();

                procs.Add("Microsoft.VisualStudio.Web.Host");
                procs.Add("Microsoft.VsHub.Server.HttpHost");
                procs.Add("iisexpress");
                procs.Add("iisexpresstray");

                foreach (var procName in procs)
                {
                    foreach (var process in Process.GetProcessesByName(procName))
                    {
                        process.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void frmKill_Load(object sender, EventArgs e)
        {
            //txtMotherFuckers.Text = Settings.Default.Processes.Replace(";", Environment.NewLine);
            JustKillIt();
            Application.Exit();
        }

        private void JustKillIt()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                string[] procs = this.txtMotherFuckers.Text.Split(Environment.NewLine.ToCharArray());

                foreach (var procName in procs)
                {
                    foreach (var process in Process.GetProcessesByName(procName))
                    {
                        process.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
}
