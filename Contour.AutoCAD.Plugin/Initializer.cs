using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeobridgeClassLibrary;

namespace Contour.AutoCAD.Plugin
{
    class Initializer
    {
        private readonly CommonReflectionMethods _commonReflection = new CommonReflectionMethods();
        private readonly CommonVariablesMethods _commonVariablesMethods = new CommonVariablesMethods();

        /// <summary> Инициализация путей доступа и разрешений для приложения. </summary>
        public void Initialize()
        {
            try
            {
                //MENU first
                var menuGroups = _commonReflection.GetMenuGroups();
                var menuIsFind = _commonReflection.HasToolbarMenu(CommonProperties.ApplicationGbContourMenuName, menuGroups);

                //PATH
                _commonReflection.PathAddToSupportPath(CommonProperties.ApplicationPath);
                //TRUSTEDPATHS
                _commonVariablesMethods.SetTrustedPath(CommonProperties.ApplicationPath);

                //MENU second
                if (menuIsFind == false)
                {
                    _commonReflection.LoadMenuGroup(menuGroups, CommonProperties.ApplicationGbContourMenuFullPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CommonMessages.GeobridgeContours, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
