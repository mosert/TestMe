Option Explicit On
Public Class ShearTab
	'Private variables
	Private pBoltRows As Integer
	Private pBolts As Bolt

	Public Property Boltrows As Integer
		Get
			Return pBoltRows
		End Get
		Set(ByVal value As Integer)
			If value > 2 And value < 12 Then
				pBoltRows = value
			Else
				Throw New System.ArgumentException(message:="The number of bolt rows must be between 2 & 12")
			End If
		End Set
	End Property
	Public Property Bolts As Bolt
		Get
			Return pBolts
		End Get
		Set(ByVal value As Bolt)
			'If IsNothing(pBolts) Then
			'	pBolts = New Bolt
			'End If
		End Set
	End Property
End Class
