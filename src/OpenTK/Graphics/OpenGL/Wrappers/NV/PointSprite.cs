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

namespace OpenTK.Graphics.OpenGL
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "PointSprite" in the extension "NV".
        /// </summary>
        public static partial class NV
        {
            /// <summary>
            /// [requires: NV_point_sprite]
            /// Specify point parameters
            /// </summary>
            /// <param name="pname">
            /// Specifies a single-valued point parameter. PointFadeThresholdSize, and PointSpriteCoordOrigin are accepted.
            /// </param>
            /// <param name="param">
            /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
            /// </param>
            [AutoGenerated(Category = "NV_point_sprite", Version = "", EntryPoint = "glPointParameteriNV")]
            public static void PointParameter(OpenTK.Graphics.OpenGL.NvPointSprite pname, int param)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_point_sprite]
            /// Specify point parameters
            /// </summary>
            /// <param name="pname">
            /// Specifies a single-valued point parameter. PointFadeThresholdSize, and PointSpriteCoordOrigin are accepted.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
            /// </param>
            [AutoGenerated(Category = "NV_point_sprite", Version = "", EntryPoint = "glPointParameterivNV")]
            public static void PointParameter(OpenTK.Graphics.OpenGL.NvPointSprite pname, [CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_point_sprite]
            /// Specify point parameters
            /// </summary>
            /// <param name="pname">
            /// Specifies a single-valued point parameter. PointFadeThresholdSize, and PointSpriteCoordOrigin are accepted.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
            /// </param>
            [AutoGenerated(Category = "NV_point_sprite", Version = "", EntryPoint = "glPointParameterivNV")]
            public static void PointParameter(OpenTK.Graphics.OpenGL.NvPointSprite pname, [CountAttribute(Computed = "pname")] ref int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_point_sprite]
            /// Specify point parameters
            /// </summary>
            /// <param name="pname">
            /// Specifies a single-valued point parameter. PointFadeThresholdSize, and PointSpriteCoordOrigin are accepted.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// For glPointParameterf and glPointParameteri, specifies the value that pname will be set to.
            /// </param>
            [AutoGenerated(Category = "NV_point_sprite", Version = "", EntryPoint = "glPointParameterivNV")]
            public static unsafe void PointParameter(OpenTK.Graphics.OpenGL.NvPointSprite pname, [CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(1705)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glPointParameteriNV(OpenTK.Graphics.OpenGL.NvPointSprite pname, int param);

            [Slot(1707)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glPointParameterivNV(OpenTK.Graphics.OpenGL.NvPointSprite pname, [CountAttribute(Computed = "pname")] int* @params);
        }
    }
}
