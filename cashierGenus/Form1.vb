Imports System.Drawing.Printing
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Net.Http.Json
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Newtonsoft.Json


Public Class Form1

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



        ' Iterate through the ListView control's Items collection.
        For i As Integer = 0 To ListView1.Items.Count - 1

            ' Get the item's text.
            Dim text As String = ListView1.Items(i).Text

            ' Print the item's text to the printer.
            e.Graphics.DrawString(text, New Font("Arial", 12), Brushes.Black, e.MarginBounds.Location)

        Next i

    End Sub
    Public Sub checkout()
        Dim post As New PostObject()
        Dim cnt = ListView1.Items.Count


        For i As Integer = 0 To ListView1.Items.Count - 1

            Dim Uri = "http://127.0.0.1:8000/cashier/storesales"

            Dim sku As String = ListView1.Items(i).SubItems(0).Text
            Dim submamount As String = ListView1.Items(i).SubItems(3).Text
            Dim qty As String = ListView1.Items(i).SubItems(2).Text

            post.transactionnum = transnum.Text
            post.branch = envbranch
            post.cashiernum = envcashiernum
            post.user = envuser
            post.sku = sku
            post.qty = qty
            post.amount = submamount
            post.totalamount = txtTotal.Text


            Dim json As String = JsonConvert.SerializeObject(post)
            Dim client As HttpClient = New HttpClient()
            client.BaseAddress = New Uri(Uri)
            client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json")) 'ACCEPT header

            Dim request As HttpRequestMessage = New HttpRequestMessage(HttpMethod.Post, Uri)
            request.Content = New StringContent(json, Encoding.UTF8, "application/json")

            client.SendAsync(request).ContinueWith(Sub(responseTask)


                                                   End Sub)

        Next i
        transactCash()
        MsgBox("Checkout Done")

        GetAPIData("http://127.0.0.1:8000/admin/addproduct/getproducts/cashier/" + envbranch)
        GetAPITransactionnum("http://127.0.0.1:8000/cashier/AddTranscationNumber/" + envbranch + "/" + envcashiernum)

        resetall()

    End Sub
    Private Sub GetAPIData(uri As String)
        Try
            Dim httpClient = New HttpClient()
            Dim webRequest = New HttpRequestMessage(HttpMethod.[Get], uri)
            Dim webResponse = httpClient.Send(webRequest)

            'MsgBox(responseBody.ToString)

            If webResponse.StatusCode = HttpStatusCode.OK Then
                Dim reader = New StreamReader(webResponse.Content.ReadAsStream)
                Dim responseBody = reader.ReadToEnd()

                'Dim jsonData As String = reader.ReadToEnd()

                'Dim objects As New List(Of Object)()
                'objects = JsonConvert.DeserializeObject(responseBody)
                Dim objects As List(Of Object) = JsonConvert.DeserializeObject(Of List(Of Object))(responseBody)

                DataGridView1.DataSource = objects
            Else
                MessageBox.Show(String.Format("Status code == {0}", webResponse.StatusCode))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Sub transactCash()
        Dim post As New PostTransactCash()

        Dim Uri = "http://127.0.0.1:8000/cashier/store_transaction_cash"

        post.transactionnum = transnum.Text
        post.branch = envbranch
        post.cashiernum = envcashiernum
        post.totalcash = txtcash.Text
        post.totalchange = txtchange.Text
        post.totalamount = txtTotal.Text


        Dim json As String = JsonConvert.SerializeObject(post)
        Dim client As HttpClient = New HttpClient()
        client.BaseAddress = New Uri(Uri)
        client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json")) 'ACCEPT header

        Dim request As HttpRequestMessage = New HttpRequestMessage(HttpMethod.Post, Uri)
        request.Content = New StringContent(json, Encoding.UTF8, "application/json")

        client.SendAsync(request).ContinueWith(Sub(responseTask)
                                               End Sub)

    End Sub

    Private Sub GetAPITransactionnum(uri As String)
        Try
            Dim httpClient = New HttpClient()
            Dim webRequest = New HttpRequestMessage(HttpMethod.[Get], uri)
            Dim webResponse = httpClient.Send(webRequest)

            'MsgBox(responseBody.ToString)

            If webResponse.StatusCode = HttpStatusCode.OK Then
                Dim reader = New StreamReader(webResponse.Content.ReadAsStream)
                Dim responseBody = reader.ReadToEnd()

                'Dim jsonData As String = reader.ReadToEnd()

                'Dim objects As New List(Of Object)()
                'objects = JsonConvert.DeserializeObject(responseBody)
                Dim objects As List(Of Object) = JsonConvert.DeserializeObject(Of List(Of Object))(responseBody)


                For Each obj In objects
                    transnum.Text = obj("transnum")
                Next



            Else
                MessageBox.Show(String.Format("Status code == {0}", webResponse.StatusCode))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetAPIData("http://127.0.0.1:8000/admin/addproduct/getproducts/cashier/" + envbranch)
        GetAPITransactionnum("http://127.0.0.1:8000/cashier/GetTransactionNum/" + envbranch + "/" + envcashiernum)
    End Sub




    Private Sub dataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        ' Get the cell that was clicked.
        Dim clickedCell As DataGridViewCell = DataGridView1.CurrentCell

        ' Get the row that contains the clicked cell.
        Dim clickedRow As DataGridViewRow = clickedCell.OwningRow

        ' Select the row.
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

        listViewItem.Text = selectedRow.Cells(0).Value.ToString()
        listViewItem.SubItems.Add(selectedRow.Cells(1).Value.ToString())
        listViewItem.SubItems.Add(selectedRow.Cells(3).Value.ToString())
        listViewItem.SubItems.Add(userQty)
        listViewItem.SubItems.Add(Val(selectedRow.Cells(3).Value.ToString()) * userQty)

        ListView1.Items.Add(listViewItem)
        txtTotal.Text = CalculateTotalAmount()
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

    Private Sub txtsku_TextChanged(sender As Object, e As EventArgs) Handles txtsku.TextChanged
        GetAPIData("http://127.0.0.1:8000/admin/addproduct/getproducts/cashier/b1/" + txtsku.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checkout()
    End Sub

End Class
Public Class PostObject

    Public Property branch As String
    Public Property transactionnum As String
    Public Property sku As String
    Public Property qty As String
    Public Property amount As String
    Public Property totalamount As String

    Public Property user As String
    Public Property cashiernum As String

End Class

Public Class PostTransactCash

    Public Property branch As String
    Public Property transactionnum As String
    Public Property totalamount As String

    Public Property totalcash As String

    Public Property totalchange As String
    Public Property cashiernum As String

End Class
