﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace RA.Blazored.LocalStorage
{
    [ExcludeFromCodeCoverage]
    public class ChangingEventArgs : ChangedEventArgs
    {
        public bool Cancel { get; set; }
    }
}
