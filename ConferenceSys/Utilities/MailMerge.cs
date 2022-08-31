using System;
using System.Windows.Forms;
//using Microsoft.Office.Core;
using WORD = Microsoft.Office.Interop.Word;


/// <summary>
/// MailMerge from DataFile To Word
/// </summary>
class MailMerge
{

    public static Boolean PerformMailMerge(string TemplateFile, string Datafile)
    {
        try
        {
            if (Datafile == "") Datafile = @"C:\\DataDoc.doc";
            string sMailmergeInputFile = Datafile;
            WORD.Application wrdApp;
            WORD._Document wrdDoc;

            Object oMissing = System.Reflection.Missing.Value;
            Object oFalse = false;
            Object oName = sMailmergeInputFile;

            WORD.Selection wrdSelection;
            WORD.MailMerge wrdMailMerge;


            wrdApp = new WORD.Application();
            wrdApp.Visible = true;

            //Add A New Document
            Object oWordDocument = TemplateFile;
            wrdDoc = wrdApp.Documents.Add(ref oWordDocument, ref oMissing, ref oMissing, ref oMissing);
            wrdDoc.Select();
            wrdSelection = wrdApp.Selection;
            wrdMailMerge = wrdDoc.MailMerge;

            //Perform Mail Merge

            wrdDoc.MailMerge.OpenDataSource(sMailmergeInputFile, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing
            , ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing
            , ref oMissing, ref oMissing);

            object oTrue = true;

            wrdMailMerge.Execute(ref oTrue);

            wrdMailMerge.Destination = WORD.WdMailMergeDestination.wdSendToNewDocument;

            wrdDoc.Select();

            //Close Template

            wrdDoc.Close(ref oFalse, ref oMissing, ref oMissing);

            //Release Reference

            wrdSelection = null;
            wrdMailMerge = null;
            wrdDoc = null;
            wrdApp = null;
        }

        catch (Exception excpt)
        {
            MessageBox.Show(excpt.Message, "Error", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }



        return true;

    }




}
