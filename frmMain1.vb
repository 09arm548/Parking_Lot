Imports System.IO.TextWriter
Public Class frmParkingLot

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'make an array
        'add to database
        Dim strArray = New ParkingLot
        Dim strCar = New Car
        Dim intArray(50) As Integer
        Dim intDatabase As System.IO.StreamWriter = New System.IO.StreamWriter("C:\Users\Andrea\Documents\Visual Studio 2010\Projects\Parking Lot\Parking Lot\data.txt")
        Dim input As String


        strCar.Make = "Ford"
        strCar.Model = "Focus"
        strCar.Year = 2000
        strCar.License = "ABC123"
        strCar.Color = "Blue"

        intArray(0) = strCar.Model
        'intDatabase.WriteLine("jdfkj")







    End Sub
    Public Function Split(ByVal ParamArray separator As Char()) As String()

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'read flat file
        'split string into textboxes
        Dim file As System.IO.StreamReader
        file = My.Computer.FileSystem.OpenTextFileReader("c:\Users\Andrea\Documents\Visual Studio 2010\Projects\Parking Lot\Parking Lot\data1.txt")
        TextBox1.Text = file.ReadLine.Split(",").ToString
        TextBox2.Text = file.ReadLine
        TextBox3.Text = 
    End Sub
End Class
