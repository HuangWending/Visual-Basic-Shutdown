Imports System.Diagnostics

Module Module1
    Sub Main()
        Shutdown()
    End Sub

    Sub Shutdown()
        Dim psi As New ProcessStartInfo("shutdown", "/s /t 0")
        psi.CreateNoWindow = True
        psi.UseShellExecute = False
        Process.Start(psi)
    End Sub
End Module
