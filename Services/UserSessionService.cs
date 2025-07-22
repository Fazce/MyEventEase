using System;

namespace MyEventEase.Services
{
    public class UserSessionService
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public bool IsRegistered { get; set; }

        public void Register(string name, string email)
        {
            UserName = name;
            Email = email;
            IsRegistered = true;
        }

        public void Clear()
        {
            UserName = null;
            Email = null;
            IsRegistered = false;
        }
    }
}