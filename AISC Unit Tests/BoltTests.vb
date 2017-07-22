Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports AISC

<TestClass()> Public Class BoltTests
	Private WithEvents BoltEvents As Bolt
	''' <summary>
	''' Tests the BoltDiameter property.
	''' </summary>
	<TestMethod()>
	<ExpectedException(GetType(ArgumentOutOfRangeException))>
	Public Sub BoltDiameter_Invalid_Test()
		Dim MyBolt As New Bolt() With {.Diameter = 1.32}
	End Sub
	<TestMethod()>
	<ExpectedException(GetType(ArgumentException))>
	Public Sub NewBolt_DiameterandString_InvalidASTMInput_Test()
		Dim MyBolt As New Bolt(Diameter:=1.0, ASTM:="A231")
	End Sub
	''' <summary>
	''' Tests the object constructor that accepts a diameter and string.
	''' </summary>
	<TestMethod()>
	<ExpectedException(GetType(ArgumentOutOfRangeException))>
	Public Sub NewBolt_DiameterandString_InvalidDiameterInput_Test()
		Dim MyBolt As New Bolt(Diameter:=1.1, ASTM:="A325")
	End Sub
	<TestMethod()>
	Public Sub BoltEvents_BoltDiameterChanged(NewDiameter As Double, OldDiameter As Double) Handles BoltEvents.BoltDiameterChanged
		Assert.Fail()
	End Sub
	<TestMethod()>
	Public Sub BoltArea_Test()
		Dim MyBolt As New Bolt With {.Diameter = 1.0}
		Dim Expected As Double = 3.14159 * 1 ^ 2 / 4
		Assert.AreEqual(expected:=Expected, actual:=MyBolt.Area, delta:=0)
	End Sub
End Class