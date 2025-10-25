using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;

namespace Task1_1
{
    [Transaction(TransactionMode.Manual)]
    public class TestSample : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            application.CreateRibbonTab("ПИК-Привет");
            var panel = application.CreateRibbonPanel("ПИК-Привет", "Общее");
            var button = new PushButtonData(
                "Hello",
                "Привет",
                "C:\\Users\\filippov.av\\Documents\\Temp c#\\API_Lab3\\StructSample.dll",
                "Revit.SDK.Samples.StructSample.CS.Command"
                );
            panel.AddItem(button);
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }        
    }
}
