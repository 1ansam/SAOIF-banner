
Do
Dim greyOkX, greyOkY
FindColor 154, 623, 197, 668, "767676", 4, 0.90, greyOkX, greyOkY
If greyOkX > -1 And greyOkY > -1 Then

  For i = 1 To 99

  Dim healthX, healthY
    FindColor 677, 119, 698, 239, "46E17D", 4, 0.90, healthX, healthY
    If healthX > -1 And healthY > -1 Then
    Tap 175, 643
        Delay 1000
        Exit For
    End If
    
  Next

End If
For i = 1 To 99
Dim blueOkX, blueOkY
	FindColor 171, 717, 239, 779, "D3AC57", 4, 0.90, blueOkX, blueOkY
	If blueOkX > -1 And blueOkY > -1 Then
        Tap 202, 748
            Delay 1000
            Exit For
    End If
    Delay 4000        
Next


For i = 1 To 99
Dim healthInX, healthInY
	FindColor 677, 119, 698, 239, "46E17D", 4, 0.90, healthInX, healthInY
	If healthInX > -1 And healthInY > -1 Then 
		Delay 2000
		Tap 66, 1165
		For i = 1 To 999
			Delay 1000
			Tap 382, 1249
			Dim blackOutX, blackOutY
			FindColor 677, 119, 698, 239, "000000", 0, 1.00, blackOutX, blackOutY
			If blackOutX > -1 And blackOutY > -1 Then 
				Exit For
			End If
			Delay 1000
		Next
		Exit For
		
	End If
	Delay 1000
Next
Delay 15000
Loop
