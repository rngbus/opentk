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
        /// Contains native bindings to functions in the category "BindlessTexture" in the extension "Img".
        /// </summary>
        public static partial class Img
        {
            /// <summary>
            /// [requires: IMG_bindless_texture]
            /// </summary>
            /// <param name="texture">
            /// </param>
            [AutoGenerated(Category = "IMG_bindless_texture", Version = "", EntryPoint = "glGetTextureHandleIMG")]
            public static ulong GetTextureHandle(uint texture)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: IMG_bindless_texture]
            /// </summary>
            /// <param name="texture">
            /// </param>
            /// <param name="sampler">
            /// </param>
            [AutoGenerated(Category = "IMG_bindless_texture", Version = "", EntryPoint = "glGetTextureSamplerHandleIMG")]
            public static ulong GetTextureSamplerHandle(uint texture, uint sampler)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: IMG_bindless_texture]
            /// </summary>
            /// <param name="program">
            /// </param>
            /// <param name="location">
            /// </param>
            /// <param name="value">
            /// </param>
            [AutoGenerated(Category = "IMG_bindless_texture", Version = "", EntryPoint = "glProgramUniformHandleui64IMG")]
            public static void ProgramUniformHandle(uint program, int location, ulong value)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: IMG_bindless_texture]
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
            [AutoGenerated(Category = "IMG_bindless_texture", Version = "", EntryPoint = "glProgramUniformHandleui64vIMG")]
            public static void ProgramUniformHandle(uint program, int location, int count, [CountAttribute(Parameter = "count")] ulong[] values)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: IMG_bindless_texture]
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
            [AutoGenerated(Category = "IMG_bindless_texture", Version = "", EntryPoint = "glProgramUniformHandleui64vIMG")]
            public static void ProgramUniformHandle(uint program, int location, int count, [CountAttribute(Parameter = "count")] ref ulong values)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: IMG_bindless_texture]
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
            [AutoGenerated(Category = "IMG_bindless_texture", Version = "", EntryPoint = "glProgramUniformHandleui64vIMG")]
            public static unsafe void ProgramUniformHandle(uint program, int location, int count, [CountAttribute(Parameter = "count")] ulong* values)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: IMG_bindless_texture]
            /// </summary>
            /// <param name="location">
            /// </param>
            /// <param name="value">
            /// </param>
            [AutoGenerated(Category = "IMG_bindless_texture", Version = "", EntryPoint = "glUniformHandleui64IMG")]
            public static void UniformHandle(int location, ulong value)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: IMG_bindless_texture]
            /// </summary>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="value">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "IMG_bindless_texture", Version = "", EntryPoint = "glUniformHandleui64vIMG")]
            public static void UniformHandle(int location, int count, [CountAttribute(Parameter = "count")] ulong[] value)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: IMG_bindless_texture]
            /// </summary>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="value">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "IMG_bindless_texture", Version = "", EntryPoint = "glUniformHandleui64vIMG")]
            public static void UniformHandle(int location, int count, [CountAttribute(Parameter = "count")] ref ulong value)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: IMG_bindless_texture]
            /// </summary>
            /// <param name="location">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="value">
            /// [length: count]
            /// </param>
            [AutoGenerated(Category = "IMG_bindless_texture", Version = "", EntryPoint = "glUniformHandleui64vIMG")]
            public static unsafe void UniformHandle(int location, int count, [CountAttribute(Parameter = "count")] ulong* value)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(305)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern ulong glGetTextureHandleIMG(uint texture);

            [Slot(307)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern ulong glGetTextureSamplerHandleIMG(uint texture, uint sampler);

            [Slot(476)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glProgramUniformHandleui64IMG(uint program, int location, ulong value);

            [Slot(478)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glProgramUniformHandleui64vIMG(uint program, int location, int count, [CountAttribute(Parameter = "count")] ulong* values);

            [Slot(617)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glUniformHandleui64IMG(int location, ulong value);

            [Slot(619)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glUniformHandleui64vIMG(int location, int count, [CountAttribute(Parameter = "count")] ulong* value);
        }
    }
}
