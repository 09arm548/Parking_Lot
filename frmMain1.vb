Imports System.IO.TextWriter
Public Class frmParkingLot

    Dim i As Integer
    Dim counter As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadDatabase.Click
        'loads database
        Dim file As System.IO.StreamWriter
        Dim i As Integer
        Dim array(5) As String
        Dim strArray = New ParkingLot
        Dim strCar = New Car

        strCar.Make = "Ford"
        strCar.Model = "Focus"
        strCar.Year = 2000
        strCar.License = "ABC123"
        strCar.Color = "Blue"

        file = My.Computer.FileSystem.OpenTextFileWriter("c:\Users\Andrea\Documents\Visual Studio 2010\Projects\Parking Lot\Parking Lot\data1.txt", True)

        For i = 0 To 4
            array(i) = "2000,Ford,Focus, Blue, ABC123"
            file.WriteLine(array(i))
        Next

        file.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim aryTextFile() As String
        Dim srFile As System.IO.StreamReader

        srFile = My.Computer.FileSystem.OpenTextFileReader("c:\Users\Andrea\Documents\Visual Studio 2010\Projects\Parking Lot\Parking Lot\data1.txt")

        aryTextFile = srFile.ReadLine.Split(",")

        TextBox1.Text = aryTextFile(i)
        i += 1
        TextBox2.Text = aryTextFile(i)
        i += 1
        TextBox3.Text = aryTextFile(i)
        i += 1
        TextBox4.Text = aryTextFile(i)
        i += 1
        TextBox5.Text = aryTextFile(i)

        srFile.Close()
        counter = counter + 1
        txtCount.Text = CInt(counter)
    End Sub

    Sub nextCar()

        Dim i As Integer
        Dim aryTextFile() As String
        Dim srFile As System.IO.StreamReader

        If counter = 20 Then
            counter = 0
        End If
        srFile = My.Computer.FileSystem.OpenTextFileReader("c:\Users\Andrea\Documents\Visual Studio 2010\Projects\Parking Lot\Parking Lot\data1.txt")

        For a As Integer = 1 To counter
            srFile.ReadLine()
        Next

        aryTextFile = srFile.ReadLine.Split(",")
        TextBox1.Text = aryTextFile(i)
        i += 1
        TextBox2.Text = aryTextFile(i)
        i += 1
        TextBox3.Text = aryTextFile(i)
        i += 1
        TextBox4.Text = aryTextFile(i)
        i += 1
        TextBox5.Text = aryTextFile(i)

        counter += 1
        i = 0
        txtCount.Text = CInt(counter)
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        nextCar()

    End Sub

    Private Sub btnPreviousCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousCar.Click
        Dim i As Integer
        Dim aryTextFile() As String
        Dim srFile As System.IO.StreamReader

        'If counter = 20 Then
        '    counter = 0
        'End If
        srFile = My.Computer.FileSystem.OpenTextFileReader("c:\Users\Andrea\Documents\Visual Studio 2010\Projects\Parking Lot\Parking Lot\data1.txt")
        counter = counter - 1
        For a As Integer = 2 To counter
            srFile.ReadLine()
        Next

        aryTextFile = srFile.ReadLine.Split(",")
        TextBox1.Text = aryTextFile(i)
        i += 1
        TextBox2.Text = aryTextFile(i)
        i += 1
        TextBox3.Text = aryTextFile(i)
        i += 1
        TextBox4.Text = aryTextFile(i)
        i += 1
        TextBox5.Text = aryTextFile(i)

        i = 0
        txtCount.Text = CInt(counter)



    End Sub
End Class
