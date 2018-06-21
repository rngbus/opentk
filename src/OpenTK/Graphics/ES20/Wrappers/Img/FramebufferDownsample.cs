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
        /// Contains native bindings to functions in the category "FramebufferDownsample" in the extension "Img".
        /// </summary>
        public static partial class Img
        {
            /// <summary>
            /// [requires: IMG_framebuffer_downsample]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="attachment">
            /// </param>
            /// <param name="textarget">
            /// </param>
            /// <param name="texture">
            /// </param>
            /// <param name="level">
            /// </param>
            /// <param name="xscale">
            /// </param>
            /// <param name="yscale">
            /// </param>
            [AutoGenerated(Category = "IMG_framebuffer_downsample", Version = "", EntryPoint = "glFramebufferTexture2DDownsampleIMG")]
            public static void FramebufferTexture2DDownsample(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.FramebufferAttachment attachment, OpenTK.Graphics.ES20.TextureTarget textarget, uint texture, int level, int xscale, int yscale)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: IMG_framebuffer_downsample]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="attachment">
            /// </param>
            /// <param name="texture">
            /// </param>
            /// <param name="level">
            /// </param>
            /// <param name="layer">
            /// </param>
            /// <param name="xscale">
            /// </param>
            /// <param name="yscale">
            /// </param>
            [AutoGenerated(Category = "IMG_framebuffer_downsample", Version = "", EntryPoint = "glFramebufferTextureLayerDownsampleIMG")]
            public static void FramebufferTextureLayerDownsample(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.FramebufferAttachment attachment, uint texture, int level, int layer, int xscale, int yscale)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(184)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFramebufferTexture2DDownsampleIMG(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.FramebufferAttachment attachment, OpenTK.Graphics.ES20.TextureTarget textarget, uint texture, int level, int xscale, int yscale);

            [Slot(189)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFramebufferTextureLayerDownsampleIMG(OpenTK.Graphics.ES20.FramebufferTarget target, OpenTK.Graphics.ES20.FramebufferAttachment attachment, uint texture, int level, int layer, int xscale, int yscale);
        }
    }
}
