Public Class Exit_UC

  
    Private Sub btnExitNoForce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitNoForce.Click
      
        Me.Parent.Dispose()
    End Sub

    Private Sub btnForceMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForceMenu.Click

        Try
            dsSetup.Tables("LocationOpening").Rows(0)("menuChangeDate") = Format(Me.DateTimePickerMenu.Value, "D")
            sql.cn.Open()
            sql.sqlSelectAppRoleCommandPhoenix.ExecuteNonQuery()
            sql.SqlLocationOpening.Update(dsSetup, "LocationOpening")
            sql.cn.Close()
        Catch ex As Exception
            CloseConnection()
            MsgBox(ex.Message)
        End Try
        Me.Parent.Dispose()

    End Sub

    Private Sub btnExitCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExitCancel.Click
        Me.Dispose()
    End Sub
End Class
