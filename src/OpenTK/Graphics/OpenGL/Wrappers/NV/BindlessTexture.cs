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
        /// Contains native bindings to functions in the category "BindlessTexture" in the extension "NV".
        /// </summary>
        public static partial class NV
        {
            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="texture">
            /// </param>
            /// <param name="level">
            /// </param>
            /// <param name="layered">
            /// </param>
            /// <param name="layer">
            /// </param>
            /// <param name="format">
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glGetImageHandleNV")]
            public static ulong GetImageHandle(uint texture, int level, bool layered, int layer, OpenTK.Graphics.OpenGL.PixelFormat format)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="texture">
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glGetTextureHandleNV")]
            public static ulong GetTextureHandle(uint texture)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="texture">
            /// </param>
            /// <param name="sampler">
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glGetTextureSamplerHandleNV")]
            public static ulong GetTextureSamplerHandle(uint texture, uint sampler)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="handle">
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glIsImageHandleResidentNV")]
            public static bool IsImageHandleResident(ulong handle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="handle">
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glIsTextureHandleResidentNV")]
            public static bool IsTextureHandleResident(ulong handle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="handle">
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glMakeImageHandleNonResidentNV")]
            public static void MakeImageHandleNonResident(ulong handle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="handle">
            /// </param>
            /// <param name="access">
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glMakeImageHandleResidentNV")]
            public static void MakeImageHandleResident(ulong handle, OpenTK.Graphics.OpenGL.NvBindlessTexture access)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="handle">
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glMakeTextureHandleNonResidentNV")]
            public static void MakeTextureHandleNonResident(ulong handle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="handle">
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glMakeTextureHandleResidentNV")]
            public static void MakeTextureHandleResident(ulong handle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="program">
            /// </param>
            /// <param name="location">
            /// </param>
            /// <param name="value">
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glProgramUniformHandleui64NV")]
            public static void ProgramUniformHandle(uint program, int location, ulong value)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="program">
            /// </param>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="values">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glProgramUniformHandleui64vNV")]
            public static void ProgramUniformHandle(uint program, int location, int count, [CountAttribute(Parameter = "count")] ulong[] values)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="program">
            /// </param>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="values">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glProgramUniformHandleui64vNV")]
            public static void ProgramUniformHandle(uint program, int location, int count, [CountAttribute(Parameter = "count")] ref ulong values)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="program">
            /// </param>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="values">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glProgramUniformHandleui64vNV")]
            public static unsafe void ProgramUniformHandle(uint program, int location, int count, [CountAttribute(Parameter = "count")] ulong* values)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="location">
            /// </param>
            /// <param name="value">
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glUniformHandleui64NV")]
            public static void UniformHandle(int location, ulong value)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="value">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glUniformHandleui64vNV")]
            public static void UniformHandle(int location, int count, [CountAttribute(Parameter = "count")] ulong[] value)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="value">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glUniformHandleui64vNV")]
            public static void UniformHandle(int location, int count, [CountAttribute(Parameter = "count")] ref ulong value)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_bindless_texture]
            /// </summary>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="value">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "NV_bindless_texture", Version = "", EntryPoint = "glUniformHandleui64vNV")]
            public static unsafe void UniformHandle(int location, int count, [CountAttribute(Parameter = "count")] ulong* value)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(801)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern ulong glGetImageHandleNV(uint texture, int level, bool layered, int layer, OpenTK.Graphics.OpenGL.PixelFormat format);

            [Slot(1067)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern ulong glGetTextureHandleNV(uint texture);

            [Slot(1083)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern ulong glGetTextureSamplerHandleNV(uint texture, uint sampler);

            [Slot(1228)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern byte glIsImageHandleResidentNV(ulong handle);

            [Slot(1256)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern byte glIsTextureHandleResidentNV(ulong handle);

            [Slot(1308)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMakeImageHandleNonResidentNV(ulong handle);

            [Slot(1310)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMakeImageHandleResidentNV(ulong handle, OpenTK.Graphics.OpenGL.NvBindlessTexture access);

            [Slot(1314)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMakeTextureHandleNonResidentNV(ulong handle);

            [Slot(1316)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMakeTextureHandleResidentNV(ulong handle);

            [Slot(1876)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glProgramUniformHandleui64NV(uint program, int location, ulong value);

            [Slot(1878)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glProgramUniformHandleui64vNV(uint program, int location, int count, [CountAttribute(Parameter = "count")] ulong* values);

            [Slot(2461)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glUniformHandleui64NV(int location, ulong value);

            [Slot(2463)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glUniformHandleui64vNV(int location, int count, [CountAttribute(Parameter = "count")] ulong* value);
        }
    }
}
