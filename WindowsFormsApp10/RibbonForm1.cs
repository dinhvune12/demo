using DevExpress.XtraBars;
using DevExpress.XtraTabbedMdi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
           
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm1 cc= new XtraForm1();
           
           
            cc.MdiParent=this;

            cc.Show();
        }

        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}