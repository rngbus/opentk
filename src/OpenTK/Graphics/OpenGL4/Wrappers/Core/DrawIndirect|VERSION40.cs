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

namespace OpenTK.Graphics.OpenGL4
{
    public sealed partial class GL
    {
        /// <summary>
        /// [requires: v4.0 or ARB_draw_indirect|VERSION_4_0]
        /// Render primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="indirect">
        /// Specifies the address of a structure containing the draw parameters.
        /// </param>
        [AutoGenerated(Category = "ARB_draw_indirect|VERSION_4_0", Version = "4.0", EntryPoint = "glDrawArraysIndirect")]
        public static void DrawArraysIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, IntPtr indirect)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_draw_indirect|VERSION_4_0]
        /// Render primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="indirect">
        /// Specifies the address of a structure containing the draw parameters.
        /// </param>
        [AutoGenerated(Category = "ARB_draw_indirect|VERSION_4_0", Version = "4.0", EntryPoint = "glDrawArraysIndirect")]
        public static void DrawArraysIndirect<T1>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, [InAttribute, OutAttribute] T1[] indirect)
            where T1 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_draw_indirect|VERSION_4_0]
        /// Render primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="indirect">
        /// Specifies the address of a structure containing the draw parameters.
        /// </param>
        [AutoGenerated(Category = "ARB_draw_indirect|VERSION_4_0", Version = "4.0", EntryPoint = "glDrawArraysIndirect")]
        public static void DrawArraysIndirect<T1>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, [InAttribute, OutAttribute] T1[,] indirect)
            where T1 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_draw_indirect|VERSION_4_0]
        /// Render primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="indirect">
        /// Specifies the address of a structure containing the draw parameters.
        /// </param>
        [AutoGenerated(Category = "ARB_draw_indirect|VERSION_4_0", Version = "4.0", EntryPoint = "glDrawArraysIndirect")]
        public static void DrawArraysIndirect<T1>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, [InAttribute, OutAttribute] T1[,,] indirect)
            where T1 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_draw_indirect|VERSION_4_0]
        /// Render primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="indirect">
        /// Specifies the address of a structure containing the draw parameters.
        /// </param>
        [AutoGenerated(Category = "ARB_draw_indirect|VERSION_4_0", Version = "4.0", EntryPoint = "glDrawArraysIndirect")]
        public static void DrawArraysIndirect<T1>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, [InAttribute, OutAttribute] ref T1 indirect)
            where T1 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_draw_indirect|VERSION_4_0]
        /// Render indexed primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="type">
        /// Specifies the type of data in the buffer bound to the ElementArrayBuffer binding.
        /// </param>
        /// <param name="indirect">
        /// Specifies the address of a structure containing the draw parameters.
        /// </param>
        [AutoGenerated(Category = "ARB_draw_indirect|VERSION_4_0", Version = "4.0", EntryPoint = "glDrawElementsIndirect")]
        public static void DrawElementsIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indirect)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_draw_indirect|VERSION_4_0]
        /// Render indexed primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="type">
        /// Specifies the type of data in the buffer bound to the ElementArrayBuffer binding.
        /// </param>
        /// <param name="indirect">
        /// Specifies the address of a structure containing the draw parameters.
        /// </param>
        [AutoGenerated(Category = "ARB_draw_indirect|VERSION_4_0", Version = "4.0", EntryPoint = "glDrawElementsIndirect")]
        public static void DrawElementsIndirect<T2>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute] T2[] indirect)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_draw_indirect|VERSION_4_0]
        /// Render indexed primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="type">
        /// Specifies the type of data in the buffer bound to the ElementArrayBuffer binding.
        /// </param>
        /// <param name="indirect">
        /// Specifies the address of a structure containing the draw parameters.
        /// </param>
        [AutoGenerated(Category = "ARB_draw_indirect|VERSION_4_0", Version = "4.0", EntryPoint = "glDrawElementsIndirect")]
        public static void DrawElementsIndirect<T2>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute] T2[,] indirect)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_draw_indirect|VERSION_4_0]
        /// Render indexed primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="type">
        /// Specifies the type of data in the buffer bound to the ElementArrayBuffer binding.
        /// </param>
        /// <param name="indirect">
        /// Specifies the address of a structure containing the draw parameters.
        /// </param>
        [AutoGenerated(Category = "ARB_draw_indirect|VERSION_4_0", Version = "4.0", EntryPoint = "glDrawElementsIndirect")]
        public static void DrawElementsIndirect<T2>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute] T2[,,] indirect)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_draw_indirect|VERSION_4_0]
        /// Render indexed primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="type">
        /// Specifies the type of data in the buffer bound to the ElementArrayBuffer binding.
        /// </param>
        /// <param name="indirect">
        /// Specifies the address of a structure containing the draw parameters.
        /// </param>
        [AutoGenerated(Category = "ARB_draw_indirect|VERSION_4_0", Version = "4.0", EntryPoint = "glDrawElementsIndirect")]
        public static void DrawElementsIndirect<T2>(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, [InAttribute, OutAttribute] ref T2 indirect)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        [Slot(232)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawArraysIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, IntPtr indirect);

        [Slot(245)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawElementsIndirect(OpenTK.Graphics.OpenGL4.PrimitiveType mode, OpenTK.Graphics.OpenGL4.DrawElementsType type, IntPtr indirect);
    }
}
