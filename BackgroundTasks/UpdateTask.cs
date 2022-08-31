using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Background;
using Windows.UI.Notifications;

namespace BackgroundTasks
{
    public sealed class UpdateTask : IBackgroundTask
    {
        public async void Run(IBackgroundTaskInstance taskInstance)
        {
            new ToastContentBuilder().AddText($"UpdateTask.Run: NEW").AddArgument("updated").Show();

            await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync();
            Debug.WriteLine("UpdateTask.Run");
        }
    }
}
