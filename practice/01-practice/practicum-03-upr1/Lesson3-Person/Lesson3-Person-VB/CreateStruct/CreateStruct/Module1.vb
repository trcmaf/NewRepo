Module Module1

    Sub Main()
        Dim p As Person = New Person("Tony", "Allen", 32, Person.Genders.Male)
        Console.WriteLine(p)

        Dim m As Manager = New Manager("Tony", "Allen", 32, Manager.Genders.Male, "555-555-1212", "123b")
        Console.WriteLine(m)
    End Sub

    Class Person
        Public firstName As String
        Public lastName As String
        Public age As Integer
        Public gender As Genders

        Public Sub New(ByVal _firstName As String, ByVal _lastName As String, ByVal _age As Integer, ByVal _gender As Genders)
            firstName = _firstName
            lastName = _lastName
            age = _age
            gender = _gender
        End Sub

        Public Overloads Overrides Function ToString() As String
            Return firstName + " " + lastName + " (" + gender.ToString() + "), age " + age.ToString
        End Function

        Enum Genders
            Male
            Female
        End Enum

    End Class

    Class Manager
        Inherits Person
        Private phoneNumber As String
        Private officeLocation As String

        Public Sub New(ByVal _firstName As String, ByVal _lastName As String, ByVal _age As Integer, ByVal _gender As Genders, ByVal _phoneNumber As String, ByVal _officeLocation As String)
            MyBase.New(_firstName, _lastName, _age, _gender)
            phoneNumber = _phoneNumber
            officeLocation = _officeLocation
        End Sub

        Public Overloads Overrides Function ToString() As String
            Return MyBase.ToString + ", " + phoneNumber + ", " + officeLocation
        End Function
    End Class
End Module
