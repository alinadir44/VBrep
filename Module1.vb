Module Module1
     Structure Memrec
        <VBFixedString(25)> Dim Name As String
        Dim MemID As Integer
    End Structure



    Structure newmemrec
        <VBFixedString(25)> Dim Name As String
        Dim MemID As Integer
        Dim telenum As Integer
        Dim startdate As Date

    End Structure

    Dim s1 As Memrec


    Sub recadder()
        Dim ubound As Integer
        Dim recno As Integer
        Console.WriteLine("How many records do you want to create?")
        ubound = Console.ReadLine()

        FileOpen(1, "E:\memberdata", OpenMode.Random, OpenAccess.ReadWrite, , Len(s1))

        For x = 1 To ubound
            Console.WriteLine("Enter name of member")
            s1.Name = Console.ReadLine()
            Console.WriteLine("Enter ID of member")
            s1.MemID = Console.ReadLine()

            recno = recno + 1

            FilePut(1, s1, recno)

        Next
        FileClose(1)
    End Sub

    Sub outputrec()


        FileOpen(1, "E:\memberdata", OpenMode.Random, OpenAccess.ReadWrite, , Len(s1))
        For x = 1 To (LOF(1) / Len(s1))
            FileGet(1, s1, x)
            Console.WriteLine("Member name is:" & s1.Name)
            Console.WriteLine("Member ID is:" & s1.MemID)

        Next
        FileClose(1)
        Console.ReadKey()
    End Sub
    Sub searchrec()
        Dim recno As Integer
        Dim searchs As String
        Dim flagx As Boolean

        Console.WriteLine("enter name of member to be searched")
        searchs = Console.ReadLine()

        FileOpen(1, "E:\memberdata", OpenMode.Random, OpenAccess.ReadWrite, , Len(s1))
        recno = (LOF(1) / Len(s1))
        For x = 1 To recno
            FileGet(1, s1, x)
            If s1.Name = searchs Or s1.Name = LCase(searchs) Then
                flagx = True
            Else
                flagx = False
            End If

        Next
        FileClose(1)

        If flagx = True Then
            Console.WriteLine("Member found. Corresponding ID is " & s1.MemID)
        Else
            Console.WriteLine("member not found")
        End If
        Console.ReadKey()
    End Sub
    Sub addnewdata()
        Dim recno As Integer
        Dim response As Char
        Console.WriteLine("do you wish to add data for new members? Enter Y/N")
        response = Console.ReadLine()

        FileOpen(1, "E:\memberdata", OpenMode.Random, OpenAccess.ReadWrite, , Len(s1))

        recno = LOF(1) / Len(s1)

        While response = "Y"
            recno = recno + 1

            Console.WriteLine("enter name of new member")
            s1.Name = Console.ReadLine()

            Console.WriteLine("enter their ID")
            s1.MemID = Console.ReadLine()


            FilePut(1, s1, recno)

            Console.WriteLine("any more data to be added? Enter Y or N")
            response = Console.ReadLine()

        End While
        FileClose(1)
    End Sub

    Sub additional()
        '1.5'
        Dim recno As Integer
        Dim newno As Integer
        Dim newname As String
        Dim newID As Integer
        Dim s2 As newmemrec
        FileOpen(1, "E:\memberdata", OpenMode.Random, OpenAccess.ReadWrite, , Len(s1))
        recno = LOF(1) / Len(s1)

        FileOpen(2, "E:\memberdataEDIT", OpenMode.Random, OpenAccess.ReadWrite, , Len(s2))

        For x = 1 To recno

            FileGet(1, s1, x)
            newname = s1.Name
            newID = s1.MemID


            Console.WriteLine("enter telephone number for member no. " & x)
            s2.telenum = Console.ReadLine()
            Console.WriteLine("Enter membership start date")
            s2.startdate = Console.ReadLine()
            s2.Name = newname
            s2.MemID = newID


            newno = (LOF(2) / Len(s2)) + 1
            FilePut(2, s2, newno)

        Next

        FileClose(2)
        FileClose(1)
    End Sub

    Sub Main()
        Dim newno As Integer = 0


        Dim choice As Integer
        Dim choP As Int16
        choP = 0


        choice = 0
        While choice <> 6
            Console.Clear()
            Console.WriteLine("Enter 1 to add records to the random file")
            Console.WriteLine("Enter 2 to output all records from the random file")
            Console.WriteLine("Enter 3 to append the file(Add data for more members)")
            Console.WriteLine("Enter 4 to search records")
            Console.WriteLine("Enter 5 to add additional data for existing members")
            Console.WriteLine("Enter 6 to exit")
            Console.Write("Your choice... ")
            choice = Console.ReadLine

            Select Case choice
                Case 1 : Call recadder()

                Case 2 : Call outputrec()

                Case 3 : Call addnewdata()

                Case 4 : Call searchrec()

                Case 5 : Call additional()

                Case 6

                Case Else
                    Console.WriteLine("wrong choice entered")
                    Console.ReadKey()
            End Select
        End While





    End Sub

End Module
