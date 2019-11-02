Imports System

Module Program
    Class computer
        Private code As String
        Private height As Double
        Private width As Double
        Private make As String
        Private Processor As String
        Private ram, size As Integer
        Private weight As Single

        Public Sub New(c As String, h As Double, w As Double, m As String, proc As String, rm As String, sze As String, weightt As Single)
            code = c
            height = h
            width = w
            make = m
            Processor = proc
            ram = rm
            size = sze
            weight = weightt
        End Sub

        Public Sub setcode(input As String)
            code = input
        End Sub
        Public Function getcode() As String
            Return code
        End Function

        Public Sub setheight(input As Double)
            height = input
        End Sub
        Public Function getheight() As Double
            Return height
        End Function

        Public Sub setweight(input As Single)
            code = input
        End Sub
        Public Function getweight() As Single
            Return weight
        End Function

        Public Sub setwidth(input As Double)
            width = input
        End Sub
        Public Function getwidth() As Double
            Return width
        End Function

        Public Sub setmake(input As String)
            make = input
        End Sub
        Public Function getmake() As String
            Return make
        End Function

        Public Sub setprocessor(input As String)
            Processor = input
        End Sub
        Public Function getprocessor() As String
            Return Processor
        End Function

        Public Sub setsize(input As Integer)
            While input < 0 And input > 5000
                Console.WriteLine("invalid entry. Please enter correct storage size.")
                input = Console.ReadLine()
            End While
            size = input
        End Sub
        Public Function getsize() As Integer
            Return size
        End Function

        Public Function getram() As Integer
            Return ram
        End Function
        Public Sub setram(input As Integer)
            While input < 0 And input > 12
                Console.WriteLine("invalid entry. Please enter correct ram size.")
                input = Console.ReadLine()
            End While
            ram = input
        End Sub



    End Class
    Class mobilephone
        Inherits computer
        Private camera, threeg, fourg As Boolean
        Private networkname As String

        Public Sub New(c As String, h As Double, w As Double, m As String, proc As String, rm As String, sze As String, weightt As Single, cam As Boolean, three As Boolean, four As Boolean, netname As String)
            MyBase.New(c, h, w, m, proc, rm, sze, weightt)
            camera = cam
            threeg = three
            fourg = four


        End Sub

        Public Sub setcam(input As Boolean)
            camera = input
        End Sub
        Public Function getcam() As Boolean
            Return camera
        End Function
        Public Sub setthree(input As Boolean)
            threeg = input
        End Sub
        Public Function getthree() As Boolean
            Return threeg
        End Function
        Public Sub setfour(input As Boolean)
            fourg = input
        End Sub
        Public Function getfour() As Boolean
            Return fourg
        End Function
        Public Sub setnetwork(input As String)
            networkname = input
        End Sub
        Public Function getnetwork() As String
            Return networkname
        End Function
    End Class
    Class laptop
        Inherits computer
        Private touch, remove, tabletmode As Boolean
        Private ports As Integer

        Public Sub New(c As String, h As Double, w As Double, m As String, proc As String, rm As String, sze As String, weightt As Single, ts As Boolean, rmve As Boolean, tm As Boolean, prts As String)
            MyBase.New(c, h, w, m, proc, rm, sze, weightt)
            touch = ts
            remove = rmve
            tabletmode = tm
            ports = prts

        End Sub

        Public Sub settouch(input As Boolean)
            touch = input
        End Sub
        Public Function getcam() As Boolean
            Return touch
        End Function
        Public Sub setremove(input As Boolean)
            remove = input
        End Sub
        Public Function getremove() As Boolean
            Return remove
        End Function
        Public Sub setmode(input As Boolean)
            tabletmode = input
        End Sub
        Public Function getmode() As Boolean
            Return tabletmode
        End Function
        Public Sub setports(input As String)
            ports = input
        End Sub
        Public Function getnetwork() As String
            Return ports
        End Function
    End Class

    Sub Main()
        Dim M17V As New laptop("c9622", 25.34, 31.25, "lenovo", "i9", 8, 16, 20.4, True, True, True, 6)
        Dim M16X As New laptop("c9623", 22.44, 31.12, "lenovo", "i9", 8, 64, 20.4, True, True, True, 6)
        Dim M15X As New laptop("c9624", 23.54, 31.02, "lenovo", "i7", 8, 128, 20.4, True, True, True, 6)
        Dim M14V As New laptop("c9625", 24.64, 31.52, "lenovo", "i9", 8, 256, 20.4, True, True, True, 5)
        Dim S10p As New mobilephone("c9962", 25.34, 31.25, "samsung", "SD855", 8, 16, 20.4, True, True, False, "MJ@)J")
        Dim iPhone As New mobilephone("c9677", 22.44, 31.12, "apple", "A13X", 8, 64, 20.4, False, False, True, "NNALVL")
        Dim laptop As List(Of laptop) = New List(Of laptop)
        laptop.Add(M17V)
        laptop.Add(M16X)
        laptop.Add(M15X)
        laptop.Add(M14V)
        Dim mobilephone As List(Of mobilephone) = New List(Of mobilephone)
        mobilephone.Add(S10p)
        mobilephone.Add(iPhone)



    End Sub
End Module
