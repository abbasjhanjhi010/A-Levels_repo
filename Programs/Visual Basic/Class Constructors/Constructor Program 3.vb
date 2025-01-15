Imports System

Module Program
    MustInherit Class Member
        Protected MemberName As String
        Protected MemberID As Integer
        Protected SubscriptionPaid As Boolean

        Public Function GetMemberName() As String
            Return MemberName
        End Function
        Public Function GetMemberID() As Integer
            Return MemberID
        End Function
        Public Function GetSubscriptionPaid() As Boolean
            Return SubscriptionPaid
        End Function
    End Class

    Class JuniorMember

        Inherits Member

        Private DateOfBirth As Date

        Public Sub New(ByVal nam As String, ByVal id As Integer, ByVal dob As Date, ByVal pay As Boolean)
            Me.MemberName = nam
            Me.MemberID = id
            Me.DateOfBirth = dob
            Me.SubscriptionPaid = pay
        End Sub
    End Class



    Sub Main(args As String())
        Dim NewMember As JuniorMember = New JuniorMember("Ahmed", 1234567, #12/11/2001#, True)

        Console.WriteLine(NewMember.GetMemberName)
        Console.WriteLine(NewMember.GetMemberID)
        Console.WriteLine(NewMember.GetSubscriptionPaid)
        Console.ReadLine()
    End Sub
End Module
