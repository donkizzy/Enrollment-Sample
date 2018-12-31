Imports System
Imports System.Threading.Tasks
Imports System.Windows.Forms

Partial Public Class LongActionDialog
	Inherits Form
#Region "Private constructor"

	Private Sub New(ByVal title As String)
		InitializeComponent()
		lblTitle.Text = title
	End Sub

#End Region

#Region "Private fields"

	Private _canClose As Boolean = False
	Private _task As Task = Nothing

#End Region

#Region "Public static methods"

	Public Overloads Shared Function ShowDialog(Of T)(ByVal owner As IWin32Window, ByVal title As String, ByVal task As Task(Of T)) As T
		Dim dialog = New LongActionDialog(title) With {._task = task}
		dialog.ShowDialog(owner)
		Return task.Result
	End Function

	Public Overloads Shared Sub ShowDialog(ByVal owner As IWin32Window, ByVal title As String, ByVal task As Task)
		Dim dialog = New LongActionDialog(title) With {._task = task}
		dialog.ShowDialog(owner)
	End Sub

#End Region

#Region "Private methods"

	Private Sub LongTaskFormFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
		e.Cancel = Not _canClose
	End Sub

	Private Sub LongActionDialogShown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
		_task.ContinueWith(AddressOf AnonymousMethod1)
	End Sub
	Private Sub AnonymousMethod1(ByVal t As Object)
		_canClose = True
		If InvokeRequired Then
			BeginInvoke(New Action(AddressOf Close))
		Else
			Close()
		End If
	End Sub

#End Region
End Class
