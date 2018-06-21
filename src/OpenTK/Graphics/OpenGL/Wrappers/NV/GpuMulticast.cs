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
        /// Contains native bindings to functions in the category "GpuMulticast" in the extension "NV".
        /// </summary>
        public static partial class NV
        {
            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastBarrierNV")]
            public static void MulticastBarrier()
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="srcGpu">
            /// </param>
            /// <param name="dstGpu">
            /// </param>
            /// <param name="srcX0">
            /// </param>
            /// <param name="srcY0">
            /// </param>
            /// <param name="srcX1">
            /// </param>
            /// <param name="srcY1">
            /// </param>
            /// <param name="dstX0">
            /// </param>
            /// <param name="dstY0">
            /// </param>
            /// <param name="dstX1">
            /// </param>
            /// <param name="dstY1">
            /// </param>
            /// <param name="mask">
            /// </param>
            /// <param name="filter">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastBlitFramebufferNV")]
            public static void MulticastBlitFramebuffer(uint srcGpu, uint dstGpu, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, OpenTK.Graphics.OpenGL.ClearBufferMask mask, OpenTK.Graphics.OpenGL.NvGpuMulticast filter)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpuMask">
            /// </param>
            /// <param name="buffer">
            /// </param>
            /// <param name="offset">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="data">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastBufferSubDataNV")]
            public static void MulticastBufferSubData(uint gpuMask, uint buffer, IntPtr offset, int size, IntPtr data)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpuMask">
            /// </param>
            /// <param name="buffer">
            /// </param>
            /// <param name="offset">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="data">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastBufferSubDataNV")]
            public static void MulticastBufferSubData<T4>(uint gpuMask, uint buffer, IntPtr offset, int size, [InAttribute, OutAttribute] T4[] data)
                where T4 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpuMask">
            /// </param>
            /// <param name="buffer">
            /// </param>
            /// <param name="offset">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="data">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastBufferSubDataNV")]
            public static void MulticastBufferSubData<T4>(uint gpuMask, uint buffer, IntPtr offset, int size, [InAttribute, OutAttribute] T4[,] data)
                where T4 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpuMask">
            /// </param>
            /// <param name="buffer">
            /// </param>
            /// <param name="offset">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="data">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastBufferSubDataNV")]
            public static void MulticastBufferSubData<T4>(uint gpuMask, uint buffer, IntPtr offset, int size, [InAttribute, OutAttribute] T4[,,] data)
                where T4 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpuMask">
            /// </param>
            /// <param name="buffer">
            /// </param>
            /// <param name="offset">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="data">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastBufferSubDataNV")]
            public static void MulticastBufferSubData<T4>(uint gpuMask, uint buffer, IntPtr offset, int size, [InAttribute, OutAttribute] ref T4 data)
                where T4 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpuMask">
            /// </param>
            /// <param name="buffer">
            /// </param>
            /// <param name="offset">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="data">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastBufferSubDataNV")]
            public static void MulticastBufferSubData(uint gpuMask, uint buffer, IntPtr offset, IntPtr size, IntPtr data)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpuMask">
            /// </param>
            /// <param name="buffer">
            /// </param>
            /// <param name="offset">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="data">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastBufferSubDataNV")]
            public static void MulticastBufferSubData<T4>(uint gpuMask, uint buffer, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T4[] data)
                where T4 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpuMask">
            /// </param>
            /// <param name="buffer">
            /// </param>
            /// <param name="offset">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="data">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastBufferSubDataNV")]
            public static void MulticastBufferSubData<T4>(uint gpuMask, uint buffer, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T4[,] data)
                where T4 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpuMask">
            /// </param>
            /// <param name="buffer">
            /// </param>
            /// <param name="offset">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="data">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastBufferSubDataNV")]
            public static void MulticastBufferSubData<T4>(uint gpuMask, uint buffer, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T4[,,] data)
                where T4 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpuMask">
            /// </param>
            /// <param name="buffer">
            /// </param>
            /// <param name="offset">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="data">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastBufferSubDataNV")]
            public static void MulticastBufferSubData<T4>(uint gpuMask, uint buffer, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] ref T4 data)
                where T4 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="readGpu">
            /// </param>
            /// <param name="writeGpuMask">
            /// </param>
            /// <param name="readBuffer">
            /// </param>
            /// <param name="writeBuffer">
            /// </param>
            /// <param name="readOffset">
            /// </param>
            /// <param name="writeOffset">
            /// </param>
            /// <param name="size">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastCopyBufferSubDataNV")]
            public static void MulticastCopyBufferSubData(uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, int size)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="readGpu">
            /// </param>
            /// <param name="writeGpuMask">
            /// </param>
            /// <param name="readBuffer">
            /// </param>
            /// <param name="writeBuffer">
            /// </param>
            /// <param name="readOffset">
            /// </param>
            /// <param name="writeOffset">
            /// </param>
            /// <param name="size">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastCopyBufferSubDataNV")]
            public static void MulticastCopyBufferSubData(uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="srcGpu">
            /// </param>
            /// <param name="dstGpuMask">
            /// </param>
            /// <param name="srcName">
            /// </param>
            /// <param name="srcTarget">
            /// </param>
            /// <param name="srcLevel">
            /// </param>
            /// <param name="srcX">
            /// </param>
            /// <param name="srcY">
            /// </param>
            /// <param name="srcZ">
            /// </param>
            /// <param name="dstName">
            /// </param>
            /// <param name="dstTarget">
            /// </param>
            /// <param name="dstLevel">
            /// </param>
            /// <param name="dstX">
            /// </param>
            /// <param name="dstY">
            /// </param>
            /// <param name="dstZ">
            /// </param>
            /// <param name="srcWidth">
            /// </param>
            /// <param name="srcHeight">
            /// </param>
            /// <param name="srcDepth">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastCopyImageSubDataNV")]
            public static void MulticastCopyImageSubData(uint srcGpu, uint dstGpuMask, uint srcName, OpenTK.Graphics.OpenGL.NvGpuMulticast srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, OpenTK.Graphics.OpenGL.NvGpuMulticast dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="framebuffer">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastFramebufferSampleLocationsfvNV")]
            public static void MulticastFramebufferSampleLocations(uint gpu, uint framebuffer, uint start, int count, float[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="framebuffer">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastFramebufferSampleLocationsfvNV")]
            public static void MulticastFramebufferSampleLocations(uint gpu, uint framebuffer, uint start, int count, ref float v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="framebuffer">
            /// </param>
            /// <param name="start">
            /// </param>
            /// <param name="count">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastFramebufferSampleLocationsfvNV")]
            public static unsafe void MulticastFramebufferSampleLocations(uint gpu, uint framebuffer, uint start, int count, float* v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="id">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastGetQueryObjecti64vNV")]
            public static void MulticastGetQueryObject(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] long[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="id">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastGetQueryObjecti64vNV")]
            public static void MulticastGetQueryObject(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] out long @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="id">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastGetQueryObjecti64vNV")]
            public static unsafe void MulticastGetQueryObject(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] long* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="id">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastGetQueryObjectivNV")]
            public static void MulticastGetQueryObject(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="id">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastGetQueryObjectivNV")]
            public static void MulticastGetQueryObject(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] out int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="id">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastGetQueryObjectivNV")]
            public static unsafe void MulticastGetQueryObject(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="id">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastGetQueryObjectui64vNV")]
            public static void MulticastGetQueryObject(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] ulong[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="id">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastGetQueryObjectui64vNV")]
            public static void MulticastGetQueryObject(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] out ulong @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="id">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastGetQueryObjectui64vNV")]
            public static unsafe void MulticastGetQueryObject(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] ulong* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="id">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastGetQueryObjectuivNV")]
            public static void MulticastGetQueryObject(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] uint[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="id">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastGetQueryObjectuivNV")]
            public static void MulticastGetQueryObject(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] out uint @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="gpu">
            /// </param>
            /// <param name="id">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastGetQueryObjectuivNV")]
            public static unsafe void MulticastGetQueryObject(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] uint* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="signalGpu">
            /// </param>
            /// <param name="waitGpuMask">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glMulticastWaitSyncNV")]
            public static void MulticastWaitSync(uint signalGpu, uint waitGpuMask)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_gpu_multicast]
            /// </summary>
            /// <param name="mask">
            /// </param>
            [AutoGenerated(Category = "NV_gpu_multicast", Version = "", EntryPoint = "glRenderGpuMaskNV")]
            public static void RenderGpuMask(uint mask)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(1391)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMulticastBarrierNV();

            [Slot(1392)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMulticastBlitFramebufferNV(uint srcGpu, uint dstGpu, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, OpenTK.Graphics.OpenGL.ClearBufferMask mask, OpenTK.Graphics.OpenGL.NvGpuMulticast filter);

            [Slot(1393)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMulticastBufferSubDataNV(uint gpuMask, uint buffer, IntPtr offset, IntPtr size, IntPtr data);

            [Slot(1394)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMulticastCopyBufferSubDataNV(uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size);

            [Slot(1395)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMulticastCopyImageSubDataNV(uint srcGpu, uint dstGpuMask, uint srcName, OpenTK.Graphics.OpenGL.NvGpuMulticast srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, OpenTK.Graphics.OpenGL.NvGpuMulticast dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);

            [Slot(1396)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glMulticastFramebufferSampleLocationsfvNV(uint gpu, uint framebuffer, uint start, int count, float* v);

            [Slot(1397)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glMulticastGetQueryObjecti64vNV(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] long* @params);

            [Slot(1398)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glMulticastGetQueryObjectivNV(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] int* @params);

            [Slot(1399)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glMulticastGetQueryObjectui64vNV(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] ulong* @params);

            [Slot(1400)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glMulticastGetQueryObjectuivNV(uint gpu, uint id, OpenTK.Graphics.OpenGL.NvGpuMulticast pname, [OutAttribute] uint* @params);

            [Slot(1401)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glMulticastWaitSyncNV(uint signalGpu, uint waitGpuMask);

            [Slot(1988)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glRenderGpuMaskNV(uint mask);
        }
    }
}
