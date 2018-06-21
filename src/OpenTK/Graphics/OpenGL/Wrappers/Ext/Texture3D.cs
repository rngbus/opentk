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
        /// Contains native bindings to functions in the category "Texture3D" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: EXT_texture3D]
            /// Specify a three-dimensional texture image
            /// </summary>
            /// <param name="target">
            /// Specifies the target texture. Must be one of Texture3D, ProxyTexture3D, Texture2DArray or ProxyTexture2DArray.
            /// </param>
            /// <param name="level">
            /// Specifies the level-of-detail number. Level 0 is the base image level. Level  is the n sup th mipmap reduction image.
            /// </param>
            /// <param name="internalformat">
            /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
            /// </param>
            /// <param name="width">
            /// Specifies the width of the texture image. All implementations support 3D texture images that are at least 16 texels wide.
            /// </param>
            /// <param name="height">
            /// Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high.
            /// </param>
            /// <param name="depth">
            /// Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep.
            /// </param>
            /// <param name="border">
            /// This value must be 0.
            /// </param>
            /// <param name="format">
            /// Specifies the format of the pixel data. The following symbolic values are accepted: Red, Rg, Rgb, Bgr, Rgba, Bgra, RedInteger, RgInteger, RgbInteger, BgrInteger, RgbaInteger, BgraInteger, StencilIndex, DepthComponent, DepthStencil.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="pixels">
            /// [length: COMPSIZE(format,type,width,height,depth)]
            /// Specifies a pointer to the image data in memory.
            /// </param>
            [AutoGenerated(Category = "EXT_texture3D", Version = "", EntryPoint = "glTexImage3DEXT")]
            public static void TexImage3D(OpenTK.Graphics.OpenGL.TextureTarget target, int level, OpenTK.Graphics.OpenGL.InternalFormat internalformat, int width, int height, int depth, int border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [CountAttribute(Computed = "format,type,width,height,depth")] IntPtr pixels)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture3D]
            /// Specify a three-dimensional texture image
            /// </summary>
            /// <param name="target">
            /// Specifies the target texture. Must be one of Texture3D, ProxyTexture3D, Texture2DArray or ProxyTexture2DArray.
            /// </param>
            /// <param name="level">
            /// Specifies the level-of-detail number. Level 0 is the base image level. Level  is the n sup th mipmap reduction image.
            /// </param>
            /// <param name="internalformat">
            /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
            /// </param>
            /// <param name="width">
            /// Specifies the width of the texture image. All implementations support 3D texture images that are at least 16 texels wide.
            /// </param>
            /// <param name="height">
            /// Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high.
            /// </param>
            /// <param name="depth">
            /// Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep.
            /// </param>
            /// <param name="border">
            /// This value must be 0.
            /// </param>
            /// <param name="format">
            /// Specifies the format of the pixel data. The following symbolic values are accepted: Red, Rg, Rgb, Bgr, Rgba, Bgra, RedInteger, RgInteger, RgbInteger, BgrInteger, RgbaInteger, BgraInteger, StencilIndex, DepthComponent, DepthStencil.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="pixels">
            /// [length: COMPSIZE(format,type,width,height,depth)]
            /// Specifies a pointer to the image data in memory.
            /// </param>
            [AutoGenerated(Category = "EXT_texture3D", Version = "", EntryPoint = "glTexImage3DEXT")]
            public static void TexImage3D<T9>(OpenTK.Graphics.OpenGL.TextureTarget target, int level, OpenTK.Graphics.OpenGL.InternalFormat internalformat, int width, int height, int depth, int border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type,width,height,depth")] T9[] pixels)
                where T9 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture3D]
            /// Specify a three-dimensional texture image
            /// </summary>
            /// <param name="target">
            /// Specifies the target texture. Must be one of Texture3D, ProxyTexture3D, Texture2DArray or ProxyTexture2DArray.
            /// </param>
            /// <param name="level">
            /// Specifies the level-of-detail number. Level 0 is the base image level. Level  is the n sup th mipmap reduction image.
            /// </param>
            /// <param name="internalformat">
            /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
            /// </param>
            /// <param name="width">
            /// Specifies the width of the texture image. All implementations support 3D texture images that are at least 16 texels wide.
            /// </param>
            /// <param name="height">
            /// Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high.
            /// </param>
            /// <param name="depth">
            /// Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep.
            /// </param>
            /// <param name="border">
            /// This value must be 0.
            /// </param>
            /// <param name="format">
            /// Specifies the format of the pixel data. The following symbolic values are accepted: Red, Rg, Rgb, Bgr, Rgba, Bgra, RedInteger, RgInteger, RgbInteger, BgrInteger, RgbaInteger, BgraInteger, StencilIndex, DepthComponent, DepthStencil.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="pixels">
            /// [length: COMPSIZE(format,type,width,height,depth)]
            /// Specifies a pointer to the image data in memory.
            /// </param>
            [AutoGenerated(Category = "EXT_texture3D", Version = "", EntryPoint = "glTexImage3DEXT")]
            public static void TexImage3D<T9>(OpenTK.Graphics.OpenGL.TextureTarget target, int level, OpenTK.Graphics.OpenGL.InternalFormat internalformat, int width, int height, int depth, int border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type,width,height,depth")] T9[,] pixels)
                where T9 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture3D]
            /// Specify a three-dimensional texture image
            /// </summary>
            /// <param name="target">
            /// Specifies the target texture. Must be one of Texture3D, ProxyTexture3D, Texture2DArray or ProxyTexture2DArray.
            /// </param>
            /// <param name="level">
            /// Specifies the level-of-detail number. Level 0 is the base image level. Level  is the n sup th mipmap reduction image.
            /// </param>
            /// <param name="internalformat">
            /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
            /// </param>
            /// <param name="width">
            /// Specifies the width of the texture image. All implementations support 3D texture images that are at least 16 texels wide.
            /// </param>
            /// <param name="height">
            /// Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high.
            /// </param>
            /// <param name="depth">
            /// Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep.
            /// </param>
            /// <param name="border">
            /// This value must be 0.
            /// </param>
            /// <param name="format">
            /// Specifies the format of the pixel data. The following symbolic values are accepted: Red, Rg, Rgb, Bgr, Rgba, Bgra, RedInteger, RgInteger, RgbInteger, BgrInteger, RgbaInteger, BgraInteger, StencilIndex, DepthComponent, DepthStencil.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="pixels">
            /// [length: COMPSIZE(format,type,width,height,depth)]
            /// Specifies a pointer to the image data in memory.
            /// </param>
            [AutoGenerated(Category = "EXT_texture3D", Version = "", EntryPoint = "glTexImage3DEXT")]
            public static void TexImage3D<T9>(OpenTK.Graphics.OpenGL.TextureTarget target, int level, OpenTK.Graphics.OpenGL.InternalFormat internalformat, int width, int height, int depth, int border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type,width,height,depth")] T9[,,] pixels)
                where T9 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture3D]
            /// Specify a three-dimensional texture image
            /// </summary>
            /// <param name="target">
            /// Specifies the target texture. Must be one of Texture3D, ProxyTexture3D, Texture2DArray or ProxyTexture2DArray.
            /// </param>
            /// <param name="level">
            /// Specifies the level-of-detail number. Level 0 is the base image level. Level  is the n sup th mipmap reduction image.
            /// </param>
            /// <param name="internalformat">
            /// Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.
            /// </param>
            /// <param name="width">
            /// Specifies the width of the texture image. All implementations support 3D texture images that are at least 16 texels wide.
            /// </param>
            /// <param name="height">
            /// Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high.
            /// </param>
            /// <param name="depth">
            /// Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep.
            /// </param>
            /// <param name="border">
            /// This value must be 0.
            /// </param>
            /// <param name="format">
            /// Specifies the format of the pixel data. The following symbolic values are accepted: Red, Rg, Rgb, Bgr, Rgba, Bgra, RedInteger, RgInteger, RgbInteger, BgrInteger, RgbaInteger, BgraInteger, StencilIndex, DepthComponent, DepthStencil.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="pixels">
            /// [length: COMPSIZE(format,type,width,height,depth)]
            /// Specifies a pointer to the image data in memory.
            /// </param>
            [AutoGenerated(Category = "EXT_texture3D", Version = "", EntryPoint = "glTexImage3DEXT")]
            public static void TexImage3D<T9>(OpenTK.Graphics.OpenGL.TextureTarget target, int level, OpenTK.Graphics.OpenGL.InternalFormat internalformat, int width, int height, int depth, int border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type,width,height,depth")] ref T9 pixels)
                where T9 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture3D]
            /// Specify a three-dimensional texture subimage
            /// </summary>
            /// <param name="target">
            /// Specifies the target texture. Must be Texture3D or Texture2DArray.
            /// </param>
            /// <param name="level">
            /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
            /// </param>
            /// <param name="xoffset">
            /// Specifies a texel offset in the x direction within the texture array.
            /// </param>
            /// <param name="yoffset">
            /// Specifies a texel offset in the y direction within the texture array.
            /// </param>
            /// <param name="zoffset">
            /// Specifies a texel offset in the z direction within the texture array.
            /// </param>
            /// <param name="width">
            /// Specifies the width of the texture subimage.
            /// </param>
            /// <param name="height">
            /// Specifies the height of the texture subimage.
            /// </param>
            /// <param name="depth">
            /// Specifies the depth of the texture subimage.
            /// </param>
            /// <param name="format">
            /// Specifies the format of the pixel data. The following symbolic values are accepted: Red, Rg, Rgb, Bgr, Rgba, DepthComponent, and StencilIndex.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="pixels">
            /// [length: COMPSIZE(format,type,width,height,depth)]
            /// Specifies a pointer to the image data in memory.
            /// </param>
            [AutoGenerated(Category = "EXT_texture3D", Version = "", EntryPoint = "glTexSubImage3DEXT")]
            public static void TexSubImage3D(OpenTK.Graphics.OpenGL.TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [CountAttribute(Computed = "format,type,width,height,depth")] IntPtr pixels)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture3D]
            /// Specify a three-dimensional texture subimage
            /// </summary>
            /// <param name="target">
            /// Specifies the target texture. Must be Texture3D or Texture2DArray.
            /// </param>
            /// <param name="level">
            /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
            /// </param>
            /// <param name="xoffset">
            /// Specifies a texel offset in the x direction within the texture array.
            /// </param>
            /// <param name="yoffset">
            /// Specifies a texel offset in the y direction within the texture array.
            /// </param>
            /// <param name="zoffset">
            /// Specifies a texel offset in the z direction within the texture array.
            /// </param>
            /// <param name="width">
            /// Specifies the width of the texture subimage.
            /// </param>
            /// <param name="height">
            /// Specifies the height of the texture subimage.
            /// </param>
            /// <param name="depth">
            /// Specifies the depth of the texture subimage.
            /// </param>
            /// <param name="format">
            /// Specifies the format of the pixel data. The following symbolic values are accepted: Red, Rg, Rgb, Bgr, Rgba, DepthComponent, and StencilIndex.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="pixels">
            /// [length: COMPSIZE(format,type,width,height,depth)]
            /// Specifies a pointer to the image data in memory.
            /// </param>
            [AutoGenerated(Category = "EXT_texture3D", Version = "", EntryPoint = "glTexSubImage3DEXT")]
            public static void TexSubImage3D<T10>(OpenTK.Graphics.OpenGL.TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type,width,height,depth")] T10[] pixels)
                where T10 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture3D]
            /// Specify a three-dimensional texture subimage
            /// </summary>
            /// <param name="target">
            /// Specifies the target texture. Must be Texture3D or Texture2DArray.
            /// </param>
            /// <param name="level">
            /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
            /// </param>
            /// <param name="xoffset">
            /// Specifies a texel offset in the x direction within the texture array.
            /// </param>
            /// <param name="yoffset">
            /// Specifies a texel offset in the y direction within the texture array.
            /// </param>
            /// <param name="zoffset">
            /// Specifies a texel offset in the z direction within the texture array.
            /// </param>
            /// <param name="width">
            /// Specifies the width of the texture subimage.
            /// </param>
            /// <param name="height">
            /// Specifies the height of the texture subimage.
            /// </param>
            /// <param name="depth">
            /// Specifies the depth of the texture subimage.
            /// </param>
            /// <param name="format">
            /// Specifies the format of the pixel data. The following symbolic values are accepted: Red, Rg, Rgb, Bgr, Rgba, DepthComponent, and StencilIndex.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="pixels">
            /// [length: COMPSIZE(format,type,width,height,depth)]
            /// Specifies a pointer to the image data in memory.
            /// </param>
            [AutoGenerated(Category = "EXT_texture3D", Version = "", EntryPoint = "glTexSubImage3DEXT")]
            public static void TexSubImage3D<T10>(OpenTK.Graphics.OpenGL.TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type,width,height,depth")] T10[,] pixels)
                where T10 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture3D]
            /// Specify a three-dimensional texture subimage
            /// </summary>
            /// <param name="target">
            /// Specifies the target texture. Must be Texture3D or Texture2DArray.
            /// </param>
            /// <param name="level">
            /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
            /// </param>
            /// <param name="xoffset">
            /// Specifies a texel offset in the x direction within the texture array.
            /// </param>
            /// <param name="yoffset">
            /// Specifies a texel offset in the y direction within the texture array.
            /// </param>
            /// <param name="zoffset">
            /// Specifies a texel offset in the z direction within the texture array.
            /// </param>
            /// <param name="width">
            /// Specifies the width of the texture subimage.
            /// </param>
            /// <param name="height">
            /// Specifies the height of the texture subimage.
            /// </param>
            /// <param name="depth">
            /// Specifies the depth of the texture subimage.
            /// </param>
            /// <param name="format">
            /// Specifies the format of the pixel data. The following symbolic values are accepted: Red, Rg, Rgb, Bgr, Rgba, DepthComponent, and StencilIndex.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="pixels">
            /// [length: COMPSIZE(format,type,width,height,depth)]
            /// Specifies a pointer to the image data in memory.
            /// </param>
            [AutoGenerated(Category = "EXT_texture3D", Version = "", EntryPoint = "glTexSubImage3DEXT")]
            public static void TexSubImage3D<T10>(OpenTK.Graphics.OpenGL.TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type,width,height,depth")] T10[,,] pixels)
                where T10 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_texture3D]
            /// Specify a three-dimensional texture subimage
            /// </summary>
            /// <param name="target">
            /// Specifies the target texture. Must be Texture3D or Texture2DArray.
            /// </param>
            /// <param name="level">
            /// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
            /// </param>
            /// <param name="xoffset">
            /// Specifies a texel offset in the x direction within the texture array.
            /// </param>
            /// <param name="yoffset">
            /// Specifies a texel offset in the y direction within the texture array.
            /// </param>
            /// <param name="zoffset">
            /// Specifies a texel offset in the z direction within the texture array.
            /// </param>
            /// <param name="width">
            /// Specifies the width of the texture subimage.
            /// </param>
            /// <param name="height">
            /// Specifies the height of the texture subimage.
            /// </param>
            /// <param name="depth">
            /// Specifies the depth of the texture subimage.
            /// </param>
            /// <param name="format">
            /// Specifies the format of the pixel data. The following symbolic values are accepted: Red, Rg, Rgb, Bgr, Rgba, DepthComponent, and StencilIndex.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of the pixel data. The following symbolic values are accepted: UnsignedByte, Byte, UnsignedShort, Short, UnsignedInt, Int, Float, UnsignedByte332, UnsignedByte233Rev, UnsignedShort565, UnsignedShort565Rev, UnsignedShort4444, UnsignedShort4444Rev, UnsignedShort5551, UnsignedShort1555Rev, UnsignedInt8888, UnsignedInt8888Rev, UnsignedInt1010102, and UnsignedInt2101010Rev.
            /// </param>
            /// <param name="pixels">
            /// [length: COMPSIZE(format,type,width,height,depth)]
            /// Specifies a pointer to the image data in memory.
            /// </param>
            [AutoGenerated(Category = "EXT_texture3D", Version = "", EntryPoint = "glTexSubImage3DEXT")]
            public static void TexSubImage3D<T10>(OpenTK.Graphics.OpenGL.TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [InAttribute, OutAttribute, CountAttribute(Computed = "format,type,width,height,depth")] ref T10 pixels)
                where T10 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(2269)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glTexImage3DEXT(OpenTK.Graphics.OpenGL.TextureTarget target, int level, OpenTK.Graphics.OpenGL.InternalFormat internalformat, int width, int height, int depth, int border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [CountAttribute(Computed = "format,type,width,height,depth")] IntPtr pixels);

            [Slot(2301)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glTexSubImage3DEXT(OpenTK.Graphics.OpenGL.TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, [CountAttribute(Computed = "format,type,width,height,depth")] IntPtr pixels);
        }
    }
}
