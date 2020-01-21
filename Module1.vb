Module Module1

    Structure node
        Dim lp As Integer
        Dim databt As String
        Dim rp As Integer

    End Structure

    Dim BT(9) As node

    Sub initialiseBT()
        Dim i As Integer

        For i = 0 To 9
            BT(i).lp = -1
            BT(i).databt = ""
            BT(i).rp = -1
        Next

    End Sub

    Sub insertnode()
        Dim currp, nextp As Integer
        Dim mydata As String
        Dim turnright As Boolean
        Const root = 0

        Console.WriteLine("Enter value to be added")
        mydata = Console.ReadLine()

        nextp = availablepos()

        BT(nextp).databt = mydata

        If nextp = root Then
            Exit Sub
        Else
            currp = root
            While currp <> -1
                If BT(currp).databt > mydata Then
                    currp = BT(currp).lp
                    turnright = False
                Else
                    currp = BT(currp).rp
                    turnright = True

                End If
            End While

            If turnright = True Then
                BT(currp).rp = nextp
            Else
                BT(currp).lp = nextp
            End If

        End If
    End Sub

    Function availablepos() As Integer
        Dim i As Integer
        Dim isfound As Boolean = False

        For i = 0 To 9

            If BT(i).databt = "" Then

                isfound = True
                Return i

            End If

        Next

        If Not isfound Then

            Return -1

        End If
    End Function

   
       




    Sub Main()
        Call initialiseBT()
        Dim index As Integer
        For index = 1 To 10
            Call insertnode()
        Next

    End Sub

End Module
