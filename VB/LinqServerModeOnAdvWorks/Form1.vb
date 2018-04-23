Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Columns

Namespace LinqServerModeOnAdvWorks
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			gridControl1.ServerMode = True

			Dim dc As New AdvWorksDataContext()
			dc.Log = Console.Out ' log queries

			linqServerModeSource1.QueryableSource = dc.PurchaseOrderHeaders
			gridControl1.DataSource = linqServerModeSource1
		End Sub
	End Class
End Namespace
