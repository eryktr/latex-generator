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
        private readonly MainWindow _mainWindow;

        public ConfigurationBuilder(MainWindow mw)
        {
            _mainWindow = mw;
        }

        public AppConfiguration BuildConfiguration()
        {

            var fileName =  _mainWindow.FileTextBox.Text != string.Empty ?_mainWindow.FileTextBox.Text : "";
            var itemCount =  _mainWindow.ItemsTextBox.Text != string.Empty ? int.Parse(_mainWindow.ItemsTextBox.Text):0;
            var includeSections = _mainWindow.SectionsCheckBox.IsChecked;
            var sectionsCount = _mainWindow.SectionsTextBox.Text != string.Empty ? int.Parse(_mainWindow.SectionsTextBox.Text) : 0;
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
