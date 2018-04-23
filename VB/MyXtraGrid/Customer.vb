Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace MyXtraGrid
	Public Class Customer
		Private name_Renamed As String
		Private age_Renamed As Integer
		Private weight_Renamed As Integer
		Private height_Renamed As Integer

		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property
		Public Property Age() As Integer
			Get
				Return age_Renamed
			End Get
			Set(ByVal value As Integer)
				age_Renamed = value
			End Set
		End Property
		Public Property Weight() As Integer
			Get
				Return weight_Renamed
			End Get
			Set(ByVal value As Integer)
				weight_Renamed = value
			End Set
		End Property
		Public Property Height() As Integer
			Get
				Return height_Renamed
			End Get
			Set(ByVal value As Integer)
				height_Renamed = value
			End Set
		End Property
	End Class
End Namespace
