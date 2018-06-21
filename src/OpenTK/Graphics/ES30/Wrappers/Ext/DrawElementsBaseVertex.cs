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

namespace OpenTK.Graphics.ES30
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "DrawElementsBaseVertex" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawElementsBaseVertexEXT")]
            public static void DrawElementsBaseVertex(OpenTK.Graphics.ES30.PrimitiveType mode, int count, OpenTK.Graphics.ES30.DrawElementsType type, [CountAttribute(Computed = "count,type")] IntPtr indices, int basevertex)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawElementsBaseVertexEXT")]
            public static void DrawElementsBaseVertex<T3>(OpenTK.Graphics.ES30.PrimitiveType mode, int count, OpenTK.Graphics.ES30.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] T3[] indices, int basevertex)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawElementsBaseVertexEXT")]
            public static void DrawElementsBaseVertex<T3>(OpenTK.Graphics.ES30.PrimitiveType mode, int count, OpenTK.Graphics.ES30.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] T3[,] indices, int basevertex)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawElementsBaseVertexEXT")]
            public static void DrawElementsBaseVertex<T3>(OpenTK.Graphics.ES30.PrimitiveType mode, int count, OpenTK.Graphics.ES30.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] T3[,,] indices, int basevertex)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawElementsBaseVertexEXT")]
            public static void DrawElementsBaseVertex<T3>(OpenTK.Graphics.ES30.PrimitiveType mode, int count, OpenTK.Graphics.ES30.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] ref T3 indices, int basevertex)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
            public static void DrawElementsInstancedBaseVertex(OpenTK.Graphics.ES30.PrimitiveType mode, int count, OpenTK.Graphics.ES30.DrawElementsType type, [CountAttribute(Computed = "count,type")] IntPtr indices, int instancecount, int basevertex)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
            public static void DrawElementsInstancedBaseVertex<T3>(OpenTK.Graphics.ES30.PrimitiveType mode, int count, OpenTK.Graphics.ES30.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] T3[] indices, int instancecount, int basevertex)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
            public static void DrawElementsInstancedBaseVertex<T3>(OpenTK.Graphics.ES30.PrimitiveType mode, int count, OpenTK.Graphics.ES30.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] T3[,] indices, int instancecount, int basevertex)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
            public static void DrawElementsInstancedBaseVertex<T3>(OpenTK.Graphics.ES30.PrimitiveType mode, int count, OpenTK.Graphics.ES30.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] T3[,,] indices, int instancecount, int basevertex)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
            public static void DrawElementsInstancedBaseVertex<T3>(OpenTK.Graphics.ES30.PrimitiveType mode, int count, OpenTK.Graphics.ES30.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] ref T3 indices, int instancecount, int basevertex)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="end">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
            public static void DrawRangeElementsBaseVertex(OpenTK.Graphics.ES30.PrimitiveType mode, uint start, uint end, int count, OpenTK.Graphics.ES30.DrawElementsType type, [CountAttribute(Computed = "count,type")] IntPtr indices, int basevertex)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="end">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
            public static void DrawRangeElementsBaseVertex<T5>(OpenTK.Graphics.ES30.PrimitiveType mode, uint start, uint end, int count, OpenTK.Graphics.ES30.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] T5[] indices, int basevertex)
                where T5 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="end">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
            public static void DrawRangeElementsBaseVertex<T5>(OpenTK.Graphics.ES30.PrimitiveType mode, uint start, uint end, int count, OpenTK.Graphics.ES30.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] T5[,] indices, int basevertex)
                where T5 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="end">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
            public static void DrawRangeElementsBaseVertex<T5>(OpenTK.Graphics.ES30.PrimitiveType mode, uint start, uint end, int count, OpenTK.Graphics.ES30.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] T5[,,] indices, int basevertex)
                where T5 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_draw_elements_base_vertex]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="end">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: COMPSIZE(count,type)]
            /// </param>
            /// <param name="basevertex">
            /// </param>
            [AutoGenerated(Category = "EXT_draw_elements_base_vertex", Version = "", EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
            public static void DrawRangeElementsBaseVertex<T5>(OpenTK.Graphics.ES30.PrimitiveType mode, uint start, uint end, int count, OpenTK.Graphics.ES30.DrawElementsType type, [InAttribute, OutAttribute, CountAttribute(Computed = "count,type")] ref T5 indices, int basevertex)
                where T5 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(156)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDrawElementsBaseVertexEXT(OpenTK.Graphics.ES30.PrimitiveType mode, int count, OpenTK.Graphics.ES30.DrawElementsType type, [CountAttribute(Computed = "count,type")] IntPtr indices, int basevertex);

            [Slot(162)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDrawElementsInstancedBaseVertexEXT(OpenTK.Graphics.ES30.PrimitiveType mode, int count, OpenTK.Graphics.ES30.DrawElementsType type, [CountAttribute(Computed = "count,type")] IntPtr indices, int instancecount, int basevertex);

            [Slot(167)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDrawRangeElementsBaseVertexEXT(OpenTK.Graphics.ES30.PrimitiveType mode, uint start, uint end, int count, OpenTK.Graphics.ES30.DrawElementsType type, [CountAttribute(Computed = "count,type")] IntPtr indices, int basevertex);
        }
    }
}
