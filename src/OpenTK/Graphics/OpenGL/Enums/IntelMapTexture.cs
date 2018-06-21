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
    /// Used in GL.Intel.MapTexture2D
    /// </summary>
    public enum IntelMapTexture
    {
        /// <summary>
        /// Original was GL_LAYOUT_DEFAULT_INTEL = 0
        /// </summary>
        LayoutDefaultIntel = 0,

        /// <summary>
        /// Original was GL_TEXTURE_MEMORY_LAYOUT_INTEL = 0x83FF
        /// </summary>
        TextureMemoryLayoutIntel = 0x83ff,

        /// <summary>
        /// Original was GL_LAYOUT_LINEAR_INTEL = 1
        /// </summary>
        LayoutLinearIntel = 1,

        /// <summary>
        /// Original was GL_LAYOUT_LINEAR_CPU_CACHED_INTEL = 2
        /// </summary>
        LayoutLinearCpuCachedIntel = 2
    }
}
