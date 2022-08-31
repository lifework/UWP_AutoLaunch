using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Management.Deployment;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace UWP_AutoLaunch
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public string AssemblyVersion
        {
            get
            {
                var aversion = typeof(App).GetTypeInfo().Assembly.GetName().Version;
                if (aversion != null)
                {
                    return $"{aversion?.Major}.{aversion?.Minor}.{aversion?.Build}";
                }
                return "0.0.0";
            }
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync();
        }

        /*
                public static readonly string PackageName = "A4B91446.UWPAutoLaunch";

                public string PackageVersion
                {
                    get
                    {

                        var version = InstalledPackageVersion();
                        return $"{version.Major}.{version.Minor}.{version.Build}";
                    }
                }

                public static Package InstalledPackage()
                {
                    var manager = new PackageManager();
                    var packages = manager.FindPackagesForUser(string.Empty);
                    Package package = packages.FirstOrDefault(x => x.Id.Name == PackageName);
                    if (package != null)
                    {
                        package = manager.FindPackageForUser(string.Empty, package.Id.FullName);
                    }
                    return package;
                }

                public static PackageVersion InstalledPackageVersion()
                {
                    return InstalledPackage().Id.Version;
                }
        */
    }
}
