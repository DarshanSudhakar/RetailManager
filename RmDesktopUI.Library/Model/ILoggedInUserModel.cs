﻿using System;

namespace RmDesktopUI.Library.Model
{
    public interface ILoggedInUserModel
    {
        DateTime CreatedDate { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string Id { get; set; }
        string LastName { get; set; }
        string Token { get; set; }

        void LogOffUser();
    }
}