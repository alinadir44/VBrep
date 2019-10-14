Imports System

Module Program
    Public Class Taxi
        Private RegNo As String
        Private BaseRate As Decimal

        Public Sub New(rno As String, br As Decimal)
            RegNo = rno
            BaseRate = br
        End Sub
        Public Sub printdetails()
            Console.WriteLine("Registration Number:" & RegNo & " Base Fee:" & BaseRate)
        End Sub

        Public Function getbaserate() As Decimal
            Return BaseRate
        End Function

    End Class
    Public Class Car
        Inherits Taxi

        Public Sub New(rno As String, br As Decimal)
            MyBase.New(rno, br)
        End Sub
        Public Function CalculateCarCharge() As Decimal
            Dim tcharge As Decimal
            Dim no As Integer
            Do
                Console.WriteLine("Enter number of passengers")
                no = Console.ReadLine()
            Loop Until no > 0 And no < 5

            tcharge = no * getbaserate()

            Return tcharge
        End Function

        Public Sub printcardetails()
            Dim val As Decimal
            val = CalculateCarCharge()
            MyBase.printdetails()
            Console.WriteLine("")
            Console.WriteLine("Your fare is: " & val)

        End Sub

    End Class
    Public Class minibus
        Inherits Taxi
        Private extracharge As Double
        Private maxallowed As Integer
        Public Sub New(rno As String, br As Decimal, ex As Double, ma As Integer)
            MyBase.New(rno, br)
            extracharge = ex
            maxallowed = ma
        End Sub
        Public Function getbuscharge(num As Integer) As Decimal
            Dim totalfare As Decimal
            Dim basecharge As Decimal
            basecharge = MyBase.getbaserate()
            While num < 0 And num > maxallowed
                Console.WriteLine("Number of passengers exceeds maximum limit. Please enter a number between 1 and " & maxallowed)
                num = Console.ReadLine()
            End While
            totalfare = basecharge + (num * extracharge)
            Return totalfare
        End Function

    End Class

    Sub Main()
        Dim PremiumGo As New Car("DVG498", 15)

        PremiumGo.printcardetails()


    End Sub
End Module
