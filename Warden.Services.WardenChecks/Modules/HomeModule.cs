﻿namespace Warden.Services.WardenChecks.Modules
{
    public class HomeModule : ModuleBase
    {
        public HomeModule() : base(requireAuthentication: false)
        {
            Get("", args => "Welcome to the Warden.Services.WardenChecks API!");
        }
    }
}