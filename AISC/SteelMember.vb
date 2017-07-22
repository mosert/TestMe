Public Class SteelMember
	Private pASTM As String
	Private pShapeDesignation As String
	Public Property ASTM As String
		Get
			Return pASTM
		End Get
		Set(ByVal value As String)
			If value <> pASTM Then
				RaiseEvent ASTMChanged()
			End If
			pASTM = value
			'Get and set values of yield and tensile stress here.
		End Set
	End Property
	Public Property ShapeDesignation As String
		Get
			Return pShapeDesignation
		End Get
		Set(ByVal value As String)
			If value <> pShapeDesignation Then
				RaiseEvent ShapeChanged()
			End If
			pShapeDesignation = value
		End Set
	End Property
	Public ReadOnly Property YieldStress As Double
	Public ReadOnly Property TensileStrength As Double
	'Event to notify if shape has been changed. Occurs before new shape designation is assigned.
	Public Event ShapeChanged()
	Public Event ASTMChanged()

End Class
