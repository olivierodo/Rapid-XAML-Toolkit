﻿// Copyright (c) Matt Lacey Ltd. All rights reserved.
// Licensed under the MIT license.

namespace RapidXaml
{
    public class AutoFixAnalysisActions : AnalysisActions
    {
        public static AnalysisActions RenameElement(string newName)
        {
            return RenameElement(
                RapidXamlErrorType.Error,
                string.Empty,
                string.Empty,
                string.Empty,
                newName);
        }

        public static AnalysisActions AddAttribute(string addAttributeName, string addAttributeValue)
        {
            return AddAttribute(
                RapidXamlErrorType.Error,
                string.Empty,
                string.Empty,
                string.Empty,
                addAttributeName,
                addAttributeValue);
        }

        public static AnalysisActions AddChildString(string xaml)
        {
            return AddChildString(
                RapidXamlErrorType.Error,
                string.Empty,
                string.Empty,
                string.Empty,
                xaml);
        }

        public static AnalysisActions RemoveAttribute(string attributeName)
        {
            return RemoveAttribute(
                RapidXamlErrorType.Error,
                string.Empty,
                string.Empty,
                string.Empty,
                attributeName);
        }

        public static AnalysisActions RemoveChild(RapidXamlElement child)
        {
            return RemoveChild(
                RapidXamlErrorType.Error,
                string.Empty,
                string.Empty,
                string.Empty,
                child);
        }

        public static AnalysisActions ReplaceElement(string replacementXaml)
        {
            return ReplaceElement(
                RapidXamlErrorType.Error,
                string.Empty,
                string.Empty,
                string.Empty,
                replacementXaml);
        }
    }
}
