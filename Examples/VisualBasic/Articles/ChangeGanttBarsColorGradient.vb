﻿Imports Aspose.Tasks.Saving

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Articles
    Public Class ChangeGanttBarsColorGradient
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName)

            ' ExStart:ChangeGanttBarsColorGradient
            Dim project As New Project(dataDir & "Project2.mpp")

            Dim options As SaveOptions = New XamlOptions()
            options.UseGradientBrush = False
            project.Save(dataDir & "ChangeGanttBarsColorGradient_Solid_out.xaml", options)

            options.UseGradientBrush = True
            project.Save(dataDir & "ChangeGanttBarsColorGradient_Gradient_out.xaml", options)
            ' ExEnd:ChangeGanttBarsColorGradient
        End Sub
    End Class
End Namespace