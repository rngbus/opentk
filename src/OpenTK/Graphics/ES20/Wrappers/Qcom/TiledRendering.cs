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

namespace OpenTK.Graphics.ES20
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "TiledRendering" in the extension "Qcom".
        /// </summary>
        public static partial class Qcom
        {
            /// <summary>
            /// [requires: QCOM_tiled_rendering]
            /// </summary>
            /// <param name="preserveMask">
            /// </param>
            [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "", EntryPoint = "glEndTilingQCOM")]
            public static void EndTiling(OpenTK.Graphics.ES20.BufferBitQcom preserveMask)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: QCOM_tiled_rendering]
            /// </summary>
            /// <param name="x">
            /// </param>
            /// <param name="y">
            /// </param>
            /// <param name="width">
            /// </param>
            /// <param name="height">
            /// </param>
            /// <param name="preserveMask">
            /// </param>
            [AutoGenerated(Category = "QCOM_tiled_rendering", Version = "", EntryPoint = "glStartTilingQCOM")]
            public static void StartTiling(uint x, uint y, uint width, uint height, OpenTK.Graphics.ES20.BufferBitQcom preserveMask)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(158)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glEndTilingQCOM(OpenTK.Graphics.ES20.BufferBitQcom preserveMask);

            [Slot(530)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glStartTilingQCOM(uint x, uint y, uint width, uint height, OpenTK.Graphics.ES20.BufferBitQcom preserveMask);
        }
    }
}
