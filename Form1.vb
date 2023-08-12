
Imports System.Data.SQLite

Public Class Form1

    '---------------------------------------------------------------------------------------
    ' CREATE VARIABLES
    '---------------------------------------------------------------------------------------

    Private dbCommand As String = ""
    Private dbCommand2 As String = ""
    Private bindingSrc As New BindingSource()
    Private bindingSrc2 As New BindingSource()
    Private bindingSrc3 As New BindingSource()

    Private dbName As String = "CHEDSdb.db;"
    Private dbPath As String = Application.StartupPath & "\" & dbName
    Private conString As String = "Data Source=" & dbPath & "Version=3;New=False;Compress=True;"

    Private connection As New SQLiteConnection(conString)
    Private command As New SQLiteCommand("", connection)
    Private command2 As New SQLiteCommand("", connection)
    Private command3 As New SQLiteCommand("", connection)

    Private sql As String = ""
    Private sql2 As String = ""

    Shared BTN1C As Color
    Shared BTN2C As Color
    Shared BTNdelC As Color

    Private Sub Table()

        Dim tb As TextBox
        For Each ctr As Control In GroupBox1.Controls
            If TypeOf ctr Is TextBox Then
                tb = CType(ctr, TextBox)
                tb.DataBindings.Clear()
                tb.Text = ""
                If tb.Name.Equals("TXTsurname") Then
                    If tb.CanFocus Then
                        tb.Focus()
                    End If
                End If
            End If
        Next

    End Sub

    Private Sub Table2()

        Dim tb As TextBox
        For Each ctr As Control In GroupBox4.Controls
            If TypeOf ctr Is TextBox Then
                tb = CType(ctr, TextBox)
                tb.DataBindings.Clear()
                tb.Text = ""
                If tb.Name.Equals("TXTvaccine") Then
                    If tb.CanFocus Then
                        tb.Focus()
                    End If
                End If
            End If
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '---------------------------------------------------------------------------------------
        ' ESTABLISH PATIENT TABLE CONNECTION
        '---------------------------------------------------------------------------------------

        connection.Open()

        UpdateDataBiding()

        connection.Close()

        BTN1C = BTNadd.ForeColor
        BTN2C = BTNadd2.ForeColor
        BTNdelC = BTNdelete.ForeColor

    End Sub

    Private Sub UpdateDataBiding(Optional cmd As SQLiteCommand = Nothing)

        '---------------------------------------------------------------------------------------
        ' 1ST DATAGRID VIEW (FOR PATIENT RECORD)
        '---------------------------------------------------------------------------------------

        Try

            If cmd Is Nothing Then
                command.CommandText = "select * from PATIENTtable order by PATIENTNUMBER ASC"
            Else
                command = cmd
            End If

            Dim adapter As New SQLiteDataAdapter(command)
            Dim dataSt As New DataSet()
            adapter.Fill(dataSt, "CHEDS DATABASE")

            bindingSrc = New BindingSource()
            bindingSrc.DataSource = dataSt.Tables("CHEDS DATABASE")

            Dim tb As TextBox
            For Each ctr As Control In GroupBox1.Controls
                If TypeOf ctr Is TextBox Then
                    tb = CType(ctr, TextBox)
                    tb.DataBindings.Clear()
                    tb.Text = ""
                End If
            Next

            TXTpatient.DataBindings.Add("text", bindingSrc, "PATIENTNUMBER")
            TXTsurname.DataBindings.Add("text", bindingSrc, "SURNAME")
            TXTfirstname.DataBindings.Add("text", bindingSrc, "FIRSTNAME")
            TXTphone.DataBindings.Add("text", bindingSrc, "CONTACTNUMBER")

            DataGridView1.Enabled = True
            DataGridView1.DataSource = bindingSrc
            DataGridView1.AutoResizeColumns(CType(DataGridViewAutoSizeColumnsMode.AllCells, DataGridViewAutoSizeColumnsMode))
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            'DataGridView1.Columns(0).Width = 60

        Catch ex As Exception
            MessageBox.Show("Data Binding error: " & ex.Message.ToString())
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        '---------------------------------------------------------------------------------------
        ' ESTABLISH VACCINE TABLE CONNECTION
        '---------------------------------------------------------------------------------------

        connection.Open()

        UpdateDataBiding2()

        connection.Close()

    End Sub

    Private Sub UpdateDataBiding2(Optional cmd2 As SQLiteCommand = Nothing)

        '---------------------------------------------------------------------------------------
        ' 2ND DATAGRID VIEW (FOR VACCINE RECORD)
        '---------------------------------------------------------------------------------------

        Try

            If cmd2 Is Nothing Then
                command2.CommandText = "select * from VACCINEtable where PATIENTNUMBER =" + CStr(TXTpatient.Text)
            Else
                command2 = cmd2
            End If

            Dim adapter2 As New SQLiteDataAdapter(command2)
            Dim dataSt2 As New DataSet()
            adapter2.Fill(dataSt2, "CHEDS DATABASE")

            bindingSrc2 = New BindingSource()
            bindingSrc2.DataSource = dataSt2.Tables("CHEDS DATABASE")

            Dim tb2 As TextBox
            For Each ctr2 As Control In GroupBox4.Controls
                If TypeOf ctr2 Is TextBox Then
                    tb2 = CType(ctr2, TextBox)
                    tb2.DataBindings.Clear()
                    tb2.Text = ""
                End If
            Next

            TXTvaxnumber.DataBindings.Add("text", bindingSrc2, "VACCINENUMBER")
            TXTpatient2.DataBindings.Add("text", bindingSrc, "PATIENTNUMBER")
            TXTvaccine.DataBindings.Add("text", bindingSrc2, "VACCINE")
            TXTdosage.DataBindings.Add("text", bindingSrc2, "DOSAGE")
            TXTage.DataBindings.Add("text", bindingSrc2, "AGE")
            TXTmedperson.DataBindings.Add("text", bindingSrc2, "MEDPERSON")

            DataGridView2.Enabled = True
            DataGridView2.DataSource = bindingSrc2
            DataGridView2.AutoResizeColumns(CType(DataGridViewAutoSizeColumnsMode.AllCells, DataGridViewAutoSizeColumnsMode))
            DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView2.Columns(0).Visible = False

        Catch ex As Exception
            MessageBox.Show("Data Binding 2 error: " & ex.Message.ToString())
        End Try

    End Sub

    Private Sub normal()

        BTNdelete.Enabled = True
        BTNadd.Enabled = True
        BTNadd2.Enabled = True
        BTNsave.Enabled = True
        BTNsearch.Enabled = True
        TXTsearch.Enabled = True
        BTNrefresh.Enabled = True

        BTNadd.Text = "Add New Patient Record"
        BTNadd2.Text = "Add New Vaccine Record"
        BTNdelete.Text = "Delete A Record"

        TXTsurname.Enabled = True
        TXTfirstname.Enabled = True
        TXTphone.Enabled = True
        TXTvaccine.Enabled = True
        TXTdosage.Enabled = True
        TXTage.Enabled = True
        TXTmedperson.Enabled = True

        DataGridView1.Enabled = True
        DataGridView2.Enabled = True

    End Sub

    Private Sub BTNexit_Click(sender As Object, e As EventArgs) Handles BTNexit.Click

        '---------------------------------------------------------------------------------------
        ' EXIT PROGRAM
        '---------------------------------------------------------------------------------------

        Application.Exit()

    End Sub

    Private Sub BTNadd_Click(sender As Object, e As EventArgs) Handles BTNadd.Click

        '---------------------------------------------------------------------------------------
        ' ADD BUTTON 1 (FOR PATIENT RECORD)
        '---------------------------------------------------------------------------------------

        With BTNadd
            If .Text = "Add New Patient Record" Then
                .Text = "Cancel"
                DataGridView1.ClearSelection()
                DataGridView1.Enabled = False
                BTNdelete.Enabled = False
                Table()
                BTNadd2.Enabled = False
                BTNsearch.Enabled = False
                TXTsearch.Enabled = False
                BTNrefresh.Enabled = False
                TXTvaccine.Enabled = False
                TXTdosage.Enabled = False
                TXTage.Enabled = False
                TXTmedperson.Enabled = False

            ElseIf .Text = "Delete Selected PATIENT Record" Then

                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                Try

                    If MessageBox.Show("PATIENT NUMBER: " & TXTpatient.Text.Trim() &
                                        " --> Do You Want to Delete the Selected Patient Record and ALL ITS VACCINE RECORDS?",
                                        "CHEDS: (DELETE) Patient Record",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                                         MessageBoxDefaultButton.Button2) = DialogResult.No Then
                        Exit Sub
                    End If

                    dbCommand = "DELETED"

                    sql = "DELETE FROM PATIENTtable WHERE PATIENTNUMBER = @PATIENTNUMBER"

                    command.Parameters.Clear()
                    command.CommandText = sql
                    command.Parameters.AddWithValue("PATIENTNUMBER", TXTpatient.Text.Trim())

                    sql2 = "DELETE FROM VACCINEtable WHERE PATIENTNUMBER = @PATIENTNUMBER"

                    command2.Parameters.Clear()
                    command2.CommandText = sql2
                    command2.Parameters.AddWithValue("PATIENTNUMBER", TXTpatient2.Text.Trim())

                    Dim execute As Integer = command.ExecuteNonQuery()

                    If execute = 1 Then

                        MessageBox.Show("CHEDS Patient Record has been " & dbCommand & " Succesfully.",
                                        "CHEDS : (DELETE) Patient Record",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information)
                        UpdateDataBiding()
                        UpdateDataBiding2()

                    End If

                Catch ex As Exception
                    MessageBox.Show("Delete Error: " & ex.Message.ToString(),
                                    "CHEDS: (DELETE) Error ",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    dbCommand = ""
                    dbCommand2 = ""
                    connection.Close()
                End Try

            Else
                .Text = "Add New Patient Record"
                UpdateDataBiding()
                DataGridView1.ClearSelection()
                normal()
                Exit Sub
            End If
        End With

    End Sub

    Private Sub BTNadd2_Click_1(sender As Object, e As EventArgs) Handles BTNadd2.Click

        '---------------------------------------------------------------------------------------
        ' ADD BUTTON 2 (FOR VACCINE RECORD)
        '---------------------------------------------------------------------------------------

        With BTNadd2
            If .Text = "Add New Vaccine Record" Then
                .Text = "Cancel"
                DataGridView2.ClearSelection()
                DataGridView1.Enabled = False
                DataGridView2.Enabled = False
                BTNdelete.Enabled = False
                Table2()
                BTNadd.Enabled = False
                BTNsearch.Enabled = False
                TXTsearch.Enabled = False
                BTNrefresh.Enabled = False
                TXTsurname.Enabled = False
                TXTfirstname.Enabled = False
                TXTphone.Enabled = False
                TXTpatient2.DataBindings.Add("text", bindingSrc, "PATIENTNUMBER")

            ElseIf .Text = "Delete Selected VACCINE Record" Then

                If TXTvaxnumber.Text = "" Then
                    MessageBox.Show("There is no Vaccine Record Present.",
                            "CHEDS : (DELETE) Vaccine Record Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                Try

                    If MessageBox.Show("PATIENT NUMBER: " & TXTpatient2.Text.Trim() &
                                        " --> Do You Want to Delete the Selected Vaccine Record?",
                                        "CHEDS: (DELETE) Patient Record",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                         MessageBoxDefaultButton.Button2) = DialogResult.No Then
                        Exit Sub
                    End If

                    dbCommand2 = "DELETED"

                    sql2 = "DELETE FROM VACCINEtable WHERE VACCINENUMBER = @VACCINENUMBER"

                    command2.Parameters.Clear()
                    command2.CommandText = sql2
                    command2.Parameters.AddWithValue("VACCINENUMBER", TXTvaxnumber.Text.Trim())

                    Dim execute2 As Integer = command2.ExecuteNonQuery()

                    If execute2 = 1 Then

                        MessageBox.Show("CHEDS Vaccine Record has been " & dbCommand2 & " Succesfully.",
                                        "CHEDS : (DELETE) Patient Record",
                                         MessageBoxButtons.OK, MessageBoxIcon.Information)
                        UpdateDataBiding2()

                    End If

                Catch ex As Exception
                    MessageBox.Show("Delete Error: " & ex.Message.ToString(),
                                    "CHEDS: (DELETE) Error ",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    dbCommand2 = ""
                    connection.Close()

                End Try

            Else
                .Text = "Add New Vaccine Record"
                UpdateDataBiding2()
                DataGridView2.ClearSelection()
                normal()
                Exit Sub
            End If
        End With

    End Sub

    Private Sub addCmdParameters()

        '---------------------------------------------------------------------------------------
        ' ADD PARAMETER DATABASE 1
        '---------------------------------------------------------------------------------------

        command.Parameters.Clear()
        command.CommandText = sql

        command.Parameters.AddWithValue("SURNAME", TXTsurname.Text.Trim())
        command.Parameters.AddWithValue("FIRSTNAME", TXTfirstname.Text.Trim())
        command.Parameters.AddWithValue("CONTACTNUMBER", TXTphone.Text.Trim())

        If dbCommand.ToUpper() = "UPDATED" Then
            command.Parameters.AddWithValue("PATIENTNUMBER", TXTpatient.Text.Trim())
        End If

    End Sub

    Private Sub addCmdParameters2()

        '---------------------------------------------------------------------------------------
        ' ADD PARAMETER DATABASE 2
        '---------------------------------------------------------------------------------------

        command2.Parameters.Clear()
        command2.CommandText = sql2

        command2.Parameters.AddWithValue("PATIENTNUMBER", TXTpatient2.Text.Trim())
        command2.Parameters.AddWithValue("VACCINE", TXTvaccine.Text.Trim())
        command2.Parameters.AddWithValue("DOSAGE", TXTdosage.Text.Trim())
        command2.Parameters.AddWithValue("AGE", TXTage.Text.Trim())
        command2.Parameters.AddWithValue("MEDPERSON", TXTmedperson.Text.Trim())

        If dbCommand2.ToUpper() = "UPDATED" Then
            command2.Parameters.AddWithValue("VACCINENUMBER", TXTvaxnumber.Text.Trim())
        End If

    End Sub

    Private Sub BTNsave_Click(sender As Object, e As EventArgs) Handles BTNsave.Click

        '---------------------------------------------------------------------------------------
        ' SAVE BUTTON
        '---------------------------------------------------------------------------------------

        If TXTpatient2.Text = "" And BTNadd.Text.Equals("Add New Patient Record") And BTNadd2.Text.Equals("Add New Vaccine Record") Then

            If String.IsNullOrEmpty(TXTvaccine.Text.Trim()) Or
                String.IsNullOrEmpty(TXTdosage.Text.Trim()) Or
                String.IsNullOrEmpty(TXTage.Text.Trim()) Or
                String.IsNullOrEmpty(TXTmedperson.Text.Trim()) Then

                MessageBox.Show("Please Select A Patient Record.",
                            "CHEDS : (SAVE) Patient Record Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

        ElseIf BTNadd.Text.Equals("Cancel") Then

            If String.IsNullOrEmpty(TXTsurname.Text.Trim()) Or
                String.IsNullOrEmpty(TXTfirstname.Text.Trim()) Or
                String.IsNullOrEmpty(TXTphone.Text.Trim()) Then

                MessageBox.Show("Please Fill In the Patient Record.",
                            "CHEDS : (SAVE) Patient Record Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

        ElseIf BTNadd2.Text.Equals("Cancel") And TXTpatient2.Text <> "" Then

            If String.IsNullOrEmpty(TXTvaccine.Text.Trim()) Or
                String.IsNullOrEmpty(TXTdosage.Text.Trim()) Or
                String.IsNullOrEmpty(TXTage.Text.Trim()) Or
                String.IsNullOrEmpty(TXTmedperson.Text.Trim()) Then

                MessageBox.Show("Please Fill In the Vaccine Record.",
                            "CHEDS : (SAVE) Vaccine Record Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

        End If

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try

            If BTNadd.Text = "Add New Patient Record" And BTNadd2.Text = "Add New Vaccine Record" Then

                If MessageBox.Show("PATIENT NUMBER: " & TXTpatient2.Text.Trim() &
                               " --> Do You Want to Update the Selected Patient/Vaccine Record?",
                               "CHEDS : (UPDATE) Patient/Vaccine Record",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2) = DialogResult.No Then
                    UpdateDataBiding()
                    UpdateDataBiding2()
                    Exit Sub
                End If

                dbCommand = "UPDATED"

                sql = "UPDATE PATIENTtable SET SURNAME = @SURNAME, FIRSTNAME = @FIRSTNAME, 
                        CONTACTNUMBER = @CONTACTNUMBER WHERE PATIENTNUMBER = @PATIENTNUMBER"

                addCmdParameters()

                dbCommand2 = "UPDATED"

                sql2 = "UPDATE VACCINEtable SET PATIENTNUMBER = @PATIENTNUMBER, VACCINE = @VACCINE, DOSAGE = @DOSAGE, 
                                        AGE = @AGE, MEDPERSON = @MEDPERSON WHERE VACCINENUMBER = @VACCINENUMBER"

                addCmdParameters2()

            ElseIf BTNadd.Text.Equals("Cancel") Then

                Dim result As DialogResult
                result = MessageBox.Show("Do You Want to Add New Patient Record?",
                                     "CHEDS : (INSERT) New Patient Record",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then

                    dbCommand = "INSERTED"

                    sql = "INSERT INTO PATIENTtable(SURNAME, FIRSTNAME, CONTACTNUMBER)" &
                      "VALUES(@SURNAME, @FIRSTNAME, @CONTACTNUMBER)"

                    addCmdParameters()

                Else
                    UpdateDataBiding()
                    UpdateDataBiding2()
                    Exit Sub
                End If

            ElseIf BTNadd2.Text.Equals("Cancel") Then

                Dim result2 As DialogResult
                result2 = MessageBox.Show("Do You Want to Add New Vaccine Record?",
                                     "CHEDS : (INSERT) New Vaccine Record",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result2 = DialogResult.Yes Then

                    dbCommand2 = "INSERTED"

                    sql2 = "INSERT INTO VACCINEtable(PATIENTNUMBER, VACCINE, DOSAGE, AGE, MEDPERSON)" &
                      "VALUES(@PATIENTNUMBER, @VACCINE, @DOSAGE, @AGE, @MEDPERSON)"

                    addCmdParameters2()

                Else
                    UpdateDataBiding()
                    UpdateDataBiding2()
                    Exit Sub
                End If

            End If

            Dim execute As Integer = command.ExecuteNonQuery()
            Dim execute2 As Integer = command2.ExecuteNonQuery()

            If BTNadd.Text = "Add New Patient Record" And BTNadd2.Text = "Add New Vaccine Record" Then

                If execute = -1 Or execute2 = -1 Then
                    MessageBox.Show("Data was Not Saved", "Fail to Save Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Stop)

                Else
                    MessageBox.Show("CHEDS New Patient/Vaccine Record has been " & dbCommand & "/" & dbCommand2 & " Successfully.",
                               "CHEDS : (SAVE) Patient/Vaccine Record",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)

                    UpdateDataBiding()
                    BTNadd.Text = "Add New Patient Record"

                    UpdateDataBiding2()
                    BTNadd2.Text = "Add New Vaccine Record"
                End If

            ElseIf BTNadd.Text = "Cancel" Then

                If execute = -1 Then
                    MessageBox.Show("Data was Not Saved", "Fail to Save Data",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop)

                Else
                    MessageBox.Show("CHEDS New Patient Record has been " & dbCommand & " Successfully.",
                               "CHEDS : (SAVE) Patient Record",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)

                    UpdateDataBiding()
                    BTNadd.Text = "Add New Patient Record"
                End If

            ElseIf BTNadd2.Text = "Cancel" Then

                If execute2 = -1 Then
                    MessageBox.Show("Data was Not Saved", "Fail to Save Data",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop)

                Else
                    MessageBox.Show("CHEDS New Vaccine Record has been " & dbCommand2 & " Successfully.",
                               "CHEDS : (SAVE) Vaccine Record",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)

                    UpdateDataBiding2()
                    BTNadd2.Text = "Add New Vaccine Record"
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message.ToString(),
                        "CHEDS : (SAVE) Patient/Vaccine Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            normal()
            dbCommand = ""
            dbCommand2 = ""
            connection.Close()
        End Try

    End Sub

    Private Sub BTNdelete_Click(sender As Object, e As EventArgs) Handles BTNdelete.Click

        '---------------------------------------------------------------------------------------
        ' DELETE BUTTON
        '---------------------------------------------------------------------------------------

        With BTNdelete

            If .Text = "Delete A Record" Then
                DataGridView1.ClearSelection()
                DataGridView2.ClearSelection()
                BTNadd.Text = "Delete Selected PATIENT Record"
                BTNadd.ForeColor = BTNDelC
                BTNadd2.Text = "Delete Selected VACCINE Record"
                BTNadd2.ForeColor = BTNDelC
                .Text = "Cancel"
                .ForeColor = Color.Black
                BTNsave.Enabled = False
                BTNsearch.Enabled = False
                TXTsearch.Enabled = False
                BTNrefresh.Enabled = False
                TXTsurname.Enabled = False
                TXTfirstname.Enabled = False
                TXTphone.Enabled = False
                TXTvaccine.Enabled = False
                TXTdosage.Enabled = False
                TXTage.Enabled = False
                TXTmedperson.Enabled = False
            Else
                DataGridView1.ClearSelection()
                DataGridView2.ClearSelection()
                BTNadd.Text = "Add New Patient Record"
                BTNadd.ForeColor = BTN1C
                BTNadd2.Text = "Add New Vaccine Record"
                BTNadd2.ForeColor = BTN2C
                .Text = "Delete A Record"
                .ForeColor = BTNdelC
                normal()
            End If

        End With

    End Sub

    Private Sub BTNsearch_Click(sender As Object, e As EventArgs) Handles BTNsearch.Click

        '---------------------------------------------------------------------------------------
        ' SEARCH BUTTON
        '---------------------------------------------------------------------------------------

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If

        Try

            If String.IsNullOrEmpty(TXTsearch.Text.Trim()) Then
                UpdateDataBiding()
                Exit Sub
            End If

            sql = "SELECT * FROM PATIENTtable "
            sql &= "WHERE PATIENTNUMBER LIKE @keyword2 "
            sql &= "OR SURNAME LIKE @keyword2 "
            sql &= "OR FIRSTNAME LIKE @keyword2 "
            sql &= "OR CONTACTNUMBER LIKE @keyword2 "
            sql &= "ORDER BY PATIENTNUMBER ASC"

            command.CommandType = CommandType.Text
            command.CommandText = sql

            command.Parameters.Clear()

            Dim keywordString As String = String.Format("%{0}%", TXTsearch.Text)

            command.Parameters.AddWithValue("@keyword1", TXTsearch.Text)
            command.Parameters.AddWithValue("@keyword2", keywordString)

            UpdateDataBiding(command)
            UpdateDataBiding2()

        Catch ex As Exception
            MessageBox.Show("Search Error: " & ex.Message.ToString(),
                            "CHEDS: (SEARCH) Error ",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
            TXTsearch.Focus()
        End Try

    End Sub

    Private Sub BTNrefresh_Click(sender As Object, e As EventArgs) Handles BTNrefresh.Click

        '---------------------------------------------------------------------------------------
        ' REFRESH BUTTON
        '---------------------------------------------------------------------------------------

        UpdateDataBiding()
        DataGridView1.ClearSelection()
        UpdateDataBiding2()
        DataGridView2.ClearSelection()
        DataGridView2.DataSource = ""

        Dim tb2 As TextBox
        For Each ctr2 As Control In GroupBox4.Controls
            If TypeOf ctr2 Is TextBox Then
                tb2 = CType(ctr2, TextBox)
                tb2.DataBindings.Clear()
                tb2.Text = ""
            End If
        Next

        BTNadd.Text = "Add New Patient Record"
        BTNadd.ForeColor = BTN1C
        BTNadd2.Text = "Add New Vaccine Record"
        BTNadd2.ForeColor = BTN2C
        BTNdelete.Text = "Delete A Record"
        BTNsave.Enabled = True
        TXTsearch.Text = ""

    End Sub

End Class
