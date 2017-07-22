Option Explicit On
'Class to define a bolt object
Public Class Bolt
	'Private variables to store values
	Private pDiameter As Double
	Private pASTM As String
	Private pSurfaceClass As String
	'OBJECT CONSTRUCTORS
	Public Sub New()
		'Empty object constructor
	End Sub
	Public Sub New(ByVal s As String)
		'Constructor that processes a string input
	End Sub
	Public Sub New(ByVal Diameter As Double, ASTM As String)
		'Constructor that accepts diameter and ASTM inputs
		Me.Diameter = Diameter
		Me.ASTM = ASTM
	End Sub

	Property Diameter As Double
		Get
			Return pDiameter
		End Get
		Set(ByVal value As Double)
			Dim Diameters As Double() = {0.5, 0.625, 0.75, 0.875, 1.0, 1.125, 1.25}
			If Diameters.Contains(value) Then
				'Raise change event and change property value only if value is actually changing.
				If value <> pDiameter Then
					RaiseEvent BoltDiameterChanged(NewDiameter:=value, OldDiameter:=pDiameter)
					pDiameter = value
					_Area = 3.14159 * pDiameter ^ 2 / 4
				End If
			Else
				Throw New System.ArgumentOutOfRangeException()
			End If

		End Set
	End Property

	ReadOnly Property Area As Double
	Property Length As Double
	Property ASTM As String
		Get
			Return pASTM
		End Get
		Set(ByVal value As String)
			Dim ASTMS As String() = {"A325", "A490", "F1554"}
			If ASTMS.Contains(value) Then
				pASTM = value
			Else
				Throw New System.ArgumentException(message:="Invalid ASTM")
			End If
		End Set
	End Property
	Property SlipCritical As Boolean
	Property SurfaceClass As String
		Get
			Return pSurfaceClass
		End Get
		Set(ByVal value As String)
			Dim Surfaces As String() = {"A", "B"}
			If Surfaces.Contains(value) Then
				pSurfaceClass = value
			Else
				Throw New ArgumentException(message:="Invalid Surface Class")
			End If
		End Set
	End Property
	'CLASS EVENTS
	Public Event BoltDiameterChanged(ByVal NewDiameter As Double, ByVal OldDiameter As Double)
End Class
