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
        /// [requires: v3.0 or ARB_uniform_buffer_object|VERSION_3_0|VERSION_3_1]
        /// Bind a buffer object to an indexed buffer target
        /// </summary>
        /// <param name="target">
        /// Specify the target of the bind operation. target must be one of AtomicCounterBuffer, TransformFeedbackBuffer, UniformBuffer or ShaderStorageBuffer.
        /// </param>
        /// <param name="index">
        /// Specify the index of the binding point within the array specified by target.
        /// </param>
        /// <param name="buffer">
        /// The name of a buffer object to bind to the specified binding point.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_0|VERSION_3_1", Version = "3.0", EntryPoint = "glBindBufferBase")]
        public static void BindBufferBase(OpenTK.Graphics.OpenGL.BufferRangeTarget target, uint index, uint buffer)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_uniform_buffer_object|VERSION_3_0|VERSION_3_1]
        /// Bind a range within a buffer object to an indexed buffer target
        /// </summary>
        /// <param name="target">
        /// Specify the target of the bind operation. target must be one of AtomicCounterBuffer, TransformFeedbackBuffer, UniformBuffer, or ShaderStorageBuffer.
        /// </param>
        /// <param name="index">
        /// Specify the index of the binding point within the array specified by target.
        /// </param>
        /// <param name="buffer">
        /// The name of a buffer object to bind to the specified binding point.
        /// </param>
        /// <param name="offset">
        /// The starting offset in basic machine units into the buffer object buffer.
        /// </param>
        /// <param name="size">
        /// The amount of data in machine units that can be read from the buffet object while used as an indexed target.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_0|VERSION_3_1", Version = "3.0", EntryPoint = "glBindBufferRange")]
        public static void BindBufferRange(OpenTK.Graphics.OpenGL.BufferRangeTarget target, uint index, uint buffer, IntPtr offset, int size)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_uniform_buffer_object|VERSION_3_0|VERSION_3_1]
        /// Bind a range within a buffer object to an indexed buffer target
        /// </summary>
        /// <param name="target">
        /// Specify the target of the bind operation. target must be one of AtomicCounterBuffer, TransformFeedbackBuffer, UniformBuffer, or ShaderStorageBuffer.
        /// </param>
        /// <param name="index">
        /// Specify the index of the binding point within the array specified by target.
        /// </param>
        /// <param name="buffer">
        /// The name of a buffer object to bind to the specified binding point.
        /// </param>
        /// <param name="offset">
        /// The starting offset in basic machine units into the buffer object buffer.
        /// </param>
        /// <param name="size">
        /// The amount of data in machine units that can be read from the buffet object while used as an indexed target.
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_0|VERSION_3_1", Version = "3.0", EntryPoint = "glBindBufferRange")]
        public static void BindBufferRange(OpenTK.Graphics.OpenGL.BufferRangeTarget target, uint index, uint buffer, IntPtr offset, IntPtr size)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_uniform_buffer_object|VERSION_3_0|VERSION_3_1]
        /// </summary>
        /// <param name="target">
        /// </param>
        /// <param name="index">
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(target)]
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_0|VERSION_3_1", Version = "3.0", EntryPoint = "glGetIntegeri_v")]
        public static void GetInteger(OpenTK.Graphics.OpenGL.GetIndexedPName target, uint index, [OutAttribute, CountAttribute(Computed = "target")] int[] data)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_uniform_buffer_object|VERSION_3_0|VERSION_3_1]
        /// </summary>
        /// <param name="target">
        /// </param>
        /// <param name="index">
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(target)]
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_0|VERSION_3_1", Version = "3.0", EntryPoint = "glGetIntegeri_v")]
        public static void GetInteger(OpenTK.Graphics.OpenGL.GetIndexedPName target, uint index, [OutAttribute, CountAttribute(Computed = "target")] out int data)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v3.0 or ARB_uniform_buffer_object|VERSION_3_0|VERSION_3_1]
        /// </summary>
        /// <param name="target">
        /// </param>
        /// <param name="index">
        /// </param>
        /// <param name="data">
        /// [length: COMPSIZE(target)]
        /// </param>
        [AutoGenerated(Category = "ARB_uniform_buffer_object|VERSION_3_0|VERSION_3_1", Version = "3.0", EntryPoint = "glGetIntegeri_v")]
        public static unsafe void GetInteger(OpenTK.Graphics.OpenGL.GetIndexedPName target, uint index, [OutAttribute, CountAttribute(Computed = "target")] int* data)
        {
            throw new BindingsNotRewrittenException();
        }

        [Slot(47)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindBufferBase(OpenTK.Graphics.OpenGL.BufferRangeTarget target, uint index, uint buffer);

        [Slot(52)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindBufferRange(OpenTK.Graphics.OpenGL.BufferRangeTarget target, uint index, uint buffer, IntPtr offset, IntPtr size);

        [Slot(808)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetIntegeri_v(OpenTK.Graphics.OpenGL.GetIndexedPName target, uint index, [OutAttribute, CountAttribute(Computed = "target")] int* data);
    }
}
