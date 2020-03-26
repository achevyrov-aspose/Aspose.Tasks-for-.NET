/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithProjects.WorkingWithProjectProperties
{
    using Aspose.Tasks.Saving;

    internal class SetAttributesForNewTasks
    {
        public static void Run()
        {
            var dataDir = RunExamples.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod());
            
            //ExStart:SetAttributesForNewTasks
            //ExFor: TaskStartDateType
            //ExFor: Project.Set``1(Key{``0,PrjKey},``0)
            //ExFor: Project.Set(Aspose.Tasks.Key{System.DateTime,Aspose.Tasks.PrjKey},System.DateTime)
            //ExFor: Prj.NewTaskStartDate
            //ExSummary: Shows how to set attributes for new tasks.
            // Create a project instance Set new task property and Save the project as XML project file
            var project = new Project();
            project.Set(Prj.NewTaskStartDate, TaskStartDateType.CurrentDate);
            project.Save(dataDir + "SetAttributesForNewTasks_out.xml", SaveFileFormat.XML);
            //ExEnd:SetAttributesForNewTasks
        }
    }
}