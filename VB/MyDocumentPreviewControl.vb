Imports DevExpress.Xpf.Printing
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.Printing.PreviewControl
Imports DevExpress.XtraPrinting

Namespace MinimalisticReportPreviewDemo
    Public Class MyDocumentPreviewControl
        Inherits DocumentPreviewControl

        Public Overrides Sub Save()
            If System.Windows.MessageBox.Show("Do you want to save the document?", "Save...", System.Windows.MessageBoxButton.YesNoCancel) = System.Windows.MessageBoxResult.Yes Then
                MyBase.Save()
            End If

        End Sub
    End Class
End Namespace
