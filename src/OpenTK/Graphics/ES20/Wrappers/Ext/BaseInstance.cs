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
        /// Contains native bindings to functions in the category "BaseInstance" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: EXT_base_instance]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="first">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="baseinstance">
            /// </param>
            [AutoGenerated(Category = "EXT_base_instance", Version = "", EntryPoint = "glDrawArraysInstancedBaseInstanceEXT")]
            public static void DrawArraysInstancedBaseInstance(OpenTK.Graphics.ES20.PrimitiveType mode, int first, int count, int instancecount, uint baseinstance)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_base_instance]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: count]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="baseinstance">
            /// </param>
            [AutoGenerated(Category = "EXT_base_instance", Version = "", EntryPoint = "glDrawElementsInstancedBaseInstanceEXT")]
            public static void DrawElementsInstancedBaseInstance(OpenTK.Graphics.ES20.PrimitiveType mode, int count, OpenTK.Graphics.ES20.PrimitiveType type, [CountAttribute(Parameter = "count")] IntPtr indices, int instancecount, uint baseinstance)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_base_instance]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: count]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="baseinstance">
            /// </param>
            [AutoGenerated(Category = "EXT_base_instance", Version = "", EntryPoint = "glDrawElementsInstancedBaseInstanceEXT")]
            public static void DrawElementsInstancedBaseInstance<T3>(OpenTK.Graphics.ES20.PrimitiveType mode, int count, OpenTK.Graphics.ES20.PrimitiveType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] T3[] indices, int instancecount, uint baseinstance)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_base_instance]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: count]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="baseinstance">
            /// </param>
            [AutoGenerated(Category = "EXT_base_instance", Version = "", EntryPoint = "glDrawElementsInstancedBaseInstanceEXT")]
            public static void DrawElementsInstancedBaseInstance<T3>(OpenTK.Graphics.ES20.PrimitiveType mode, int count, OpenTK.Graphics.ES20.PrimitiveType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] T3[,] indices, int instancecount, uint baseinstance)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_base_instance]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: count]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="baseinstance">
            /// </param>
            [AutoGenerated(Category = "EXT_base_instance", Version = "", EntryPoint = "glDrawElementsInstancedBaseInstanceEXT")]
            public static void DrawElementsInstancedBaseInstance<T3>(OpenTK.Graphics.ES20.PrimitiveType mode, int count, OpenTK.Graphics.ES20.PrimitiveType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] T3[,,] indices, int instancecount, uint baseinstance)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_base_instance]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: count]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="baseinstance">
            /// </param>
            [AutoGenerated(Category = "EXT_base_instance", Version = "", EntryPoint = "glDrawElementsInstancedBaseInstanceEXT")]
            public static void DrawElementsInstancedBaseInstance<T3>(OpenTK.Graphics.ES20.PrimitiveType mode, int count, OpenTK.Graphics.ES20.PrimitiveType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] ref T3 indices, int instancecount, uint baseinstance)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_base_instance]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: count]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="basevertex">
            /// </param>
            /// <param name="baseinstance">
            /// </param>
            [AutoGenerated(Category = "EXT_base_instance", Version = "", EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
            public static void DrawElementsInstancedBaseVertexBaseInstance(OpenTK.Graphics.ES20.PrimitiveType mode, int count, OpenTK.Graphics.ES20.PrimitiveType type, [CountAttribute(Parameter = "count")] IntPtr indices, int instancecount, int basevertex, uint baseinstance)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_base_instance]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: count]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="basevertex">
            /// </param>
            /// <param name="baseinstance">
            /// </param>
            [AutoGenerated(Category = "EXT_base_instance", Version = "", EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
            public static void DrawElementsInstancedBaseVertexBaseInstance<T3>(OpenTK.Graphics.ES20.PrimitiveType mode, int count, OpenTK.Graphics.ES20.PrimitiveType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] T3[] indices, int instancecount, int basevertex, uint baseinstance)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_base_instance]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: count]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="basevertex">
            /// </param>
            /// <param name="baseinstance">
            /// </param>
            [AutoGenerated(Category = "EXT_base_instance", Version = "", EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
            public static void DrawElementsInstancedBaseVertexBaseInstance<T3>(OpenTK.Graphics.ES20.PrimitiveType mode, int count, OpenTK.Graphics.ES20.PrimitiveType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] T3[,] indices, int instancecount, int basevertex, uint baseinstance)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_base_instance]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: count]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="basevertex">
            /// </param>
            /// <param name="baseinstance">
            /// </param>
            [AutoGenerated(Category = "EXT_base_instance", Version = "", EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
            public static void DrawElementsInstancedBaseVertexBaseInstance<T3>(OpenTK.Graphics.ES20.PrimitiveType mode, int count, OpenTK.Graphics.ES20.PrimitiveType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] T3[,,] indices, int instancecount, int basevertex, uint baseinstance)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_base_instance]
            /// </summary>
            /// <param name="mode">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="indices">
            /// [length: count]
            /// </param>
            /// <param name="instancecount">
            /// </param>
            /// <param name="basevertex">
            /// </param>
            /// <param name="baseinstance">
            /// </param>
            [AutoGenerated(Category = "EXT_base_instance", Version = "", EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstanceEXT")]
            public static void DrawElementsInstancedBaseVertexBaseInstance<T3>(OpenTK.Graphics.ES20.PrimitiveType mode, int count, OpenTK.Graphics.ES20.PrimitiveType type, [InAttribute, OutAttribute, CountAttribute(Parameter = "count")] ref T3 indices, int instancecount, int basevertex, uint baseinstance)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(125)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDrawArraysInstancedBaseInstanceEXT(OpenTK.Graphics.ES20.PrimitiveType mode, int first, int count, int instancecount, uint baseinstance);

            [Slot(135)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDrawElementsInstancedBaseInstanceEXT(OpenTK.Graphics.ES20.PrimitiveType mode, int count, OpenTK.Graphics.ES20.PrimitiveType type, [CountAttribute(Parameter = "count")] IntPtr indices, int instancecount, uint baseinstance);

            [Slot(136)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDrawElementsInstancedBaseVertexBaseInstanceEXT(OpenTK.Graphics.ES20.PrimitiveType mode, int count, OpenTK.Graphics.ES20.PrimitiveType type, [CountAttribute(Parameter = "count")] IntPtr indices, int instancecount, int basevertex, uint baseinstance);
        }
    }
}
