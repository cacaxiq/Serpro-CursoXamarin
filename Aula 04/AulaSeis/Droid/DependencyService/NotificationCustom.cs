using System;
using Android.App;
using AulaSeis.DependencServices;
using AulaSeis.Droid.DependencyService;
using Xamarin.Forms.Platform.Android;
using Android.Content;

[assembly: Xamarin.Forms.Dependency(typeof(NotificationCustom))]
namespace AulaSeis.Droid.DependencyService
{
    public class NotificationCustom : PageRenderer, INotification
    {
        public NotificationCustom()
        {
        }

        void INotification.PushNotification(string message, string title)
        {
            Context Context = this.Context;

            // Instantiate the builder and set notification elements:
            Notification.Builder builder = new Notification.Builder(Context)
                .SetContentTitle(title)
                .SetContentText(message)
                .SetSmallIcon(Resource.Drawable.icon);

            // Build the notification:
            Notification notification = builder.Build();

            // Get the notification manager:
            NotificationManager notificationManager = Context.GetSystemService(Context.NotificationService) as NotificationManager;


            // Publish the notification:
            const int notificationId = 0;
            notificationManager.Notify(notificationId, notification);

        }
    }
}
