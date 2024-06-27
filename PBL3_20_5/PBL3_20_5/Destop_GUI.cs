using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_20_5
{
    public partial class Destop_GUI : Form
    {
        public static Destop_GUI Instance;

        private Form curentFormChild;
        public Destop_GUI()
        {
            InitializeComponent();
            LoadForm(new GiaoDienChung());
            this.StartPosition = FormStartPosition.CenterScreen;
            Instance = this;
        }

        public void LoadForm(Form newform)
        {
            OpenChildForm(newform);
        }

        private void OpenChildForm(Form childForm)
        {
            if (curentFormChild != null)
            {
                //curentFormChild.Close();
            }
            curentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
