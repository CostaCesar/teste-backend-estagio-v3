using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PgsqlAPI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DatabaseHandler.Start();
        }

        private void MainList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            MainList.SelectedIndex = MainList.IndexFromPoint(e.Location);
            if(MainList.SelectedIndex != -1)
                MainMenu.Show(Cursor.Position);
        }

        private void equipamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.Show();
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            Data.RefreshModels();
        }
    }
}
