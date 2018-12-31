Public Class BLL

    Public Shared Sub WriteLog(ByVal message As String)
        'Try
        'System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath & 
        'Dim path As String = context.Server.MapPath("~/Logs/errorlog.txt")
        Dim path = "C:\Users\HP\Downloads\Neurotec_Biometric_10_0_SDK_Trial_2018-09-14\Neurotec_Biometric_10_0_SDK_Trial\Samples\Biometrics\VB\EnrollmentSampleVB\ErrorLog\Error_log.txt"
        Dim writer As New System.IO.StreamWriter(path, True)
        writer.WriteLine(message + "Time error occured:")
        writer.Close()
        'Catch ex As Exception
        ' End Try
    End Sub
End Class