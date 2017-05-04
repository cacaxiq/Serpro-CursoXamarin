using System;
using System.IO;
using Xamarin.Forms;
using SerproApp.Droid.Dependency;
using SerproApp.Helpers.Dependency;

[assembly: Dependency(typeof(FileHelper))]
namespace SerproApp.Droid.Dependency
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
