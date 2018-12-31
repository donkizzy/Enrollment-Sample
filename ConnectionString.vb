Imports Microsoft.VisualBasic

Public Class ConnectionString

    Public Shared Function Live_ConnectionString() As String
        Dim dConnectionstring As String = "Data Source=HP-PC/PC;Initial Catalog=FINGEPRINTDB;Persist Security Info=True;User ID=sa;pwd=pa$$word123;Pooling=True;Min Pool Size=5; Max Pool Size = 500;timeout=600000;MultipleActiveResultSets=True"
        Return dConnectionstring
    End Function

End Class