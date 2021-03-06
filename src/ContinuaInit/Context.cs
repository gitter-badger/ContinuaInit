﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Context.cs" company="CatenaLogic">
//   Copyright (c) 2014 - 2014 CatenaLogic. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace ContinuaInit
{
    using Catel.Logging;

    public class Context
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        public Context()
        {
        }

        public bool IsHelp { get; set; }
        public string LogFile { get; set; }

        public string BranchName { get; set; }
        public string Version { get; set; }
        public bool IsCi { get; set; }

        public void ValidateContext()
        {
            if (string.IsNullOrEmpty(BranchName))
            {
                Log.ErrorAndThrowException<ContinuaInitException>("Branch name is missing");
            }

            if (string.IsNullOrEmpty(Version))
            {
                Log.ErrorAndThrowException<ContinuaInitException>("Version name is missing");
            }
        }
    }
}