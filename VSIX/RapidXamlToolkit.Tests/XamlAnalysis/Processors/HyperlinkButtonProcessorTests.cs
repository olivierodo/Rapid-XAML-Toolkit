﻿// Copyright (c) Matt Lacey Ltd. All rights reserved.
// Licensed under the MIT license.

using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RapidXamlToolkit.XamlAnalysis.Processors;
using RapidXamlToolkit.XamlAnalysis.Tags;

namespace RapidXamlToolkit.Tests.XamlAnalysis.Processors
{
    [TestClass]
    public class HyperlinkButtonProcessorTests : ProcessorTestsBase
    {
        [TestMethod]
        public void HardCoded_Content_Detected()
        {
            var xaml = @"<HyperlinkButton Content=""HCValue"" />";

            var outputTags = this.GetTags<HyperlinkButtonProcessor>(xaml);

            Assert.AreEqual(1, outputTags.Count);
            Assert.AreEqual(1, outputTags.OfType<HardCodedStringTag>().Count());
        }
    }
}
