﻿namespace SamoraMachelChambersGroupOfAdvocates.Service
{
    public interface IMailService
    {
        void SendMessage(string to, string subject, string body);
    }
}
