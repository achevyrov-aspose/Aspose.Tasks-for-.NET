﻿/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from https://www.nuget.org/packages/Aspose.Tasks/, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using https://forum.aspose.com/c/tasks
*/

namespace Aspose.Tasks.Examples.CSharp.WorkingWithCurrencies
{
    using Aspose.Tasks.Saving;

    internal class SetCurrencySymbol
    {
        public static void Run()
        {
            //ExStart:SetCurrencySymbol
            //ExFor: Prj.CurrencySymbol
            //ExSummary: Shows how to set the project currency symbol.
            // Create new project and set currency symbol
            var project = new Project();
            project.Set(Prj.CurrencySymbol, "$$");
            //ExEnd:SetCurrencySymbol
        }
    }
}
