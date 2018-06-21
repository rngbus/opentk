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
        /// Contains native bindings to functions in the category "FramebufferBlit" in the extension "Angle".
        /// </summary>
        public static partial class Angle
        {
            /// <summary>
            /// [requires: ANGLE_framebuffer_blit]
            /// Copy a block of pixels from the read framebuffer to the draw framebuffer
            /// </summary>
            /// <param name="srcX0">
            /// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
            /// </param>
            /// <param name="srcY0">
            /// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
            /// </param>
            /// <param name="srcX1">
            /// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
            /// </param>
            /// <param name="srcY1">
            /// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
            /// </param>
            /// <param name="dstX0">
            /// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
            /// </param>
            /// <param name="dstY0">
            /// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
            /// </param>
            /// <param name="dstX1">
            /// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
            /// </param>
            /// <param name="dstY1">
            /// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
            /// </param>
            /// <param name="mask">
            /// The bitwise OR of the flags indicating which buffers are to be copied. The allowed flags are ColorBufferBit, DepthBufferBit and StencilBufferBit.
            /// </param>
            /// <param name="filter">
            /// Specifies the interpolation to be applied if the image is stretched. Must be Nearest or Linear.
            /// </param>
            [AutoGenerated(Category = "ANGLE_framebuffer_blit", Version = "", EntryPoint = "glBlitFramebufferANGLE")]
            public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, OpenTK.Graphics.ES31.ClearBufferMask mask, OpenTK.Graphics.ES31.BlitFramebufferFilter filter)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(49)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glBlitFramebufferANGLE(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, OpenTK.Graphics.ES31.ClearBufferMask mask, OpenTK.Graphics.ES31.BlitFramebufferFilter filter);
        }
    }
}
