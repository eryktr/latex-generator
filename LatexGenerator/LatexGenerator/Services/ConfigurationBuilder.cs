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
            var simplePackages = ConfigurationManager.AppSettings["SimplePackages"].Split(';');
            var complexPackages = ConfigurationManager.AppSettings["ComplexPackages"].Split(';');

            var config = new AppConfiguration
            {
                FileName = fileName,
                ItemCount = itemCount,
                IncludeSections = includeSections,
                SectionCount = sectionsCount,
                IncludeTColorBox = includeColorBox,
                SimplePackages =  simplePackages,
                ComplexPackages = complexPackages
            };

            return config;
        }
    }
}
