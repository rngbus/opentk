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
        /// [requires: v4.3 or ARB_texture_view|VERSION_4_3]
        /// Initialize a texture as a data alias of another texture's data store
        /// </summary>
        /// <param name="texture">
        /// Specifies the texture object to be initialized as a view.
        /// </param>
        /// <param name="target">
        /// Specifies the target to be used for the newly initialized texture.
        /// </param>
        /// <param name="origtexture">
        /// Specifies the name of a texture object of which to make a view.
        /// </param>
        /// <param name="internalformat">
        /// Specifies the internal format for the newly created view.
        /// </param>
        /// <param name="minlevel">
        /// Specifies lowest level of detail of the view.
        /// </param>
        /// <param name="numlevels">
        /// Specifies the number of levels of detail to include in the view.
        /// </param>
        /// <param name="minlayer">
        /// Specifies the index of the first layer to include in the view.
        /// </param>
        /// <param name="numlayers">
        /// Specifies the number of layers to include in the view.
        /// </param>
        [AutoGenerated(Category = "ARB_texture_view|VERSION_4_3", Version = "4.3", EntryPoint = "glTextureView")]
        public static void TextureView(uint texture, OpenTK.Graphics.OpenGL4.TextureTarget target, uint origtexture, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers)
        {
            throw new BindingsNotRewrittenException();
        }

        [Slot(1108)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureView(uint texture, OpenTK.Graphics.OpenGL4.TextureTarget target, uint origtexture, OpenTK.Graphics.OpenGL4.PixelInternalFormat internalformat, uint minlevel, uint numlevels, uint minlayer, uint numlayers);
    }
}
