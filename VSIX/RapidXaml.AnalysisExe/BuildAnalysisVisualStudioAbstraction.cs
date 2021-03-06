﻿// Copyright (c) Matt Lacey Ltd. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using RapidXamlToolkit;
using RapidXamlToolkit.VisualStudioIntegration;

namespace RapidXaml.AnalysisExe
{
    public class BuildAnalysisVisualStudioAbstraction : IVisualStudioAbstraction
    {
        private readonly string projFile;
        private readonly ProjectType projectType;

        public BuildAnalysisVisualStudioAbstraction(string projFile, ProjectType projectType)
        {
            this.projFile = projFile;
            this.projectType = projectType;
        }

        public bool ActiveDocumentIsCSharp()
        {
            throw new NotImplementedException();
        }

        public void DeleteFromEndOfLine(int lineNumber, int charsToDelete)
        {
            throw new NotImplementedException();
        }

        public void EndSingleUndoOperation()
        {
            throw new NotImplementedException();
        }

        public string GetActiveDocumentFileName()
        {
            throw new NotImplementedException();
        }

        public string GetActiveDocumentText()
        {
            throw new NotImplementedException();
        }

        public ProjectWrapper GetActiveProject()
        {
            throw new NotImplementedException();
        }

        public int GetCursorPosition()
        {
            throw new NotImplementedException();
        }

        public (int, int) GetCursorPositionAndLineNumber()
        {
            throw new NotImplementedException();
        }

        public Task<(SyntaxTree syntaxTree, SemanticModel semModel)> GetDocumentModelsAsync(string fileName)
        {
            throw new NotImplementedException();
        }

        public Task<(SyntaxTree syntaxTree, SemanticModel semModel)> GetDocumentModelsAsync(Microsoft.CodeAnalysis.Document document)
        {
            throw new NotImplementedException();
        }

        public ProjectWrapper GetProject(string projectName)
        {
            throw new NotImplementedException();
        }

        public (string projectFileName, ProjectType propjectType) GetNameAndTypeOfProjectContainingFile(string fileName)
        {
            return (this.projFile, this.projectType);
        }

        public ProjectType GetProjectType(EnvDTE.Project project)
        {
            return ProjectType.Any;
        }

        public Task<int> GetXamlIndentAsync()
        {
            throw new NotImplementedException();
        }

        public void InsertAtEndOfLine(int lineNumber, string toInsert)
        {
            throw new NotImplementedException();
        }

        public void InsertIntoActiveDocOnLineAfterClosingTag(int openingAngleBracketLineNumber, string toInsert)
        {
            throw new NotImplementedException();
        }

        public void InsertIntoActiveDocumentOnNextLine(string text, int pos)
        {
            throw new NotImplementedException();
        }

        public void RemoveInActiveDocOnLine(string find, int lineNumber)
        {
            throw new NotImplementedException();
        }

        public void ReplaceInActiveDoc(string find, string replace, int startIndex, int endIndex)
        {
            throw new NotImplementedException();
        }

        public void ReplaceInActiveDoc(List<(string find, string replace)> replacements, int startIndex, int endIndex, Dictionary<int, int> exclusions)
        {
            throw new NotImplementedException();
        }

        public void ReplaceInActiveDocOnLine(string find, string replace, int lineNumber)
        {
            throw new NotImplementedException();
        }

        public void ReplaceInActiveDocOnLineOrAbove(string find, string replace, int lineNumber)
        {
            throw new NotImplementedException();
        }

        public bool StartSingleUndoOperation(string name)
        {
            throw new NotImplementedException();
        }

        public bool UserConfirms(string title, string message)
        {
            throw new NotImplementedException();
        }
    }
}
