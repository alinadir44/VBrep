Imports System

Module Program
    Public Class Toy
        Private name, toyid As String
        Private price As Decimal
        Private minage As Integer

        Public Sub New(ByVal n, ByVal t, ByVal p, ByVal m)
            name = n
            toyid = t
            price = p
            While m < 1 And m > 18
                Console.WriteLine("Invalid age entered. Please enter an age between 1 and 18.")
                m = Console.ReadLine()

            End While

        End Sub
        Public Function GetToyName() As String
            Return name
        End Function
        Public Sub setname(username As String)
            name = username
        End Sub
        Public Function GetToyID() As Integer
            Return toyid
        End Function
        Public Sub setID(userID As String)
            toyid = userID
        End Sub
        Public Function GettoyPrice() As Decimal
            Return price
        End Function
        Public Sub setprice(userprice As String)
            price = userprice
        End Sub
        Public Function GetToyAge() As Integer
            Return minage
        End Function
        Public Sub setage(userage As String)
            minage = userage
        End Sub


    End Class
    Public Class ComputerGame
        Inherits Toy
        Private Category, Console As String
        Public Sub New(ByVal n As String, ByVal t As String, ByVal p As Decimal, ByVal m As Integer, ByVal ca As String, ByVal c As String)
            MyBase.New(n, t, p, m)
            Category = ca
            Console = c
        End Sub

        Public Function getcat() As String
            Return Category
        End Function
        Public Sub setcat(ByVal cA As String)
            Category = cA

        End Sub
        Public Sub setconsole(ByVal cO As String)
            Console = cO
        End Sub
        Public Function getconsole() As String
            Return Console
        End Function


    End Class
    Public Class Vehicle
        Inherits Toy
        Private type As String
        Private height, length As Integer
        Private weight As Single
        Public Sub New(ByVal n As String, ByVal t As String, ByVal p As Decimal, ByVal m As Integer, ByVal ty As String, ByVal h As Single, ByVal l As Single, ByVal w As Double)
            MyBase.New(n, t, p, m)
            type = ty
            height = h
            weight = w
            length = l
        End Sub
        Public Sub settype(stype As String)
            type = stype
        End Sub
        Public Function gettypee() As String
            Return type
        End Function
        Public Sub setheight(h As String)
            height = h
        End Sub
        Public Function getheight() As String
            Return height
        End Function
        Public Sub setlength(l As String)
            length = l
        End Sub
        Public Function getlength() As String
            Return length
        End Function
        Public Sub setweight(w As String)
            weight = w
        End Sub
        Public Function getweight() As String
            Return weight
        End Function

    End Class
    Public Sub applydiscount(num As Decimal, obj As ComputerGame)
        Dim discount As Decimal
        Dim price As Decimal
        Dim newprice As Decimal
        discount = ((100 - num) / 100)
        price = obj.GettoyPrice()
        newprice = price * discount
        obj.setprice(newprice)
    End Sub

    Sub Main()
        Dim ApexLegends As New ComputerGame("Apex Legends", "Videogame4", 69, 16, "Shooter_Multiplayer", "ALL")
        Dim car As New Vehicle("redsportscar", "RSC13", 15, 6, "CAR", 3.3, 12.1, 0.08)
        Console.WriteLine(car.GettoyPrice())
        Call applydiscount(40, ApexLegends)

    End Sub
End Module
