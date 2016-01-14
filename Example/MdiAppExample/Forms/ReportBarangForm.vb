Imports System.ComponentModel
Imports Microsoft.Reporting.WinForms

Public Class ReportBarangForm

    Private controller As New BarangController()

    Private Sub ReportBarangForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim data As BindingList(Of Barang) = controller.Search(Nothing)

        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("BarangDataSet", data))
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class