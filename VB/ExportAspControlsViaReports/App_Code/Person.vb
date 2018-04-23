Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace ExportAspControlsViaReports
	Public Class Person

		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateSurname As String
		Public Property Surname() As String
			Get
				Return privateSurname
			End Get
			Set(ByVal value As String)
				privateSurname = value
			End Set
		End Property
		Private privateGendor As String
		Public Property Gendor() As String
			Get
				Return privateGendor
			End Get
			Set(ByVal value As String)
				privateGendor = value
			End Set
		End Property
		Private privateAge As Integer
		Public Property Age() As Integer
			Get
				Return privateAge
			End Get
			Set(ByVal value As Integer)
				privateAge = value
			End Set
		End Property
	End Class
End Namespace