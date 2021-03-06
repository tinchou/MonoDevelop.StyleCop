﻿//-----------------------------------------------------------------------
// <copyright file="AnalysisType.cs">
//   APL 2.0
// </copyright>
// <license>
//   Copyright 2013 Alexander Jochum
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </license>
//-----------------------------------------------------------------------
namespace MonoDevelop.StyleCop
{
  /// <summary>
  /// Available analysis possibilities/types.
  /// </summary>
  internal enum AnalysisType
  {
    /// <summary>
    /// Analyze the active document.
    /// </summary>
    ActiveDocument,

    /// <summary>
    /// Analyze a file or all selected files.
    /// </summary>
    File,

    /// <summary>
    /// Analyze all supported files in the selected folder.
    /// </summary>
    Folder,

    /// <summary>
    /// Analyze all supported files in the selected project.
    /// </summary>
    Project,

    /// <summary>
    /// Analyze all supported files in the selected project.
    /// </summary>
    /// <remarks>This type is only necessary for MonoDevelop so it can show the correct entry.</remarks>
    ProjectFullAnalysis,

    /// <summary>
    /// Analyze all supported files in the solution.
    /// </summary>
    Solution,

    /// <summary>
    /// Analyze all supported files in the solution.
    /// </summary>
    /// <remarks>This type is only necessary for MonoDevelop so it can show the correct entry.</remarks>
    SolutionFullAnalysis
  }
}