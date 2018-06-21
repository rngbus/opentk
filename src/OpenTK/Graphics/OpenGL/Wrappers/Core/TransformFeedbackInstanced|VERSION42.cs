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
        /// [requires: v4.2 or ARB_transform_feedback_instanced|VERSION_4_2]
        /// Render multiple instances of primitives using a count derived from a transform feedback object
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="id">
        /// Specifies the name of a transform feedback object from which to retrieve a primitive count.
        /// </param>
        /// <param name="instancecount">
        /// Specifies the number of instances of the geometry to render.
        /// </param>
        [AutoGenerated(Category = "ARB_transform_feedback_instanced|VERSION_4_2", Version = "4.2", EntryPoint = "glDrawTransformFeedbackInstanced")]
        public static void DrawTransformFeedbackInstanced(OpenTK.Graphics.OpenGL.PrimitiveType mode, uint id, int instancecount)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.2 or ARB_transform_feedback_instanced|VERSION_4_2]
        /// Render multiple instances of primitives using a count derived from a specifed stream of a transform feedback object
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="id">
        /// Specifies the name of a transform feedback object from which to retrieve a primitive count.
        /// </param>
        /// <param name="stream">
        /// Specifies the index of the transform feedback stream from which to retrieve a primitive count.
        /// </param>
        /// <param name="instancecount">
        /// Specifies the number of instances of the geometry to render.
        /// </param>
        [AutoGenerated(Category = "ARB_transform_feedback_instanced|VERSION_4_2", Version = "4.2", EntryPoint = "glDrawTransformFeedbackStreamInstanced")]
        public static void DrawTransformFeedbackStreamInstanced(OpenTK.Graphics.OpenGL.PrimitiveType mode, uint id, uint stream, int instancecount)
        {
            throw new BindingsNotRewrittenException();
        }

        [Slot(509)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawTransformFeedbackInstanced(OpenTK.Graphics.OpenGL.PrimitiveType mode, uint id, int instancecount);

        [Slot(512)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawTransformFeedbackStreamInstanced(OpenTK.Graphics.OpenGL.PrimitiveType mode, uint id, uint stream, int instancecount);
    }
}
