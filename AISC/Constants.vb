Public Enum BoltHoleType As Integer
	STD = 1
	OVS = 2
	SSLT = 3
	SSLP = 4
	LSLT = 5
	LSLP = 6
End Enum
Public Enum DesignMethod As Integer
	ASD = 1
	LRFD = 2
End Enum
Public Module Constants
	'ASD Safety Factors
	Const OmegaTensionYield As Single = 1.67
	Const OmegaTensionRupture As Single = 2.0
	'LRFD Resistance Factors
	Const PhiTensionYield As Single = 0.9
	Const PhiTensionRupture As Single = 0.75
End Module