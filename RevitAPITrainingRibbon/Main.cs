﻿using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITrainingRibbon
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            string tabName = "Revit API training";
            application.CreateRibbonTab(tabName);
            string utilsFolderPath = @"C:\APPLICATIONS\RevitAPITraining\";

            var panel = application.CreateRibbonPanel(tabName, "Элементы");

            var button = new PushButtonData("Элементы", "Идентификатор элементов", Path.Combine(utilsFolderPath, "RAPITUI.dll"), "RAPITUI.Main");

            panel.AddItem(button);

            return Result.Succeeded;
        }
    }
}
