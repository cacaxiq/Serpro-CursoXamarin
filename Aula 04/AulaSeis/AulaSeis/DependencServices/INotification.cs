using System;


namespace AulaSeis.DependencServices
{
    public interface INotification
    {
        void PushNotification(string message, string title);
    }
}
