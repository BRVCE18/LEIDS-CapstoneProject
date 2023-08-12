<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTNadd2 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTvaxnumber = New System.Windows.Forms.TextBox()
        Me.TXTmedperson = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTpatient2 = New System.Windows.Forms.TextBox()
        Me.TXTage = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTvaccine = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTdosage = New System.Windows.Forms.TextBox()
        Me.BTNsave = New System.Windows.Forms.Button()
        Me.BTNadd = New System.Windows.Forms.Button()
        Me.BTNdelete = New System.Windows.Forms.Button()
        Me.TXTphone = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTfirstname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTsurname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTpatient = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTsearch = New System.Windows.Forms.TextBox()
        Me.BTNsearch = New System.Windows.Forms.Button()
        Me.BTNexit = New System.Windows.Forms.Button()
        Me.BTNrefresh = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTNadd2)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.BTNsave)
        Me.GroupBox1.Controls.Add(Me.BTNadd)
        Me.GroupBox1.Controls.Add(Me.BTNdelete)
        Me.GroupBox1.Controls.Add(Me.TXTphone)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TXTfirstname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXTsurname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXTpatient)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 485)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BTNadd2
        '
        Me.BTNadd2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTNadd2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.BTNadd2.Location = New System.Drawing.Point(150, 377)
        Me.BTNadd2.Name = "BTNadd2"
        Me.BTNadd2.Size = New System.Drawing.Size(109, 36)
        Me.BTNadd2.TabIndex = 29
        Me.BTNadd2.Text = "Add New Vaccine Record"
        Me.BTNadd2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TXTvaxnumber)
        Me.GroupBox4.Controls.Add(Me.TXTmedperson)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.TXTpatient2)
        Me.GroupBox4.Controls.Add(Me.TXTage)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.TXTvaccine)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TXTdosage)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 166)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(272, 187)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "File Number:"
        '
        'TXTvaxnumber
        '
        Me.TXTvaxnumber.Enabled = False
        Me.TXTvaxnumber.Location = New System.Drawing.Point(75, 23)
        Me.TXTvaxnumber.Name = "TXTvaxnumber"
        Me.TXTvaxnumber.Size = New System.Drawing.Size(39, 20)
        Me.TXTvaxnumber.TabIndex = 32
        '
        'TXTmedperson
        '
        Me.TXTmedperson.Location = New System.Drawing.Point(109, 141)
        Me.TXTmedperson.Name = "TXTmedperson"
        Me.TXTmedperson.Size = New System.Drawing.Size(158, 20)
        Me.TXTmedperson.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(128, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Patient Number:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Med Personnel"
        '
        'TXTpatient2
        '
        Me.TXTpatient2.Enabled = False
        Me.TXTpatient2.Location = New System.Drawing.Point(217, 23)
        Me.TXTpatient2.Name = "TXTpatient2"
        Me.TXTpatient2.Size = New System.Drawing.Size(39, 20)
        Me.TXTpatient2.TabIndex = 15
        '
        'TXTage
        '
        Me.TXTage.Location = New System.Drawing.Point(109, 115)
        Me.TXTage.Name = "TXTage"
        Me.TXTage.Size = New System.Drawing.Size(158, 20)
        Me.TXTage.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Vaccine:"
        '
        'TXTvaccine
        '
        Me.TXTvaccine.Location = New System.Drawing.Point(109, 63)
        Me.TXTvaccine.Name = "TXTvaccine"
        Me.TXTvaccine.Size = New System.Drawing.Size(158, 20)
        Me.TXTvaccine.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Age"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Dosage"
        '
        'TXTdosage
        '
        Me.TXTdosage.Location = New System.Drawing.Point(109, 89)
        Me.TXTdosage.Name = "TXTdosage"
        Me.TXTdosage.Size = New System.Drawing.Size(158, 20)
        Me.TXTdosage.TabIndex = 19
        '
        'BTNsave
        '
        Me.BTNsave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTNsave.ForeColor = System.Drawing.Color.ForestGreen
        Me.BTNsave.Location = New System.Drawing.Point(167, 429)
        Me.BTNsave.Name = "BTNsave"
        Me.BTNsave.Size = New System.Drawing.Size(92, 36)
        Me.BTNsave.TabIndex = 20
        Me.BTNsave.Text = "Save"
        Me.BTNsave.UseVisualStyleBackColor = True
        '
        'BTNadd
        '
        Me.BTNadd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTNadd.ForeColor = System.Drawing.Color.Teal
        Me.BTNadd.Location = New System.Drawing.Point(22, 377)
        Me.BTNadd.Name = "BTNadd"
        Me.BTNadd.Size = New System.Drawing.Size(109, 36)
        Me.BTNadd.TabIndex = 19
        Me.BTNadd.Text = "Add New Patient Record"
        Me.BTNadd.UseVisualStyleBackColor = True
        '
        'BTNdelete
        '
        Me.BTNdelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTNdelete.ForeColor = System.Drawing.Color.Red
        Me.BTNdelete.Location = New System.Drawing.Point(22, 429)
        Me.BTNdelete.Name = "BTNdelete"
        Me.BTNdelete.Size = New System.Drawing.Size(127, 36)
        Me.BTNdelete.TabIndex = 18
        Me.BTNdelete.Text = "Delete A Record"
        Me.BTNdelete.UseVisualStyleBackColor = True
        '
        'TXTphone
        '
        Me.TXTphone.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TXTphone.Location = New System.Drawing.Point(115, 120)
        Me.TXTphone.Name = "TXTphone"
        Me.TXTphone.Size = New System.Drawing.Size(158, 20)
        Me.TXTphone.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Phone:"
        '
        'TXTfirstname
        '
        Me.TXTfirstname.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TXTfirstname.Location = New System.Drawing.Point(115, 94)
        Me.TXTfirstname.Name = "TXTfirstname"
        Me.TXTfirstname.Size = New System.Drawing.Size(158, 20)
        Me.TXTfirstname.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "First Name:"
        '
        'TXTsurname
        '
        Me.TXTsurname.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TXTsurname.Location = New System.Drawing.Point(115, 68)
        Me.TXTsurname.Name = "TXTsurname"
        Me.TXTsurname.Size = New System.Drawing.Size(158, 20)
        Me.TXTsurname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Surname:"
        '
        'TXTpatient
        '
        Me.TXTpatient.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TXTpatient.Enabled = False
        Me.TXTpatient.Location = New System.Drawing.Point(115, 42)
        Me.TXTpatient.Name = "TXTpatient"
        Me.TXTpatient.Size = New System.Drawing.Size(158, 20)
        Me.TXTpatient.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient Number:"
        '
        'TXTsearch
        '
        Me.TXTsearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXTsearch.Location = New System.Drawing.Point(322, 449)
        Me.TXTsearch.Name = "TXTsearch"
        Me.TXTsearch.Size = New System.Drawing.Size(166, 20)
        Me.TXTsearch.TabIndex = 28
        '
        'BTNsearch
        '
        Me.BTNsearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNsearch.ForeColor = System.Drawing.Color.Black
        Me.BTNsearch.Location = New System.Drawing.Point(503, 440)
        Me.BTNsearch.Name = "BTNsearch"
        Me.BTNsearch.Size = New System.Drawing.Size(77, 36)
        Me.BTNsearch.TabIndex = 27
        Me.BTNsearch.Text = "SEARCH PATIENT"
        Me.BTNsearch.UseVisualStyleBackColor = True
        '
        'BTNexit
        '
        Me.BTNexit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNexit.Location = New System.Drawing.Point(761, 440)
        Me.BTNexit.Name = "BTNexit"
        Me.BTNexit.Size = New System.Drawing.Size(75, 36)
        Me.BTNexit.TabIndex = 22
        Me.BTNexit.Text = "Exit"
        Me.BTNexit.UseVisualStyleBackColor = True
        '
        'BTNrefresh
        '
        Me.BTNrefresh.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNrefresh.Location = New System.Drawing.Point(602, 440)
        Me.BTNrefresh.Name = "BTNrefresh"
        Me.BTNrefresh.Size = New System.Drawing.Size(98, 36)
        Me.BTNrefresh.TabIndex = 21
        Me.BTNrefresh.Text = "Refresh Data"
        Me.BTNrefresh.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(319, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 189)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(514, 170)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView2)
        Me.GroupBox3.Location = New System.Drawing.Point(319, 220)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(520, 189)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(514, 170)
        Me.DataGridView2.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 524)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TXTsearch)
        Me.Controls.Add(Me.BTNsearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNexit)
        Me.Controls.Add(Me.BTNrefresh)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHEDS Prototype Database Program | Group A"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXTphone As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTfirstname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTsurname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTpatient As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTNexit As Button
    Friend WithEvents BTNrefresh As Button
    Friend WithEvents BTNsave As Button
    Friend WithEvents BTNadd As Button
    Friend WithEvents BTNdelete As Button
    Friend WithEvents BTNsearch As Button
    Friend WithEvents TXTsearch As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXTmedperson As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTpatient2 As TextBox
    Friend WithEvents TXTage As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTvaccine As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTdosage As TextBox
    Friend WithEvents BTNadd2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TXTvaxnumber As TextBox
End Class
