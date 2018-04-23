using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;

namespace LinqServerModeOnAdvWorks {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            gridControl1.ServerMode = true;

            AdvWorksDataContext dc = new AdvWorksDataContext();
            dc.Log = Console.Out;  // log queries

            linqServerModeSource1.QueryableSource = dc.PurchaseOrderHeaders;
            gridControl1.DataSource = linqServerModeSource1;
        }
    }
}
