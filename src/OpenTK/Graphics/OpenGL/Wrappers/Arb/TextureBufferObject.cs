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
        /// Contains native bindings to functions in the category "TextureBufferObject" in the extension "Arb".
        /// </summary>
        public static partial class Arb
        {
            /// <summary>
            /// [requires: ARB_texture_buffer_object]
            /// Attach the storage for a buffer object to the active buffer texture
            /// </summary>
            /// <param name="target">
            /// Specifies the target of the operation and must be TextureBuffer.
            /// </param>
            /// <param name="internalformat">
            /// Specifies the internal format of the data in the store belonging to buffer.
            /// </param>
            /// <param name="buffer">
            /// Specifies the name of the buffer object whose storage to attach to the active buffer texture.
            /// </param>
            [AutoGenerated(Category = "ARB_texture_buffer_object", Version = "", EntryPoint = "glTexBufferARB")]
            public static void TexBuffer(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.InternalFormat internalformat, uint buffer)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(2161)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glTexBufferARB(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.InternalFormat internalformat, uint buffer);
        }
    }
}
