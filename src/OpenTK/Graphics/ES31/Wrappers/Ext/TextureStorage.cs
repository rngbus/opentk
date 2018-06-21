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

namespace OpenTK.Graphics.ES31
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "TextureStorage" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: EXT_texture_storage]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="levels">
            /// </param>
            /// <param name="internalformat">
            /// </param>
            /// <param name="width">
            /// </param>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTexStorage1DEXT")]
            public static void TexStorage1D(OpenTK.Graphics.ES31.TextureTarget target, int levels, OpenTK.Graphics.ES31.InternalFormat internalformat, int width)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_storage]
            /// Simultaneously specify storage for all levels of a two-dimensional texture
            /// </summary>
            /// <param name="target">
            /// Specify the target of the operation. target must be one of Texture2D, or TextureCubeMap.
            /// </param>
            /// <param name="levels">
            /// Specify the number of texture levels.
            /// </param>
            /// <param name="internalformat">
            /// Specifies the sized internal format to be used to store texture image data.
            /// </param>
            /// <param name="width">
            /// Specifies the width of the texture, in texels.
            /// </param>
            /// <param name="height">
            /// Specifies the height of the texture, in texels.
            /// </param>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTexStorage2DEXT")]
            public static void TexStorage2D(OpenTK.Graphics.ES31.TextureTarget target, int levels, OpenTK.Graphics.ES31.InternalFormat internalformat, int width, int height)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_storage]
            /// Simultaneously specify storage for all levels of a three-dimensional or two-dimensional array texture
            /// </summary>
            /// <param name="target">
            /// Specify the target of the operation. target must be one of Texture3D, or Texture2DArray.
            /// </param>
            /// <param name="levels">
            /// Specify the number of texture levels.
            /// </param>
            /// <param name="internalformat">
            /// Specifies the sized internal format to be used to store texture image data.
            /// </param>
            /// <param name="width">
            /// Specifies the width of the texture, in texels.
            /// </param>
            /// <param name="height">
            /// Specifies the height of the texture, in texels.
            /// </param>
            /// <param name="depth">
            /// Specifies the depth of the texture, in texels.
            /// </param>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTexStorage3DEXT")]
            public static void TexStorage3D(OpenTK.Graphics.ES31.TextureTarget target, int levels, OpenTK.Graphics.ES31.InternalFormat internalformat, int width, int height, int depth)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_storage]
            /// </summary>
            /// <param name="texture">
            /// </param>
            /// <param name="target">
            /// </param>
            /// <param name="levels">
            /// </param>
            /// <param name="internalformat">
            /// </param>
            /// <param name="width">
            /// </param>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage1DEXT")]
            public static void TextureStorage1D(uint texture, OpenTK.Graphics.ES31.ExtTextureStorage target, int levels, OpenTK.Graphics.ES31.InternalFormat internalformat, int width)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_storage]
            /// </summary>
            /// <param name="texture">
            /// </param>
            /// <param name="target">
            /// </param>
            /// <param name="levels">
            /// </param>
            /// <param name="internalformat">
            /// </param>
            /// <param name="width">
            /// </param>
            /// <param name="height">
            /// </param>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage2DEXT")]
            public static void TextureStorage2D(uint texture, OpenTK.Graphics.ES31.ExtTextureStorage target, int levels, OpenTK.Graphics.ES31.InternalFormat internalformat, int width, int height)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture_storage]
            /// </summary>
            /// <param name="texture">
            /// </param>
            /// <param name="target">
            /// </param>
            /// <param name="levels">
            /// </param>
            /// <param name="internalformat">
            /// </param>
            /// <param name="width">
            /// </param>
            /// <param name="height">
            /// </param>
            /// <param name="depth">
            /// </param>
            [AutoGenerated(Category = "EXT_texture_storage", Version = "", EntryPoint = "glTextureStorage3DEXT")]
            public static void TextureStorage3D(uint texture, OpenTK.Graphics.ES31.ExtTextureStorage target, int levels, OpenTK.Graphics.ES31.InternalFormat internalformat, int width, int height, int depth)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(700)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glTexStorage1DEXT(OpenTK.Graphics.ES31.TextureTarget target, int levels, OpenTK.Graphics.ES31.InternalFormat internalformat, int width);

            [Slot(702)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glTexStorage2DEXT(OpenTK.Graphics.ES31.TextureTarget target, int levels, OpenTK.Graphics.ES31.InternalFormat internalformat, int width, int height);

            [Slot(705)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glTexStorage3DEXT(OpenTK.Graphics.ES31.TextureTarget target, int levels, OpenTK.Graphics.ES31.InternalFormat internalformat, int width, int height, int depth);

            [Slot(716)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glTextureStorage1DEXT(uint texture, OpenTK.Graphics.ES31.ExtTextureStorage target, int levels, OpenTK.Graphics.ES31.InternalFormat internalformat, int width);

            [Slot(717)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glTextureStorage2DEXT(uint texture, OpenTK.Graphics.ES31.ExtTextureStorage target, int levels, OpenTK.Graphics.ES31.InternalFormat internalformat, int width, int height);

            [Slot(718)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glTextureStorage3DEXT(uint texture, OpenTK.Graphics.ES31.ExtTextureStorage target, int levels, OpenTK.Graphics.ES31.InternalFormat internalformat, int width, int height, int depth);
        }
    }
}
