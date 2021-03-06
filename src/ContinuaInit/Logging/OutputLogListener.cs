﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OutputLogListener.cs" company="CatenaLogic">
//   Copyright (c) 2014 - 2014 CatenaLogic. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace ContinuaInit.Logging
{
    using System;
    using Catel.Logging;

    public class OutputLogListener : ConsoleLogListener
    {
        public OutputLogListener()
        {
            IgnoreCatelLogging = true;
            IsDebugEnabled = true;
        }

        protected override string FormatLogEvent(ILog log, string message, LogEvent logEvent, object extraData, DateTime time)
        {
            return message;
        }
    }
}