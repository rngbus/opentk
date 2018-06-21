//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.ES30
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "CoverageSample" in the extension "NV".
        /// </summary>
        public static partial class NV
        {
            /// <summary>
            /// [requires: NV_coverage_sample]
            /// </summary>
            /// <param name="mask">
            /// </param>
            [AutoGenerated(Category = "NV_coverage_sample", Version = "", EntryPoint = "glCoverageMaskNV")]
            public static void CoverageMask(bool mask)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_coverage_sample]
            /// </summary>
            /// <param name="operation">
            /// </param>
            [AutoGenerated(Category = "NV_coverage_sample", Version = "", EntryPoint = "glCoverageOperationNV")]
            public static void CoverageOperation(OpenTK.Graphics.ES30.NvCoverageSample operation)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(88)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glCoverageMaskNV(bool mask);

            [Slot(91)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glCoverageOperationNV(OpenTK.Graphics.ES30.NvCoverageSample operation);
        }
    }
}
