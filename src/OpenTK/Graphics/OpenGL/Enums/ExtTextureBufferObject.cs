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
    public enum ExtTextureBufferObject
    {
        /// <summary>
        /// Original was GL_TEXTURE_BUFFER_EXT = 0x8C2A
        /// </summary>
        TextureBufferExt = 0x8c2a,

        /// <summary>
        /// Original was GL_MAX_TEXTURE_BUFFER_SIZE_EXT = 0x8C2B
        /// </summary>
        MaxTextureBufferSizeExt = 0x8c2b,

        /// <summary>
        /// Original was GL_TEXTURE_BINDING_BUFFER_EXT = 0x8C2C
        /// </summary>
        TextureBindingBufferExt = 0x8c2c,

        /// <summary>
        /// Original was GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT = 0x8C2D
        /// </summary>
        TextureBufferDataStoreBindingExt = 0x8c2d,

        /// <summary>
        /// Original was GL_TEXTURE_BUFFER_FORMAT_EXT = 0x8C2E
        /// </summary>
        TextureBufferFormatExt = 0x8c2e
    }
}
