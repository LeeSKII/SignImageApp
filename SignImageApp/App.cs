using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace SignImageApp
{
    public class App : IExternalApplication
    {
        // get the absolute path of this assembly
        static string ExecutingAssemblyPath = System.Reflection.Assembly
          .GetExecutingAssembly().Location;
        public Result OnStartup(UIControlledApplication application)
        {
            application.CreateRibbonTab("CIE三维设计平台");
            RibbonPanel ribbon = application.CreateRibbonPanel("CIE三维设计平台", "中冶长天三维设计管理平台");
            PushButtonData loginButtonData = new PushButtonData("login", "登录", AddInPath, "RevitCooperate.OpenLoginForm");
            PushButton loginBtn = ribbon.AddItem(loginButtonData) as PushButton;
            PushButtonData showButtonData = new PushButtonData("show", "显示", AddInPath, "RevitCooperate.Start");
            PushButton mainFormBtn = ribbon.AddItem(showButtonData) as PushButton;
            PushButtonData localConfigButton = new PushButtonData("config", "本地设置", AddInPath, "RevitCooperate.OpenLocalConfigForm");
            PushButton configBtn = ribbon.AddItem(localConfigButton) as PushButton;

            return Result.Succeeded;
        }
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }

}
