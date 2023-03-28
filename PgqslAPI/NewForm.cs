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
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
            ComBox_Model.DataSource = Data.Models.Select(m => m.name).ToList();
        }

        private void ComBox_Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComBox_Model.SelectedIndex != -1)
                Button_Ok.Enabled = true;
        }

        private void Button_Ok_Click(object sender, EventArgs e)
        {
            Equipment added = new Equipment(Box_Name.Text, Data.Models[ComBox_Model.SelectedIndex].id);
            DatabaseHandler.AddEquipment(added);
            Close();
        }
    }
}
