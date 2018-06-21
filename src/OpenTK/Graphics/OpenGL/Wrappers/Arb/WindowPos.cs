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
        /// Contains native bindings to functions in the category "WindowPos" in the extension "Arb".
        /// </summary>
        public static partial class Arb
        {
            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="x">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            /// <param name="y">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos2dARB")]
            public static void WindowPos2(double x, double y)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 2]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos2dvARB")]
            public static void WindowPos2([CountAttribute(Count = 2)] double[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 2]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos2dvARB")]
            public static void WindowPos2([CountAttribute(Count = 2)] ref double v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="x">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            /// <param name="y">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos2fARB")]
            public static void WindowPos2(float x, float y)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 2]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos2fvARB")]
            public static void WindowPos2([CountAttribute(Count = 2)] float[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 2]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos2fvARB")]
            public static void WindowPos2([CountAttribute(Count = 2)] ref float v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="x">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            /// <param name="y">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos2iARB")]
            public static void WindowPos2(int x, int y)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 2]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos2ivARB")]
            public static void WindowPos2([CountAttribute(Count = 2)] int[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 2]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos2ivARB")]
            public static void WindowPos2([CountAttribute(Count = 2)] ref int v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="x">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            /// <param name="y">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos2sARB")]
            public static void WindowPos2(short x, short y)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 2]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos2svARB")]
            public static void WindowPos2([CountAttribute(Count = 2)] short[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 2]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos2svARB")]
            public static void WindowPos2([CountAttribute(Count = 2)] ref short v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="x">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            /// <param name="y">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            /// <param name="z">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos3dARB")]
            public static void WindowPos3(double x, double y, double z)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos3dvARB")]
            public static void WindowPos3([CountAttribute(Count = 3)] double[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos3dvARB")]
            public static void WindowPos3([CountAttribute(Count = 3)] ref double v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="x">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            /// <param name="y">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            /// <param name="z">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos3fARB")]
            public static void WindowPos3(float x, float y, float z)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos3fvARB")]
            public static void WindowPos3([CountAttribute(Count = 3)] float[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos3fvARB")]
            public static void WindowPos3([CountAttribute(Count = 3)] ref float v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="x">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            /// <param name="y">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            /// <param name="z">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos3iARB")]
            public static void WindowPos3(int x, int y, int z)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos3ivARB")]
            public static void WindowPos3([CountAttribute(Count = 3)] int[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos3ivARB")]
            public static void WindowPos3([CountAttribute(Count = 3)] ref int v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="x">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            /// <param name="y">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            /// <param name="z">
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos3sARB")]
            public static void WindowPos3(short x, short y, short z)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos3svARB")]
            public static void WindowPos3([CountAttribute(Count = 3)] short[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_window_pos]
            /// Specify the raster position in window coordinates for pixel operations
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify the , ,  coordinates for the raster position.
            /// </param>
            [AutoGenerated(Category = "ARB_window_pos", Version = "", EntryPoint = "glWindowPos3svARB")]
            public static void WindowPos3([CountAttribute(Count = 3)] ref short v)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(2896)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glWindowPos2dARB(double x, double y);

            [Slot(2899)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glWindowPos2dvARB([CountAttribute(Count = 2)] double* v);

            [Slot(2902)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glWindowPos2fARB(float x, float y);

            [Slot(2905)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glWindowPos2fvARB([CountAttribute(Count = 2)] float* v);

            [Slot(2908)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glWindowPos2iARB(int x, int y);

            [Slot(2911)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glWindowPos2ivARB([CountAttribute(Count = 2)] int* v);

            [Slot(2914)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glWindowPos2sARB(short x, short y);

            [Slot(2917)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glWindowPos2svARB([CountAttribute(Count = 2)] short* v);

            [Slot(2920)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glWindowPos3dARB(double x, double y, double z);

            [Slot(2923)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glWindowPos3dvARB([CountAttribute(Count = 3)] double* v);

            [Slot(2926)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glWindowPos3fARB(float x, float y, float z);

            [Slot(2929)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glWindowPos3fvARB([CountAttribute(Count = 3)] float* v);

            [Slot(2932)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glWindowPos3iARB(int x, int y, int z);

            [Slot(2935)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glWindowPos3ivARB([CountAttribute(Count = 3)] int* v);

            [Slot(2938)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glWindowPos3sARB(short x, short y, short z);

            [Slot(2941)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glWindowPos3svARB([CountAttribute(Count = 3)] short* v);
        }
    }
}
