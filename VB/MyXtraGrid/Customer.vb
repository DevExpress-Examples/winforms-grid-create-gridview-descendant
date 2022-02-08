Namespace MyXtraGrid

    Public Class Customer

        Private nameField As String

        Private ageField As Integer

        Private weightField As Integer

        Private heightField As Integer

        Public Property Name As String
            Get
                Return nameField
            End Get

            Set(ByVal value As String)
                nameField = value
            End Set
        End Property

        Public Property Age As Integer
            Get
                Return ageField
            End Get

            Set(ByVal value As Integer)
                ageField = value
            End Set
        End Property

        Public Property Weight As Integer
            Get
                Return weightField
            End Get

            Set(ByVal value As Integer)
                weightField = value
            End Set
        End Property

        Public Property Height As Integer
            Get
                Return heightField
            End Get

            Set(ByVal value As Integer)
                heightField = value
            End Set
        End Property
    End Class
End Namespace
