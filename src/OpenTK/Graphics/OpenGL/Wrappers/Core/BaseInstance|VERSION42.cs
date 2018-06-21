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
        /// [requires: v4.2 or ARB_base_instance|VERSION_4_2]
        /// Draw multiple instances of a range of elements with offset applied to instanced attributes
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, TrianglesLinesAdjacency, LineStripAdjacency, TrianglesAdjacency, TriangleStripAdjacency and Patches are accepted.
        /// </param>
        /// <param name="first">
        /// Specifies the starting index in the enabled arrays.
        /// </param>
        /// <param name="count">
        /// Specifies the number of indices to be rendered.
        /// </param>
        /// <param name="instancecount">
        /// Specifies the number of instances of the specified range of indices to be rendered.
        /// </param>
        /// <param name="baseinstance">
        /// Specifies the base instance for use in fetching instanced vertex attributes.
        /// </param>
        [AutoGenerated(Category = "ARB_base_instance|VERSION_4_2", Version = "4.2", EntryPoint = "glDrawArraysInstancedBaseInstance")]
        public static void DrawArraysInstancedBaseInstance(OpenTK.Graphics.OpenGL.PrimitiveType mode, int first, int count, int instancecount, uint baseinstance)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.2 or ARB_base_instance|VERSION_4_2]
        /// Draw multiple instances of a set of elements with offset applied to instanced attributes
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency and Patches are accepted.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
        /// </param>
        /// <param name="indices">
        /// [length: count]
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="instancecount">
        /// Specifies the number of instances of the specified range of indices to be rendered.
        /// </param>
        /// <param name="baseinstance">
        /// Specifies the base instance for use in fetching instanced vertex attributes.
        /// </param>
        [AutoGenerated(Category = "ARB_base_instance|VERSION_4_2", Version = "4.2", EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public static void DrawElementsInstancedBaseInstance(OpenTK.Graphics.OpenGL.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL.DrawElementsType type, [CountAttribute(Parameter = "count")] IntPtr indices, int instancecount, uint baseinstance)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.2 or ARB_base_instance|VERSION_4_2]
        /// Draw multiple instances of a set of elements with offset applied to instanced attributes
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency and Patches are accepted.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
        /// </param>
        /// <param name="indices">
        /// [length: count]
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="instancecount">
        /// Specifies the number of instances of the specified range of indices to be rendered.
        /// </param>
        /// <param name="baseinstance">
        /// Specifies the base instance for use in fetching instanced vertex attributes.
        /// </param>
        [AutoGenerated(Category = "ARB_base_instance|VERSION_4_2", Version = "4.2", EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public static void DrawElementsInstancedBaseInstance<T3>(OpenTK.Graphics.OpenGL.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] T3[] indices, int instancecount, uint baseinstance)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.2 or ARB_base_instance|VERSION_4_2]
        /// Draw multiple instances of a set of elements with offset applied to instanced attributes
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency and Patches are accepted.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
        /// </param>
        /// <param name="indices">
        /// [length: count]
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="instancecount">
        /// Specifies the number of instances of the specified range of indices to be rendered.
        /// </param>
        /// <param name="baseinstance">
        /// Specifies the base instance for use in fetching instanced vertex attributes.
        /// </param>
        [AutoGenerated(Category = "ARB_base_instance|VERSION_4_2", Version = "4.2", EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public static void DrawElementsInstancedBaseInstance<T3>(OpenTK.Graphics.OpenGL.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] T3[,] indices, int instancecount, uint baseinstance)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.2 or ARB_base_instance|VERSION_4_2]
        /// Draw multiple instances of a set of elements with offset applied to instanced attributes
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency and Patches are accepted.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
        /// </param>
        /// <param name="indices">
        /// [length: count]
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="instancecount">
        /// Specifies the number of instances of the specified range of indices to be rendered.
        /// </param>
        /// <param name="baseinstance">
        /// Specifies the base instance for use in fetching instanced vertex attributes.
        /// </param>
        [AutoGenerated(Category = "ARB_base_instance|VERSION_4_2", Version = "4.2", EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public static void DrawElementsInstancedBaseInstance<T3>(OpenTK.Graphics.OpenGL.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] T3[,,] indices, int instancecount, uint baseinstance)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.2 or ARB_base_instance|VERSION_4_2]
        /// Draw multiple instances of a set of elements with offset applied to instanced attributes
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency and Patches are accepted.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
        /// </param>
        /// <param name="indices">
        /// [length: count]
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="instancecount">
        /// Specifies the number of instances of the specified range of indices to be rendered.
        /// </param>
        /// <param name="baseinstance">
        /// Specifies the base instance for use in fetching instanced vertex attributes.
        /// </param>
        [AutoGenerated(Category = "ARB_base_instance|VERSION_4_2", Version = "4.2", EntryPoint = "glDrawElementsInstancedBaseInstance")]
        public static void DrawElementsInstancedBaseInstance<T3>(OpenTK.Graphics.OpenGL.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] ref T3 indices, int instancecount, uint baseinstance)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.2 or ARB_base_instance|VERSION_4_2]
        /// Render multiple instances of a set of primitives from array data with a per-element offset
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, Triangles, LinesAdjacency, LineStripAdjacency, TrianglesAdjacency, TriangleStripAdjacency and Patches are accepted.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
        /// </param>
        /// <param name="indices">
        /// [length: count]
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="instancecount">
        /// Specifies the number of instances of the indexed geometry that should be drawn.
        /// </param>
        /// <param name="basevertex">
        /// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays.
        /// </param>
        /// <param name="baseinstance">
        /// Specifies the base instance for use in fetching instanced vertex attributes.
        /// </param>
        [AutoGenerated(Category = "ARB_base_instance|VERSION_4_2", Version = "4.2", EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public static void DrawElementsInstancedBaseVertexBaseInstance(OpenTK.Graphics.OpenGL.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL.DrawElementsType type, [CountAttribute(Parameter = "count")] IntPtr indices, int instancecount, int basevertex, uint baseinstance)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.2 or ARB_base_instance|VERSION_4_2]
        /// Render multiple instances of a set of primitives from array data with a per-element offset
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, Triangles, LinesAdjacency, LineStripAdjacency, TrianglesAdjacency, TriangleStripAdjacency and Patches are accepted.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
        /// </param>
        /// <param name="indices">
        /// [length: count]
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="instancecount">
        /// Specifies the number of instances of the indexed geometry that should be drawn.
        /// </param>
        /// <param name="basevertex">
        /// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays.
        /// </param>
        /// <param name="baseinstance">
        /// Specifies the base instance for use in fetching instanced vertex attributes.
        /// </param>
        [AutoGenerated(Category = "ARB_base_instance|VERSION_4_2", Version = "4.2", EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public static void DrawElementsInstancedBaseVertexBaseInstance<T3>(OpenTK.Graphics.OpenGL.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] T3[] indices, int instancecount, int basevertex, uint baseinstance)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.2 or ARB_base_instance|VERSION_4_2]
        /// Render multiple instances of a set of primitives from array data with a per-element offset
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, Triangles, LinesAdjacency, LineStripAdjacency, TrianglesAdjacency, TriangleStripAdjacency and Patches are accepted.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
        /// </param>
        /// <param name="indices">
        /// [length: count]
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="instancecount">
        /// Specifies the number of instances of the indexed geometry that should be drawn.
        /// </param>
        /// <param name="basevertex">
        /// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays.
        /// </param>
        /// <param name="baseinstance">
        /// Specifies the base instance for use in fetching instanced vertex attributes.
        /// </param>
        [AutoGenerated(Category = "ARB_base_instance|VERSION_4_2", Version = "4.2", EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public static void DrawElementsInstancedBaseVertexBaseInstance<T3>(OpenTK.Graphics.OpenGL.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] T3[,] indices, int instancecount, int basevertex, uint baseinstance)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.2 or ARB_base_instance|VERSION_4_2]
        /// Render multiple instances of a set of primitives from array data with a per-element offset
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, Triangles, LinesAdjacency, LineStripAdjacency, TrianglesAdjacency, TriangleStripAdjacency and Patches are accepted.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
        /// </param>
        /// <param name="indices">
        /// [length: count]
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="instancecount">
        /// Specifies the number of instances of the indexed geometry that should be drawn.
        /// </param>
        /// <param name="basevertex">
        /// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays.
        /// </param>
        /// <param name="baseinstance">
        /// Specifies the base instance for use in fetching instanced vertex attributes.
        /// </param>
        [AutoGenerated(Category = "ARB_base_instance|VERSION_4_2", Version = "4.2", EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public static void DrawElementsInstancedBaseVertexBaseInstance<T3>(OpenTK.Graphics.OpenGL.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] T3[,,] indices, int instancecount, int basevertex, uint baseinstance)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.2 or ARB_base_instance|VERSION_4_2]
        /// Render multiple instances of a set of primitives from array data with a per-element offset
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, TriangleStrip, TriangleFan, Triangles, LinesAdjacency, LineStripAdjacency, TrianglesAdjacency, TriangleStripAdjacency and Patches are accepted.
        /// </param>
        /// <param name="count">
        /// Specifies the number of elements to be rendered.
        /// </param>
        /// <param name="type">
        /// Specifies the type of the values in indices. Must be one of UnsignedByte, UnsignedShort, or UnsignedInt.
        /// </param>
        /// <param name="indices">
        /// [length: count]
        /// Specifies a pointer to the location where the indices are stored.
        /// </param>
        /// <param name="instancecount">
        /// Specifies the number of instances of the indexed geometry that should be drawn.
        /// </param>
        /// <param name="basevertex">
        /// Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays.
        /// </param>
        /// <param name="baseinstance">
        /// Specifies the base instance for use in fetching instanced vertex attributes.
        /// </param>
        [AutoGenerated(Category = "ARB_base_instance|VERSION_4_2", Version = "4.2", EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance")]
        public static void DrawElementsInstancedBaseVertexBaseInstance<T3>(OpenTK.Graphics.OpenGL.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] ref T3 indices, int instancecount, int basevertex, uint baseinstance)
            where T3 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        [Slot(479)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawArraysInstancedBaseInstance(OpenTK.Graphics.OpenGL.PrimitiveType mode, int first, int count, int instancecount, uint baseinstance);

        [Slot(496)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawElementsInstancedBaseInstance(OpenTK.Graphics.OpenGL.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL.DrawElementsType type, [CountAttribute(Parameter = "count")] IntPtr indices, int instancecount, uint baseinstance);

        [Slot(498)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawElementsInstancedBaseVertexBaseInstance(OpenTK.Graphics.OpenGL.PrimitiveType mode, int count, OpenTK.Graphics.OpenGL.DrawElementsType type, [CountAttribute(Parameter = "count")] IntPtr indices, int instancecount, int basevertex, uint baseinstance);
    }
}
