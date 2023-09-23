Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace LinqServerModeOnAdvWorks

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.ServerMode = True
            Dim dc As AdvWorksDataContext = New AdvWorksDataContext()
            dc.Log = Console.Out ' log queries
            linqServerModeSource1.QueryableSource = dc.PurchaseOrderHeaders
            gridControl1.DataSource = linqServerModeSource1
        End Sub
    End Class
End Namespace
