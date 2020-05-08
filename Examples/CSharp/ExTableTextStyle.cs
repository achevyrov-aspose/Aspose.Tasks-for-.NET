﻿namespace Aspose.Tasks.Examples.CSharp
{
    using System.Drawing;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExTableTextStyle : ApiExampleBase
    {
        [Test]
        public void WorkWithTableTextStyle()
        {
            // ExStart:WorkWithTableTextStyle
            // ExFor: TableTextStyle
            // ExFor: TableTextStyle.#ctor(Int32)
            // ExFor: TableTextStyle.Field
            // ExFor: TableTextStyle.ItemType
            // ExFor: TableTextStyle.RowUid
            // ExFor: Field
            // ExSummary: Shows how to customize table text styles which are used to style different text items in a project.
            var project = new Project(DataDir + "Project2.mpp");
            project.Set(Prj.NewTasksAreManual, false);

            var view = (GanttChartView)project.Views.ToList()[1];

            // set first task name text style
            var style1 = new TableTextStyle(1);
            // set a field the style is to be applied to.
            style1.Field = Field.TaskName;
            // set <see cref="P:Aspose.Tasks.Visualization.TextStyle.FontStyle" /> of the text style font.
            style1.FontStyle = FontStyle.Bold | FontStyle.Italic;
            // set <see cref="P:Aspose.Tasks.Visualization.TextStyle.FontFamily" /> of the text style.
            style1.FontFamily = new FontFamily("Impact");
            // set size in points of the text style font.
            style1.SizeInPoints = 12;

            // set second task duration text style
            var style2 = new TableTextStyle(2);
            style2.Field = Field.TaskDurationText;
            style2.FontStyle = FontStyle.Underline;
            style2.FontFamily = new FontFamily("Impact");
            style2.SizeInPoints = 16;
            
            view.TableTextStyles.Add(style1);
            view.TableTextStyles.Add(style2);

            var options = new MPPSaveOptions
            {
                // set a flag indicating that view data must be written
                WriteViewData = true
            };
            project.Save(OutDir + "WorkWithTableTextStyle_out.pdf",  options);

            // ExEnd:WorkWithTableTextStyle
        }
    }
}