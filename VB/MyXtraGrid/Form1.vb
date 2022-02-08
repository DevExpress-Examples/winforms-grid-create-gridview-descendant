Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace MyXtraGrid

    Public Partial Class Form1
        Inherits Form

        Private customers As BindingList(Of Customer)

        Public Sub New()
            InitializeComponent()
            FillGridDataSource()
        End Sub

        Private Sub FillGridDataSource()
            customers = New BindingList(Of Customer)()
            For i As Integer = 0 To 50 - 1
                Dim customer As Customer = New Customer()
                customer.Name = "Mike"
                If i Mod 2 = 0 Then customer.Name = "John"
                customer.Age = 70 - i
                customer.Weight = 50 + i
                customer.Height = 150 + i
                customers.Add(customer)
            Next

            myGridControl1.DataSource = customers
        End Sub
    End Class
End Namespace
