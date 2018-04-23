Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace MyXtraGrid
	Public Class Customer
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private name_Renamed As String
'INSTANT VB NOTE: The variable age was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private age_Renamed As Integer
'INSTANT VB NOTE: The variable weight was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private weight_Renamed As Integer
'INSTANT VB NOTE: The variable height was renamed since Visual Basic does not allow variables and other class members to have the same name:
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
