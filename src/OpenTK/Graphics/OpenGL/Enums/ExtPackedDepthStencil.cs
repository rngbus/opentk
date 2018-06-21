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

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtPackedDepthStencil
    {
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_EXT = 0x84F9
        /// </summary>
        DepthStencilExt = 0x84f9,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_24_8_EXT = 0x84FA
        /// </summary>
        UnsignedInt248Ext = 0x84fa,

        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_EXT = 0x88F0
        /// </summary>
        Depth24Stencil8Ext = 0x88f0,

        /// <summary>
        /// Original was GL_TEXTURE_STENCIL_SIZE_EXT = 0x88F1
        /// </summary>
        TextureStencilSizeExt = 0x88f1
    }
}
