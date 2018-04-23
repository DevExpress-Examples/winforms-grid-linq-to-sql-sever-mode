namespace LinqServerModeOnAdvWorks {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPurchaseOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRevisionNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAmt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFreight = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalDue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.linqServerModeSource1 = new DevExpress.Data.Linq.LinqServerModeSource();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linqServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(856, 517);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPurchaseOrderID,
            this.colRevisionNumber,
            this.colStatus,
            this.colOrderDate,
            this.colShipDate,
            this.colSubTotal,
            this.colTaxAmt,
            this.colFreight,
            this.colTotalDue,
            this.colEmployee});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colPurchaseOrderID
            // 
            this.colPurchaseOrderID.Caption = "Order ID";
            this.colPurchaseOrderID.FieldName = "PurchaseOrderID";
            this.colPurchaseOrderID.Name = "colPurchaseOrderID";
            this.colPurchaseOrderID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.colPurchaseOrderID.Visible = true;
            this.colPurchaseOrderID.VisibleIndex = 0;
            // 
            // colRevisionNumber
            // 
            this.colRevisionNumber.Caption = "Revision";
            this.colRevisionNumber.FieldName = "RevisionNumber";
            this.colRevisionNumber.Name = "colRevisionNumber";
            this.colRevisionNumber.Visible = true;
            this.colRevisionNumber.VisibleIndex = 1;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            this.colStatus.Width = 63;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 3;
            // 
            // colShipDate
            // 
            this.colShipDate.FieldName = "ShipDate";
            this.colShipDate.Name = "colShipDate";
            this.colShipDate.Visible = true;
            this.colShipDate.VisibleIndex = 4;
            // 
            // colSubTotal
            // 
            this.colSubTotal.DisplayFormat.FormatString = "c2";
            this.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 5;
            // 
            // colTaxAmt
            // 
            this.colTaxAmt.Caption = "Tax";
            this.colTaxAmt.DisplayFormat.FormatString = "c2";
            this.colTaxAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTaxAmt.FieldName = "TaxAmt";
            this.colTaxAmt.Name = "colTaxAmt";
            this.colTaxAmt.Visible = true;
            this.colTaxAmt.VisibleIndex = 6;
            // 
            // colFreight
            // 
            this.colFreight.DisplayFormat.FormatString = "c2";
            this.colFreight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colFreight.FieldName = "Freight";
            this.colFreight.Name = "colFreight";
            this.colFreight.Visible = true;
            this.colFreight.VisibleIndex = 7;
            this.colFreight.Width = 100;
            // 
            // colTotalDue
            // 
            this.colTotalDue.DisplayFormat.FormatString = "c2";
            this.colTotalDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalDue.FieldName = "TotalDue";
            this.colTotalDue.Name = "colTotalDue";
            this.colTotalDue.SummaryItem.DisplayFormat = "SUM={0:c0}";
            this.colTotalDue.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotalDue.Visible = true;
            this.colTotalDue.VisibleIndex = 8;
            this.colTotalDue.Width = 143;
            // 
            // colEmployee
            // 
            this.colEmployee.Caption = "Employee";
            this.colEmployee.FieldName = "Employee.Contact.LastName";
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colEmployee.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colEmployee.OptionsFilter.AllowFilter = false;
            this.colEmployee.Visible = true;
            this.colEmployee.VisibleIndex = 9;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 517);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linqServerModeSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.Data.Linq.LinqServerModeSource linqServerModeSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchaseOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colRevisionNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colShipDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmt;
        private DevExpress.XtraGrid.Columns.GridColumn colFreight;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalDue;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee;
    }
}

