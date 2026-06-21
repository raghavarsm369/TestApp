Imports System.Net

Public Class UpdateManager

    Public Shared Function IsUpdateAvailable() As Boolean

        Try

            'Temporary Test
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function

End Class