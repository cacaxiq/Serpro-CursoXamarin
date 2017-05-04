using System;
using System.IO;
using Xamarin.Forms;
using SerproApp.Helpers.Dependency;
using SerproApp.iOS.Dependency;

[assembly: Dependency(typeof(FileHelper))]
namespace SerproApp.iOS.Dependency
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}
