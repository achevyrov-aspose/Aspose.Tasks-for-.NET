﻿namespace Aspose.Tasks.Examples.CSharp.SavingOptions
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Security.Cryptography.X509Certificates;
    using NUnit.Framework;
    using Saving;
    using Visualization;

    [TestFixture]
    public class ExPdfSaveOptions : ApiExampleBase
    {
        [Test]
        public void SaveToMultiplePdfFiles()
        {
            // ExStart
            // ExFor: PdfSaveOptions
            // ExFor: PdfSaveOptions.#ctor
            // ExFor: PdfSaveOptions.SaveToSeparateFiles
            // ExFor: PdfSaveOptions.Pages
            // ExFor: SaveOptions.PageCount
            // ExSummary: Shows how to save selected pages of a project into PDF file. 
            var project = new Project(DataDir + "Software Development Plan.mpp");
            var options = new PdfSaveOptions();
            options.SaveToSeparateFiles = true;
            options.Pages = new List<int>();

            // lets check the number of pages can be exported
            Console.WriteLine("Page Count: " + options.PageCount);

            options.Pages.Add(1);
            options.Pages.Add(4);
            project.Save(OutDir + "SaveToMultiplePDFFiles_out.pdf", options);

            // ExEnd
        }

        [Test]
        public void AddDefaultFontDuringSavingAsPDF()
        {
            // ExStart: AddDefaultFontDuringSavingAsPDF
            // ExFor: PdfSaveOptions.DefaultFontName
            // ExFor: PdfSaveOptions.UseProjectDefaultFont
            // ExSummary: Shows how to set custom font that will be used for print of output pdf.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

            var options = new PdfSaveOptions
                              {
                                  PresentationFormat = PresentationFormat.GanttChart, FitContent = true, UseProjectDefaultFont = false, DefaultFontName = "Segoe UI Black"
                              };
            project.Save(OutDir + "CreateProject2_out.pdf", options);

            // ExEnd:AddDefaultFontDuringSavingAsPDF
        }

        [Test]
        public void WorkWithNonWorkingTimeColor()
        {
            // ExStart
            // ExFor: SaveOptions.NonWorkingTimeColor
            // ExSummary: Shows how to set custom color for non working time.
            var project = new Project(DataDir + "ReadCurrencyProperties.mpp");
            SaveOptions options = new PdfSaveOptions { NonWorkingTimeColor = Color.LightGray };
            project.Save(OutDir + "ReadCurrencyProperties_out.pdf", options);

            // ExEnd
        }

        [Test]
        public void ReducingGapBetweenTasksListAndFooter()
        {
            // ExStart
            // ExFor: PdfSaveOptions.ReduceFooterGap
            // ExSummary: Shows how to set a value indicating whether a gap between last task and the footer must be reduced in PDF output files.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

            var options = new PdfSaveOptions { ReduceFooterGap = true, PageSize = PageSize.A0, Timescale = Timescale.Days };

            project.Save(OutDir + "ReducingGapBetweenTasksListAndFooter_out.pdf", options);

            // ExEnd
        }

        [Test]
        public void WorkWithPdfCompliance()
        {
            // ExStart
            // ExFor: PdfSaveOptions.Compliance
            // ExFor: PdfCompliance
            // ExSummary: Shows how to set a desired compliance level for generated PDF document.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

            var options = new PdfSaveOptions();

            // set a desired conformance level for generated PDF document
            // default is <see cref="PdfCompliance.Pdf15"/> type
            options.Compliance = PdfCompliance.PdfA1b;

            // tune additional properties
            // set the <see cref="P:Aspose.Tasks.Saving.SaveOptions.PresentationFormat" /> in which the document will be saved.
            options.PresentationFormat = PresentationFormat.GanttChart;

            project.Save(OutDir + "WorkWithPdfCompliance_out.pdf", options);

            // ExEnd
        }

        [Test]
        public void WorkWithDigitalSignatureDetails()
        {
            // ExStart
            // ExFor: PdfSaveOptions.DigitalSignatureDetails
            // ExSummary: Shows how to set a digital signature details. If not set, then no signing will be performed.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

            var options = new PdfSaveOptions();
            var certificate = new X509Certificate2();

            // set a digital signature details. If not set, then no signing will be performed.
            options.DigitalSignatureDetails = new PdfDigitalSignatureDetails(
                certificate,
                "reason",
                "location",
                new DateTime(2019, 1, 1),
                PdfDigitalSignatureHashAlgorithm.Sha1);

            // tune additional properties
            // set the <see cref="P:Aspose.Tasks.Saving.SaveOptions.PresentationFormat" /> in which the document will be saved.
            options.PresentationFormat = PresentationFormat.GanttChart;

            // set a desired conformance level for generated PDF document
            options.Compliance = PdfCompliance.PdfA1b;

            project.Save(OutDir + "WorkWithDigitalSignatureDetails_out.pdf", options);

            // ExEnd
        }

        [Test]
        public void WorkWithEncryptionDetails()
        {
            // ExStart
            // ExFor: PdfSaveOptions.EncryptionDetails
            // ExSummary: Shows how to set a encryption details of PDF document. If not set, then no encryption will be performed.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

            var encryptionDetails = new PdfEncryptionDetails("userPassword", "ownerPassword", PdfEncryptionAlgorithm.RC4_128);

            var options = new PdfSaveOptions();

            // set a encryption details of PDF document
            options.EncryptionDetails = encryptionDetails;

            // tune additional properties
            // set the <see cref="P:Aspose.Tasks.Saving.SaveOptions.PresentationFormat" /> in which the document will be saved.
            options.PresentationFormat = PresentationFormat.GanttChart;

            // set a desired conformance level for generated PDF document
            options.Compliance = PdfCompliance.PdfA1b;

            project.Save(OutDir + "WorkWithEncryptionDetails_out.pdf", options);

            // ExEnd
        }

        [Test]
        public void WorkWithTextCompression()
        {
            // ExStart
            // ExFor: PdfSaveOptions.TextCompression
            // ExFor: PdfTextCompression
            // ExSummary: Shows how to set a compression type to be used for all content streams except images.
            var project = new Project(DataDir + "EstimatedMilestoneTasks.mpp");

            var options = new PdfSaveOptions();

            // set compression type to be used for all content streams except images
            options.TextCompression = PdfTextCompression.Flate;

            // tune additional properties
            // set the <see cref="P:Aspose.Tasks.Saving.SaveOptions.PresentationFormat" /> in which the document will be saved.
            options.PresentationFormat = PresentationFormat.GanttChart;

            // set a desired conformance level for generated PDF document
            options.Compliance = PdfCompliance.PdfA1b;

            project.Save(OutDir + "WorkWithTextCompression_out.pdf", options);

            // ExEnd
        }
    }
}