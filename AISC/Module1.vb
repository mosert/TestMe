Option Explicit On

Module Module1
	Private WithEvents BoltEvents As New Bolt
	Public Sub TestBoltEvents()
		Dim Values As Double() = {0.75, 1.0, 1.125, 1.125}
		Dim N As Double
		For Each N In Values
			Debug.Print("A new diameter property value is being set")
			BoltEvents.Diameter = N
		Next
	End Sub

	Private Sub BoltEvents_BoltDiameterChanged(NewDiameter As Double, OldDiameter As Double) Handles BoltEvents.BoltDiameterChanged
		Debug.Print(NewDiameter)
	End Sub
End Module
