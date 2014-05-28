Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub computePalindromes(obj As Object, e As EventArgs) Handles getPalindromesBtn.Click
        Dim inputText = palindromTxt.Text
        Dim listOfPalindromes As List(Of Palindrome)
        PalindromesGenerator.processString(inputText, listOfPalindromes)
        If (listOfPalindromes.Count > 0) Then
            palindromesListRpt.DataSource = listOfPalindromes.OrderByDescending(Function(x) x.LengthValue).Take(3)
            palindromesListRpt.DataBind()
            palindromesListRpt.Dispose()
            palindromesListRpt.Visible = True
            lblErrorMsg.Visible = False
        Else
            palindromesListRpt.Visible = False
            lblErrorMsg.Visible = True
        End If

    End Sub

End Class