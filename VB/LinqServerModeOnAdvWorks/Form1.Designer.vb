Imports Microsoft.VisualBasic
Imports System
Namespace LinqServerModeOnAdvWorks
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colPurchaseOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRevisionNumber = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTaxAmt = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFreight = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colTotalDue = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colEmployee = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.linqServerModeSource1 = New DevExpress.Data.Linq.LinqServerModeSource()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.linqServerModeSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(856, 517)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colPurchaseOrderID, Me.colRevisionNumber, Me.colStatus, Me.colOrderDate, Me.colShipDate, Me.colSubTotal, Me.colTaxAmt, Me.colFreight, Me.colTotalDue, Me.colEmployee})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.Editable = False
			Me.gridView1.OptionsDetail.EnableMasterViewMode = False
			Me.gridView1.OptionsView.ShowFooter = True
			' 
			' colPurchaseOrderID
			' 
			Me.colPurchaseOrderID.Caption = "Order ID"
			Me.colPurchaseOrderID.FieldName = "PurchaseOrderID"
			Me.colPurchaseOrderID.Name = "colPurchaseOrderID"
			Me.colPurchaseOrderID.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
			Me.colPurchaseOrderID.Visible = True
			Me.colPurchaseOrderID.VisibleIndex = 0
			' 
			' colRevisionNumber
			' 
			Me.colRevisionNumber.Caption = "Revision"
			Me.colRevisionNumber.FieldName = "RevisionNumber"
			Me.colRevisionNumber.Name = "colRevisionNumber"
			Me.colRevisionNumber.Visible = True
			Me.colRevisionNumber.VisibleIndex = 1
			' 
			' colStatus
			' 
			Me.colStatus.FieldName = "Status"
			Me.colStatus.Name = "colStatus"
			Me.colStatus.Visible = True
			Me.colStatus.VisibleIndex = 2
			Me.colStatus.Width = 63
			' 
			' colOrderDate
			' 
			Me.colOrderDate.FieldName = "OrderDate"
			Me.colOrderDate.Name = "colOrderDate"
			Me.colOrderDate.Visible = True
			Me.colOrderDate.VisibleIndex = 3
			' 
			' colShipDate
			' 
			Me.colShipDate.FieldName = "ShipDate"
			Me.colShipDate.Name = "colShipDate"
			Me.colShipDate.Visible = True
			Me.colShipDate.VisibleIndex = 4
			' 
			' colSubTotal
			' 
			Me.colSubTotal.DisplayFormat.FormatString = "c2"
			Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colSubTotal.FieldName = "SubTotal"
			Me.colSubTotal.Name = "colSubTotal"
			Me.colSubTotal.Visible = True
			Me.colSubTotal.VisibleIndex = 5
			' 
			' colTaxAmt
			' 
			Me.colTaxAmt.Caption = "Tax"
			Me.colTaxAmt.DisplayFormat.FormatString = "c2"
			Me.colTaxAmt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colTaxAmt.FieldName = "TaxAmt"
			Me.colTaxAmt.Name = "colTaxAmt"
			Me.colTaxAmt.Visible = True
			Me.colTaxAmt.VisibleIndex = 6
			' 
			' colFreight
			' 
			Me.colFreight.DisplayFormat.FormatString = "c2"
			Me.colFreight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colFreight.FieldName = "Freight"
			Me.colFreight.Name = "colFreight"
			Me.colFreight.Visible = True
			Me.colFreight.VisibleIndex = 7
			Me.colFreight.Width = 100
			' 
			' colTotalDue
			' 
			Me.colTotalDue.DisplayFormat.FormatString = "c2"
			Me.colTotalDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colTotalDue.FieldName = "TotalDue"
			Me.colTotalDue.Name = "colTotalDue"
			Me.colTotalDue.SummaryItem.DisplayFormat = "SUM={0:c0}"
			Me.colTotalDue.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
			Me.colTotalDue.Visible = True
			Me.colTotalDue.VisibleIndex = 8
			Me.colTotalDue.Width = 143
			' 
			' colEmployee
			' 
			Me.colEmployee.Caption = "Employee"
			Me.colEmployee.FieldName = "Employee.Contact.LastName"
			Me.colEmployee.Name = "colEmployee"
			Me.colEmployee.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False
			Me.colEmployee.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.colEmployee.OptionsFilter.AllowFilter = False
			Me.colEmployee.Visible = True
			Me.colEmployee.VisibleIndex = 9
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(856, 517)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.linqServerModeSource1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private linqServerModeSource1 As DevExpress.Data.Linq.LinqServerModeSource
		Private colPurchaseOrderID As DevExpress.XtraGrid.Columns.GridColumn
		Private colRevisionNumber As DevExpress.XtraGrid.Columns.GridColumn
		Private colStatus As DevExpress.XtraGrid.Columns.GridColumn
		Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colSubTotal As DevExpress.XtraGrid.Columns.GridColumn
		Private colTaxAmt As DevExpress.XtraGrid.Columns.GridColumn
		Private colFreight As DevExpress.XtraGrid.Columns.GridColumn
		Private colTotalDue As DevExpress.XtraGrid.Columns.GridColumn
		Private colEmployee As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

