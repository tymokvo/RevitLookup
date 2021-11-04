﻿using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using RevitLookup.Forms;
using RevitLookup.Snoop;

namespace RevitLookup.Commands
{
    [Transaction(TransactionMode.Manual)]
    public class SnoopPickEdgeCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData cmdData, ref string msg, ElementSet elems)
        {
            var form = new Objects();
            form.SnoopAndShow(Selector.SnoopPickEdge);
            return Result.Succeeded;
        }
    }
}