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
        /// Contains native bindings to functions in the category "MemoryObject|EXTSemaphore" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: EXT_memory_object|EXT_semaphore]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="index">
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(target)]
            /// </param>
            [AutoGenerated(Category = "EXT_memory_object|EXT_semaphore", Version = "", EntryPoint = "glGetUnsignedBytei_vEXT")]
            public static void GetUnsignedByte(OpenTK.Graphics.OpenGL.ExtMemoryObject target, uint index, [OutAttribute, CountAttribute(Computed = "target")] Byte[] data)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_memory_object|EXT_semaphore]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="index">
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(target)]
            /// </param>
            [AutoGenerated(Category = "EXT_memory_object|EXT_semaphore", Version = "", EntryPoint = "glGetUnsignedBytei_vEXT")]
            public static void GetUnsignedByte(OpenTK.Graphics.OpenGL.ExtMemoryObject target, uint index, [OutAttribute, CountAttribute(Computed = "target")] out Byte data)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_memory_object|EXT_semaphore]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="index">
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(target)]
            /// </param>
            [AutoGenerated(Category = "EXT_memory_object|EXT_semaphore", Version = "", EntryPoint = "glGetUnsignedBytei_vEXT")]
            public static unsafe void GetUnsignedByte(OpenTK.Graphics.OpenGL.ExtMemoryObject target, uint index, [OutAttribute, CountAttribute(Computed = "target")] Byte* data)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_memory_object|EXT_semaphore]
            /// </summary>
            /// <param name="pname">
            /// </param>
            [AutoGenerated(Category = "EXT_memory_object|EXT_semaphore", Version = "", EntryPoint = "glGetUnsignedBytevEXT")]
            public static Byte GetUnsignedByte(OpenTK.Graphics.OpenGL.GetPName pname)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_memory_object|EXT_semaphore]
            /// </summary>
            /// <param name="pname">
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_memory_object|EXT_semaphore", Version = "", EntryPoint = "glGetUnsignedBytevEXT")]
            public static void GetUnsignedByte(OpenTK.Graphics.OpenGL.GetPName pname, [OutAttribute, CountAttribute(Computed = "pname")] Byte[] data)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_memory_object|EXT_semaphore]
            /// </summary>
            /// <param name="pname">
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_memory_object|EXT_semaphore", Version = "", EntryPoint = "glGetUnsignedBytevEXT")]
            public static void GetUnsignedByte(OpenTK.Graphics.OpenGL.GetPName pname, [OutAttribute, CountAttribute(Computed = "pname")] out Byte data)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_memory_object|EXT_semaphore]
            /// </summary>
            /// <param name="pname">
            /// </param>
            /// <param name="data">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "EXT_memory_object|EXT_semaphore", Version = "", EntryPoint = "glGetUnsignedBytevEXT")]
            public static unsafe void GetUnsignedByte(OpenTK.Graphics.OpenGL.GetPName pname, [OutAttribute, CountAttribute(Computed = "pname")] Byte* data)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(1110)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetUnsignedBytei_vEXT(OpenTK.Graphics.OpenGL.ExtMemoryObject target, uint index, [OutAttribute, CountAttribute(Computed = "target")] Byte* data);

            [Slot(1111)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetUnsignedBytevEXT(OpenTK.Graphics.OpenGL.GetPName pname, [OutAttribute, CountAttribute(Computed = "pname")] Byte* data);
        }
    }
}
