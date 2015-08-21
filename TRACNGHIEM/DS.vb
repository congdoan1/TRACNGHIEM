Partial Class DS


    Partial Class MonhocDataTable

        Private Sub MonhocDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.MAMHColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
