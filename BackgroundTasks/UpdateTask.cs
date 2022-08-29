using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;
using Windows.UI.Notifications;

namespace BackgroundTasks
{
    public sealed class UpdateTask : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            var toast = new ToastContentBuilder().AddText($"UpdateTask.Run: NEW").AddArgument("updated");
            toast.Show();
            Debug.WriteLine("UpdateTask.Run");
        }
    }
}
