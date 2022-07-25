Dim i=0
//iphone 6;6s;7;8;se;se2;se3
//Dim pixel = 1
//iphone 7p 8p
Dim pixel = 1.44



Do
	Dim greyOkX, greyOkY
FindColor 154*pixel, 623*pixel, 197*pixel, 668*pixel, "767676", 4, 0.90, greyOkX, greyOkY
//如果没有找到，intX和intY的值都会被置为-1
If greyOkX > -1 And greyOkY > -1 Then
For i = 1 To 99
Dim healthX, healthY
    FindColor 677*pixel, 119*pixel, 698*pixel, 239*pixel, "46E17D", 4, 0.90, healthX, healthY
    If healthX > -1 And healthY > -1 Then
    Tap 175*pixel, 643*pixel
        Delay 1000
        Exit For
    End If


Next
End If
For i = 1 To 99
Dim blueOkX, blueOkY
	FindColor 171*pixel, 717*pixel, 239*pixel, 779*pixel, "D3AC57", 4, 0.90, blueOkX, blueOkY
	If blueOkX > -1 And blueOkY > -1 Then
        Tap 202*pixel, 748*pixel
            Delay 1000
            Exit For
    End If
    Delay 4000        
Next


For i = 1 To 99
Dim healthInX, healthInY
	FindColor 677*pixel, 119*pixel, 698*pixel, 239*pixel, "46E17D", 4, 0.90, healthInX, healthInY
	If healthInX > -1 And healthInY > -1 Then 
		Delay 2000
		Tap 66*pixel, 1165*pixel
		For i = 1 To 999
			Delay 1000
			Tap 382*pixel, 1249*pixel
			Dim blackOutX, blackOutY
			FindColor 677*pixel, 119*pixel, 698*pixel, 239*pixel, "000000", 0, 1.00, blackOutX, blackOutY
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
