Public Class Palindrome

    Private text As String
    Public Property TextValue() As String
        Get
            Return text
        End Get
        Set(ByVal value As String)
            text = value
        End Set
    End Property

    Private index As Integer
    Public Property StartIndex() As Integer
        Get
            Return index
        End Get
        Set(ByVal value As Integer)
            index = value
        End Set
    End Property

    Private length As Integer
    Public Property LengthValue() As Integer
        Get
            Return Length
        End Get
        Set(ByVal value As Integer)
            length = value
        End Set
    End Property
End Class
Public Class PalindromesGenerator

    Public Shared Function isPalindrome(text As String) As Boolean
        isPalindrome = True

        Dim originalLength = text.Length
        Dim originalLengthDiv = originalLength / 2

        For index = 1 To originalLengthDiv
            Dim leftSideOppositeLetter = text(index)
            Dim rightSideOppositeLetter = text(originalLength - (index + 1))
            If leftSideOppositeLetter <> rightSideOppositeLetter Then
                isPalindrome = False
            End If
        Next

    End Function


    Public Shared Sub processString(str As String, ByRef listOfPalindromes As List(Of Palindrome))
        listOfPalindromes = New List(Of Palindrome)
        For i = 0 To str.Length - 1
            Dim letter = str(i)
            For j = i + 1 To str.Length - 1
                Dim potentialSimilarLetter = str(j)
                If potentialSimilarLetter = letter Then
                    Dim sliceLength = j - i + 1
                    If (sliceLength) > 2 And isEven(sliceLength) Then
                        If isPalindrome(str.Substring(i, sliceLength)) Then
                            Dim palindrome = New Palindrome()
                            palindrome.TextValue = str.Substring(i, sliceLength)
                            palindrome.LengthValue = sliceLength
                            palindrome.StartIndex = i
                            listOfPalindromes.Add(palindrome)
                            i = i + sliceLength - 1
                        End If
                    End If
                End If
            Next

        Next

    End Sub

    Private Shared Function isEven(value As Integer) As Boolean

        If value Mod 2 = 0 Then
            isEven = True
        Else
            isEven = False
        End If
    End Function

End Class
