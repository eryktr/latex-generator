using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LatexGenerator.Models;

namespace LatexGenerator.Services
{
    public static class WindowManager
    {

        public static void DisplayError(ErrorType errorType)
        {
            string message = string.Empty;
            string title = string.Empty;
            switch (errorType)
            {
                case ErrorType.FileExists:
                    message = "The file with the specified name already exists.";
                    title = "File exists";
                    break;

                case ErrorType.NoWritePermission:
                    message = "You don't have write permission for the chosen folder";
                    title = "No write permission";
                    break;

                case ErrorType.NotEnoughMemory:
                    message = "Not enough memory";
                    title = "Insufficient memory";
                    break;
            }

            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }

    }
}
