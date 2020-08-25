using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Windows;
using Contour.AutoCAD.Plugin.Controls;

namespace Contour.AutoCAD.Plugin
{
    public class Main : IExtensionApplication
    {
        public static  PaletteSet MainPaletteSet;
        public static readonly MainPalette MainPalette = new MainPalette();
        public void Initialize()
        {
            MainPaletteSet = new PaletteSet("Contour.AutoCAD.Plugin", Guid.Parse("{9D231C75-8EE5-488E-9EF5-9A3F35EC9ED9}"));
            MainPaletteSet.Add("ContourMainPaletteSet", MainPalette);

            var initializer = new Initializer();
            initializer.Initialize();
        }

        public void Terminate()
        { }
    }
}
