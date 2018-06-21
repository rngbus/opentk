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

namespace OpenTK.Graphics.ES31
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtBlendFuncExtended
    {
        /// <summary>
        /// Original was GL_SRC_ALPHA_SATURATE_EXT = 0x0308
        /// </summary>
        SrcAlphaSaturateExt = 0x0308,

        /// <summary>
        /// Original was GL_SRC1_ALPHA_EXT = 0x8589
        /// </summary>
        Src1AlphaExt = 0x8589,

        /// <summary>
        /// Original was GL_SRC1_COLOR_EXT = 0x88F9
        /// </summary>
        Src1ColorExt = 0x88f9,

        /// <summary>
        /// Original was GL_ONE_MINUS_SRC1_COLOR_EXT = 0x88FA
        /// </summary>
        OneMinusSrc1ColorExt = 0x88fa,

        /// <summary>
        /// Original was GL_ONE_MINUS_SRC1_ALPHA_EXT = 0x88FB
        /// </summary>
        OneMinusSrc1AlphaExt = 0x88fb,

        /// <summary>
        /// Original was GL_MAX_DUAL_SOURCE_DRAW_BUFFERS_EXT = 0x88FC
        /// </summary>
        MaxDualSourceDrawBuffersExt = 0x88fc,

        /// <summary>
        /// Original was GL_LOCATION_INDEX_EXT = 0x930F
        /// </summary>
        LocationIndexExt = 0x930f
    }
}
