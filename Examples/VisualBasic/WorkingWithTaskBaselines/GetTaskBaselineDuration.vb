﻿
Namespace WorkingWithTaskBaselines
    Public Class GetTaskBaselineDuration
        Public Shared Sub Run()
            ' ExStart:GetTaskBaselineDuration
            ' Create project instance
            Dim project As New Project()

            ' Creating TaskBaseline
            Dim task As Task = project.RootTask.Children.Add("Task")
            project.SetBaseline(BaselineType.Baseline)

            ' Display task baseline duration
            Dim baseline As TaskBaseline = task.Baselines.ToList()(0)
            Console.WriteLine("Baseline duration is 1 day: {0}", baseline.Duration.ToString().Equals("1 day"))
            Console.WriteLine("BaselineStart is same as Task Start: {0}", baseline.Start.Equals(task.[Get](Tsk.Start)))
            Console.WriteLine("BaselineFinish is same as Task Finish: {0}", baseline.Finish.Equals(task.[Get](Tsk.Finish)))
            ' ExEnd:GetTaskBaselineDuration
        End Sub
    End Class
End Namespace
