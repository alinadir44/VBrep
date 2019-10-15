Imports System

Module Program
    Class Employee
        Private employeename As String
        Private employeeID As String
        Private amountpaidthismonth As Decimal
        Public Sub New(ename As String, ID As String, paid As Decimal)
            employeename = ename
            employeeID = ID
            amountpaidthismonth = paid
        End Sub
        Public Sub setEmployeeName(name)

            employeename = name

        End Sub
        Public Sub SetEmployeeID(input)
            employeeID = input()
        End Sub
        Public Overridable Sub CalculatePay()

        End Sub
    End Class

    Class HourlyPaidEmployee
        Inherits Employee
        Private hourlyrate As Double
        Private hoursworked As Integer
        Public Sub New(ename As String, ID As String, paid As Decimal, hourlyratee As Double, hoursworkedd As Integer)
            MyBase.New(ename, ID, paid)
            hourlyrate = hourlyratee
            hoursworked = hoursworkedd
        End Sub
        Public Function calculateHourlypay() As Decimal
            Dim tpay As Decimal
            tpay = hourlyrate * hoursworked
            Return tpay
        End Function
        Public Sub getpay()
            Call calculateHourlypay()
        End Sub

        Public Sub sethourlyrate(input)
            hourlyrate = input

        End Sub
        Public Function gethourlyrate() As Decimal
            Return hourlyrate
        End Function

    End Class '
    Class SalariedEmployee
        Inherits Employee
        Private annualsalary As Integer
        Public Sub New(ename As String, ID As String, paid As Decimal, annualsal As Integer)
            MyBase.New(ename, ID, paid)
            annualsalary = annualsal
        End Sub
        Public Overrides Sub CalculatePay()
            Dim monthlysal As Decimal
            monthlysal = annualsalary / 12
            Console.WriteLine("Monthly salary is " & monthlysal)
        End Sub
        Public Sub setannualpay(input As Integer)
            annualsalary = input
        End Sub

    End Class
    Sub Main()

    End Sub
End Module
