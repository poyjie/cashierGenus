Imports System.Drawing.Printing
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Net.Http.Json
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json

Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection
    Dim cmd As New MySqlCommand

    Dim envbranch As String = "b1" 'Environment.GetEnvironmentVariable("envbranch")
    Dim envcashiernum As String = "c1" 'Environment.GetEnvironmentVariable("envcashiernum")
    Dim envuser As String = "cuser1" 'Environment.GetEnvironmentVariable("envcashiernum")

    Sub resetall()
        ListView1.Items.Clear()
        txtcash.Clear()
        txtchange.Clear()
        txtTotal.Clear()
    End Sub


    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        For i As Integer = 0 To ListView1.Items.Count - 1
            Dim text As String = ListView1.Items(i).Text
            e.Graphics.DrawString(text, New Font("Arial", 12), Brushes.Black, e.MarginBounds.Location)
        Next i
    End Sub

    Private Sub reportprint()
        Dim conn As New MySqlConnection
        Dim cmd As New MySqlCommand
        conn.ConnectionString = "Server=localhost; user id=root; password=; database=genus_inventory;"
        cmd.Connection = conn
        conn.Open()

        Dim id As Integer
        cmd.CommandText = "SELECT *  FROM v_transaction_cash where Id_student ='" & id & "'"

        Dim da As New MySqlDataAdapter 'DataAdapter can be used to fill DataSet
        Dim ds As New DataSet
        da.SelectCommand = cmd
        da.Fill(ds, "transacions")
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Server=localhost; user id=root; password=; database=genus_inventory;"
        cmd.Connection = conn
        conn.Open()


        cmd.CommandText = "SELECT sku,name,sellprice,stock FROM v_stock_v1 where branchname='" & envbranch & "'"

        Dim da As New MySqlDataAdapter
        Dim dt As New DataTable()
        da.SelectCommand = cmd
        da.Fill(dt)

        DataGridView1.DataSource = dt

    End Sub


    Private Sub dataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        Dim clickedCell As DataGridViewCell = DataGridView1.CurrentCell
        Dim clickedRow As DataGridViewRow = clickedCell.OwningRow
        clickedRow.Selected = True
    End Sub
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        ' Get the cell that was clicked.
        Dim clickedCell As DataGridViewCell = DataGridView1.CurrentCell

        ' Get the row that contains the clicked cell.
        Dim clickedRow As DataGridViewRow = clickedCell.OwningRow

        ' Select the row.
        clickedRow.Selected = True

        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

        Dim listViewItem As New ListViewItem()
        Dim userQty As String
        userQty = InputBox("Quantity For :" + selectedRow.Cells(1).Value.ToString(), "Input Quantity", , )
        If userQty <> "" Then
            listViewItem.Text = selectedRow.Cells(0).Value.ToString()
            listViewItem.SubItems.Add(selectedRow.Cells(1).Value.ToString())
            listViewItem.SubItems.Add(selectedRow.Cells(3).Value.ToString())
            listViewItem.SubItems.Add(userQty)

            listViewItem.SubItems.Add(Val(selectedRow.Cells(3).Value.ToString()) * userQty)

            ListView1.Items.Add(listViewItem)
            txtTotal.Text = CalculateTotalAmount()
        Else
            Exit Sub
        End If

    End Sub
    Private Function CalculateTotalAmount() As Double
        Dim totalAmount As Double = 0

        For Each item As ListViewItem In ListView1.Items
            ' If the item has a subitem in the second column, add the value of that subitem to the total amount.
            If item.SubItems.Count > 1 Then
                totalAmount += Convert.ToDouble(item.SubItems(4).Text)
            End If
        Next

        Return totalAmount
    End Function

    Private Sub txtcash_TextChanged(sender As Object, e As EventArgs) Handles txtcash.TextChanged
        txtchange.Text = Val(txtcash.Text) - Val(txtTotal.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        resetall()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncheckout.Click

    End Sub

End Class
