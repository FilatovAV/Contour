using System.Windows.Forms;
using GeobridgeClassLibrary;

namespace Contour.AutoCAD.Plugin.Commands
{
    public class BaseCommands
    {
        [Autodesk.AutoCAD.Runtime.CommandMethod("ContourPalette", Autodesk.AutoCAD.Runtime.CommandFlags.NoHistory)]
        public void MainPaletteShow()
        {
            try
            {
                Main.MainPaletteSet.Visible = !Main.MainPaletteSet.Visible;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Исключение в ContourPalette\n{ex.Message}", CommonMessages.GeobridgeContours, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
