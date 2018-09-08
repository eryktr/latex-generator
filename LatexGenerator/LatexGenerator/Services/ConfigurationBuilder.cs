using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatexGenerator.Services
{
    public class ConfigurationBuilder
    {
        private MainWindow _mainWindow;

        public ConfigurationBuilder(MainWindow mw)
        {
            _mainWindow = mw;
        }

        public AppConfiguration BuildConfiguration()
        {
            var fileName = _mainWindow.FileTextBox.Text;
            var itemCount = int.Parse(_mainWindow.ItemsTextBox.Text);
            var includeSections = _mainWindow.SectionsCheckBox.IsChecked;
            var sectionsCount = int.Parse(_mainWindow.SectionsTextBox.Text);
            var includeColorBox = _mainWindow.TColorBoxTextBox.IsChecked;
            var Packages = ConfigurationManager.AppSettings["Packages"].Split(',');

            var config = new AppConfiguration
            {
                FileName = fileName,
                ItemCount = itemCount,
                IncludeSections = includeSections,
                SectionCount = sectionsCount,
                IncludeTColorBox = includeColorBox,
                Packages =  Packages
            };

            return config;
        }
    }
}
