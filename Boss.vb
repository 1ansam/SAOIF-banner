Dim width,height

width = GetScreenX()

height = GetScreenY()

Dim scaleX, scaleY

scaleX = width / 1334

scaleY = height / 750

Tap 50, 643

Delay 1000

Tap 204,810

Delay 4000


Do
For i = 1 To 1000
	TracePrint i
    Dim health1X,health1Y
	FindMultiColor 679,122,696,391,"46DE7C","",0,0.9,health1X,health1Y
	If health1X > -1 And health1Y > -1 Then
		Exit For
	End If
	Delay 100
	
Next

Delay 200

Tap 60, 1168

Delay 500

Tap 60, 1168

Delay 200


For i = 1 To 1000
    Tap 386, 1246
    Delay 1000
	Dim OK1X,OK1Y
	FindMultiColor 679,122,696,391,"46DE7C","",0,0.9,OK1X,OK1Y
	If OK1X <= -1 And OK1Y <= -1 Then
		Exit For
	End If
    
Next

Delay 3000



For i = 1 To 1000
	TracePrint i
    Dim health2X,health2Y
	FindMultiColor 679,122,696,391,"46DE7C","",0,0.9,health2X,health2Y
	If health2X > -1 And health2Y > -1 Then
		Exit For
	End If
	Delay 100
	
Next

Delay 4000

For i = 1 To 1000
	Dim OK2X,OK2Y
	FindColor 167,638,182,652,"767676",0,0.9,OK2X,OK2Y
	If OK2X > -1 And OK2Y > -1 Then
		Exit For
	End If
	Delay 100
    
Next

Tap 175, 645

Delay 1000

Tap 203, 807

Delay 4000
Loop












