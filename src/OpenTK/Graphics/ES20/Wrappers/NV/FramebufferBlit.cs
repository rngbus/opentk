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
        /// Contains native bindings to functions in the category "FramebufferBlit" in the extension "NV".
        /// </summary>
        public static partial class NV
        {
            /// <summary>
            /// [requires: NV_framebuffer_blit]
            /// </summary>
            /// <param name="srcX0">
            /// </param>
            /// <param name="srcY0">
            /// </param>
            /// <param name="srcX1">
            /// </param>
            /// <param name="srcY1">
            /// </param>
            /// <param name="dstX0">
            /// </param>
            /// <param name="dstY0">
            /// </param>
            /// <param name="dstX1">
            /// </param>
            /// <param name="dstY1">
            /// </param>
            /// <param name="mask">
            /// </param>
            /// <param name="filter">
            /// </param>
            [AutoGenerated(Category = "NV_framebuffer_blit", Version = "", EntryPoint = "glBlitFramebufferNV")]
            public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, OpenTK.Graphics.ES20.ClearBufferMask mask, OpenTK.Graphics.ES20.BlitFramebufferFilter filter)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(38)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glBlitFramebufferNV(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, OpenTK.Graphics.ES20.ClearBufferMask mask, OpenTK.Graphics.ES20.BlitFramebufferFilter filter);
        }
    }
}
