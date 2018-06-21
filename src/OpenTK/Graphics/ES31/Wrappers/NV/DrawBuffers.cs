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

namespace OpenTK.Graphics.ES31
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "DrawBuffers" in the extension "NV".
        /// </summary>
        public static partial class NV
        {
            /// <summary>
            /// [requires: NV_draw_buffers]
            /// Specifies a list of color buffers to be drawn into
            /// </summary>
            /// <param name="n">
            /// Specifies the number of buffers in bufs.
            /// </param>
            /// <param name="bufs">
            /// [length: n]
            /// Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be written.
            /// </param>
            [AutoGenerated(Category = "NV_draw_buffers", Version = "", EntryPoint = "glDrawBuffersNV")]
            public static void DrawBuffers(int n, [CountAttribute(Parameter = "n")] OpenTK.Graphics.ES31.NvDrawBuffers[] bufs)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_draw_buffers]
            /// Specifies a list of color buffers to be drawn into
            /// </summary>
            /// <param name="n">
            /// Specifies the number of buffers in bufs.
            /// </param>
            /// <param name="bufs">
            /// [length: n]
            /// Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be written.
            /// </param>
            [AutoGenerated(Category = "NV_draw_buffers", Version = "", EntryPoint = "glDrawBuffersNV")]
            public static void DrawBuffers(int n, [CountAttribute(Parameter = "n")] ref OpenTK.Graphics.ES31.NvDrawBuffers bufs)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_draw_buffers]
            /// Specifies a list of color buffers to be drawn into
            /// </summary>
            /// <param name="n">
            /// Specifies the number of buffers in bufs.
            /// </param>
            /// <param name="bufs">
            /// [length: n]
            /// Points to an array of symbolic constants specifying the buffers into which fragment colors or data values will be written.
            /// </param>
            [AutoGenerated(Category = "NV_draw_buffers", Version = "", EntryPoint = "glDrawBuffersNV")]
            public static unsafe void DrawBuffers(int n, [CountAttribute(Parameter = "n")] OpenTK.Graphics.ES31.NvDrawBuffers* bufs)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(163)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glDrawBuffersNV(int n, [CountAttribute(Parameter = "n")] OpenTK.Graphics.ES31.NvDrawBuffers* bufs);
        }
    }
}
