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

namespace OpenTK.Graphics.ES11
{
    /// <summary>
    /// Used in GL.ReadPixels, GL.TexImage2D and 3 other functions
    /// </summary>
    public enum PixelType
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = 0x1400,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = 0x1401,

        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = 0x1402,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = 0x1403,

        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = 0x1404,

        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = 0x1405,

        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = 0x1406,

        /// <summary>
        /// Original was GL_BITMAP = 0x1A00
        /// </summary>
        Bitmap = 0x1a00,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE_3_3_2 = 0x8032
        /// </summary>
        UnsignedByte332 = 0x8032,

        /// <summary>
        /// Original was GL_UNSIGNED_BYTE_3_3_2_EXT = 0x8032
        /// </summary>
        UnsignedByte332Ext = 0x8032,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033
        /// </summary>
        UnsignedShort4444 = 0x8033,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033
        /// </summary>
        UnsignedShort4444Ext = 0x8033,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034
        /// </summary>
        UnsignedShort5551 = 0x8034,

        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034
        /// </summary>
        UnsignedShort5551Ext = 0x8034,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_8_8_8_8 = 0x8035
        /// </summary>
        UnsignedInt8888 = 0x8035,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_8_8_8_8_EXT = 0x8035
        /// </summary>
        UnsignedInt8888Ext = 0x8035,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_10_10_10_2 = 0x8036
        /// </summary>
        UnsignedInt1010102 = 0x8036,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_10_10_10_2_EXT = 0x8036
        /// </summary>
        UnsignedInt1010102Ext = 0x8036
    }
}
