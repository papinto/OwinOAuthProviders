﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Owin.Security.Providers.OpenID;

namespace Owin.Security.Providers.Wargaming
{
    public class WargamingAuthenticationOptions : OpenIDAuthenticationOptions
    {

        public enum Region
        {
            Europe,
            US,
            Russia
        }

        /// <summary>
        /// Gets or sets the Wargaming-assigned appId
        /// </summary>
        public string AppId { get; set; }
    }


}
