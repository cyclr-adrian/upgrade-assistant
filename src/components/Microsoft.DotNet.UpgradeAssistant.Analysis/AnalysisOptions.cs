﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Microsoft.DotNet.UpgradeAssistant.Analysis
{
    public class AnalysisOptions
    {
        [Required]
        public string Format { get; set; } = null!;
    }
}
