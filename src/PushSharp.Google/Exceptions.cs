﻿namespace PushSharp.Google
{
    using Core;
    using System;
    using System.Collections.Generic;

    public class GcmNotificationException : NotificationException
    {
        public GcmNotificationException(GcmNotification notification, string msg) : base(msg, notification)
        {
            Notification = notification;
        }

        public GcmNotificationException(GcmNotification notification, string msg, string description) : base(msg, notification)
        {
            Notification = notification;
            Description = description;
        }

        public new GcmNotification Notification { get; }

        public string Description { get; }
    }

    public class GcmMulticastResultException : Exception
    {
        public GcmMulticastResultException() : base("One or more Registration Id's failed in the multicast notification")
        {
            Succeeded = new List<GcmNotification>();
            Failed = new Dictionary<GcmNotification, Exception>();
        }

        public List<GcmNotification> Succeeded { get; set; }

        public Dictionary<GcmNotification, Exception> Failed { get; set; }
    }
}
