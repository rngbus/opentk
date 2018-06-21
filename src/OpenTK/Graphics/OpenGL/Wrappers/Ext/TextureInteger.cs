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
        /// Contains native bindings to functions in the category "TextureInteger" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: EXT_texture_integer]
            /// </summary>
            /// <param name="red">
            /// </param>
            /// <param name="green">
            /// </param>
            /// <param name="blue">
            /// </param>
            /// <param name="alpha">
            /// </param>
            [AutoGenerated(Category = "EXT_texture_integer", Version = "", EntryPoint = "glClearColorIiEXT")]
            public static void ClearColorI(int red, int green, int blue, int alpha)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_integer]
            /// </summary>
            /// <param name="red">
            /// </param>
            /// <param name="green">
            /// </param>
            /// <param name="blue">
            /// </param>
            /// <param name="alpha">
            /// </param>
            [AutoGenerated(Category = "EXT_texture_integer", Version = "", EntryPoint = "glClearColorIuiEXT")]
            public static void ClearColorI(uint red, uint green, uint blue, uint alpha)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_integer]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_texture_integer", Version = "", EntryPoint = "glGetTexParameterIivEXT")]
            public static void GetTexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_integer]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_texture_integer", Version = "", EntryPoint = "glGetTexParameterIivEXT")]
            public static void GetTexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] out int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_integer]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_texture_integer", Version = "", EntryPoint = "glGetTexParameterIivEXT")]
            public static unsafe void GetTexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_integer]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_texture_integer", Version = "", EntryPoint = "glGetTexParameterIuivEXT")]
            public static void GetTexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] uint[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_integer]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_texture_integer", Version = "", EntryPoint = "glGetTexParameterIuivEXT")]
            public static void GetTexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] out uint @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_integer]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_texture_integer", Version = "", EntryPoint = "glGetTexParameterIuivEXT")]
            public static unsafe void GetTexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] uint* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_integer]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_texture_integer", Version = "", EntryPoint = "glTexParameterIivEXT")]
            public static void TexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, [CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_integer]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_texture_integer", Version = "", EntryPoint = "glTexParameterIivEXT")]
            public static void TexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, [CountAttribute(Computed = "pname")] ref int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_integer]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_texture_integer", Version = "", EntryPoint = "glTexParameterIivEXT")]
            public static unsafe void TexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, [CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_integer]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_texture_integer", Version = "", EntryPoint = "glTexParameterIuivEXT")]
            public static void TexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, [CountAttribute(Computed = "pname")] uint[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_integer]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_texture_integer", Version = "", EntryPoint = "glTexParameterIuivEXT")]
            public static void TexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, [CountAttribute(Computed = "pname")] ref uint @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_integer]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_texture_integer", Version = "", EntryPoint = "glTexParameterIuivEXT")]
            public static unsafe void TexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, [CountAttribute(Computed = "pname")] uint* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(164)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glClearColorIiEXT(int red, int green, int blue, int alpha);

            [Slot(165)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glClearColorIuiEXT(uint red, uint green, uint blue, uint alpha);

            [Slot(1060)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetTexParameterIivEXT(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params);

            [Slot(1062)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetTexParameterIuivEXT(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] uint* @params);

            [Slot(2278)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glTexParameterIivEXT(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, [CountAttribute(Computed = "pname")] int* @params);

            [Slot(2280)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glTexParameterIuivEXT(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, [CountAttribute(Computed = "pname")] uint* @params);
        }
    }
}
