Imports Microsoft.VisualBasic
Imports System
Namespace Controls
	Partial Public Class InfoPanel
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.panelThumnail = New System.Windows.Forms.Panel()
            Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.lblThumbnailKey = New System.Windows.Forms.Label()
            Me.pictureBoxThumbnail = New System.Windows.Forms.PictureBox()
            Me.btnOpen = New System.Windows.Forms.Button()
            Me.btnCapture = New System.Windows.Forms.Button()
            Me.tableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.Terminal_number = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.gender_dropdown = New System.Windows.Forms.ComboBox()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.agency_number = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.sub_agent_second_name = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.sub_agent_first_names = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
            Me.panelThumnail.SuspendLayout()
            Me.tableLayoutPanel2.SuspendLayout()
            CType(Me.pictureBoxThumbnail, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutPanelMain.SuspendLayout()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'panelThumnail
            '
            Me.panelThumnail.Controls.Add(Me.tableLayoutPanel2)
            Me.panelThumnail.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelThumnail.Location = New System.Drawing.Point(3, 3)
            Me.panelThumnail.Name = "panelThumnail"
            Me.panelThumnail.Size = New System.Drawing.Size(339, 555)
            Me.panelThumnail.TabIndex = 1
            '
            'tableLayoutPanel2
            '
            Me.tableLayoutPanel2.ColumnCount = 3
            Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tableLayoutPanel2.Controls.Add(Me.lblThumbnailKey, 0, 0)
            Me.tableLayoutPanel2.Controls.Add(Me.pictureBoxThumbnail, 0, 1)
            Me.tableLayoutPanel2.Controls.Add(Me.btnOpen, 2, 0)
            Me.tableLayoutPanel2.Controls.Add(Me.btnCapture, 1, 0)
            Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
            Me.tableLayoutPanel2.RowCount = 2
            Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel2.Size = New System.Drawing.Size(339, 555)
            Me.tableLayoutPanel2.TabIndex = 1
            '
            'lblThumbnailKey
            '
            Me.lblThumbnailKey.AutoSize = True
            Me.lblThumbnailKey.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblThumbnailKey.Location = New System.Drawing.Point(3, 0)
            Me.lblThumbnailKey.Name = "lblThumbnailKey"
            Me.lblThumbnailKey.Size = New System.Drawing.Size(151, 32)
            Me.lblThumbnailKey.TabIndex = 0
            Me.lblThumbnailKey.Text = "ThumbnailKey"
            Me.lblThumbnailKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pictureBoxThumbnail
            '
            Me.pictureBoxThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tableLayoutPanel2.SetColumnSpan(Me.pictureBoxThumbnail, 3)
            Me.pictureBoxThumbnail.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pictureBoxThumbnail.Location = New System.Drawing.Point(3, 35)
            Me.pictureBoxThumbnail.Name = "pictureBoxThumbnail"
            Me.pictureBoxThumbnail.Size = New System.Drawing.Size(333, 517)
            Me.pictureBoxThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBoxThumbnail.TabIndex = 2
            Me.pictureBoxThumbnail.TabStop = False
            '
            'btnOpen
            '
            Me.btnOpen.Location = New System.Drawing.Point(251, 3)
            Me.btnOpen.Name = "btnOpen"
            Me.btnOpen.Size = New System.Drawing.Size(85, 26)
            Me.btnOpen.TabIndex = 1
            Me.btnOpen.Text = "Open image"
            Me.btnOpen.UseVisualStyleBackColor = True
            '
            'btnCapture
            '
            Me.btnCapture.Location = New System.Drawing.Point(160, 3)
            Me.btnCapture.Name = "btnCapture"
            Me.btnCapture.Size = New System.Drawing.Size(85, 26)
            Me.btnCapture.TabIndex = 3
            Me.btnCapture.Text = "Capture"
            Me.btnCapture.UseVisualStyleBackColor = True
            '
            'tableLayoutPanelMain
            '
            Me.tableLayoutPanelMain.ColumnCount = 2
            Me.tableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
            Me.tableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.0!))
            Me.tableLayoutPanelMain.Controls.Add(Me.panelThumnail, 0, 0)
            Me.tableLayoutPanelMain.Controls.Add(Me.Panel1, 1, 0)
            Me.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanelMain.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanelMain.Name = "tableLayoutPanelMain"
            Me.tableLayoutPanelMain.RowCount = 1
            Me.tableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.tableLayoutPanelMain.Size = New System.Drawing.Size(785, 561)
            Me.tableLayoutPanelMain.TabIndex = 2
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.Terminal_number)
            Me.Panel1.Controls.Add(Me.Label4)
            Me.Panel1.Controls.Add(Me.gender_dropdown)
            Me.Panel1.Controls.Add(Me.Label7)
            Me.Panel1.Controls.Add(Me.agency_number)
            Me.Panel1.Controls.Add(Me.Label3)
            Me.Panel1.Controls.Add(Me.sub_agent_second_name)
            Me.Panel1.Controls.Add(Me.Label2)
            Me.Panel1.Controls.Add(Me.sub_agent_first_names)
            Me.Panel1.Controls.Add(Me.Label1)
            Me.Panel1.Location = New System.Drawing.Point(348, 3)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(434, 555)
            Me.Panel1.TabIndex = 2
            '
            'Terminal_number
            '
            Me.Terminal_number.Location = New System.Drawing.Point(21, 246)
            Me.Terminal_number.Name = "Terminal_number"
            Me.Terminal_number.Size = New System.Drawing.Size(199, 20)
            Me.Terminal_number.TabIndex = 15
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(18, 209)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(87, 13)
            Me.Label4.TabIndex = 14
            Me.Label4.Text = "Terminal Number"
            '
            'gender_dropdown
            '
            Me.gender_dropdown.FormattingEnabled = True
            Me.gender_dropdown.Items.AddRange(New Object() {"Male", "Female"})
            Me.gender_dropdown.Location = New System.Drawing.Point(18, 319)
            Me.gender_dropdown.Name = "gender_dropdown"
            Me.gender_dropdown.Size = New System.Drawing.Size(174, 21)
            Me.gender_dropdown.TabIndex = 13
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(15, 291)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(42, 13)
            Me.Label7.TabIndex = 12
            Me.Label7.Text = "Gender"
            '
            'agency_number
            '
            Me.agency_number.Location = New System.Drawing.Point(18, 157)
            Me.agency_number.Name = "agency_number"
            Me.agency_number.Size = New System.Drawing.Size(202, 20)
            Me.agency_number.TabIndex = 5
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(15, 131)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(83, 13)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Agency Number"
            '
            'sub_agent_second_name
            '
            Me.sub_agent_second_name.Location = New System.Drawing.Point(18, 98)
            Me.sub_agent_second_name.Name = "sub_agent_second_name"
            Me.sub_agent_second_name.Size = New System.Drawing.Size(202, 20)
            Me.sub_agent_second_name.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(15, 72)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(102, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Sub Agent Surname"
            '
            'sub_agent_first_names
            '
            Me.sub_agent_first_names.Location = New System.Drawing.Point(18, 44)
            Me.sub_agent_first_names.Name = "sub_agent_first_names"
            Me.sub_agent_first_names.Size = New System.Drawing.Size(202, 20)
            Me.sub_agent_first_names.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(15, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Sub Agent First Name"
            '
            'InfoPanel
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tableLayoutPanelMain)
            Me.Name = "InfoPanel"
            Me.Size = New System.Drawing.Size(785, 561)
            Me.panelThumnail.ResumeLayout(False)
            Me.tableLayoutPanel2.ResumeLayout(False)
            Me.tableLayoutPanel2.PerformLayout()
            CType(Me.pictureBoxThumbnail, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutPanelMain.ResumeLayout(False)
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private panelThumnail As System.Windows.Forms.Panel
		Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
		Private lblThumbnailKey As System.Windows.Forms.Label
		Private WithEvents btnOpen As System.Windows.Forms.Button
		Private pictureBoxThumbnail As System.Windows.Forms.PictureBox
		Private tableLayoutPanelMain As System.Windows.Forms.TableLayoutPanel
        Private openFileDialog As System.Windows.Forms.OpenFileDialog
        Private WithEvents btnCapture As System.Windows.Forms.Button
        Friend WithEvents Panel1 As Windows.Forms.Panel
        Friend WithEvents gender_dropdown As Windows.Forms.ComboBox
        Friend WithEvents Label7 As Windows.Forms.Label
        Friend WithEvents agency_number As Windows.Forms.TextBox
        Friend WithEvents Label3 As Windows.Forms.Label
        Friend WithEvents sub_agent_second_name As Windows.Forms.TextBox
        Friend WithEvents Label2 As Windows.Forms.Label
        Friend WithEvents sub_agent_first_names As Windows.Forms.TextBox
        Friend WithEvents Label1 As Windows.Forms.Label
        Friend WithEvents Terminal_number As Windows.Forms.TextBox
        Friend WithEvents Label4 As Windows.Forms.Label
    End Class
End Namespace
