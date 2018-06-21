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
        /// Contains native bindings to functions in the category "PerformanceQuery" in the extension "Intel".
        /// </summary>
        public static partial class Intel
        {
            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glBeginPerfQueryINTEL")]
            public static void BeginPerfQuery(uint queryHandle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            /// <param name="queryHandle">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glCreatePerfQueryINTEL")]
            public static void CreatePerfQuery(uint queryId, [OutAttribute] uint[] queryHandle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            /// <param name="queryHandle">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glCreatePerfQueryINTEL")]
            public static void CreatePerfQuery(uint queryId, [OutAttribute] out uint queryHandle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            /// <param name="queryHandle">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glCreatePerfQueryINTEL")]
            public static unsafe void CreatePerfQuery(uint queryId, [OutAttribute] uint* queryHandle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glDeletePerfQueryINTEL")]
            public static void DeletePerfQuery(uint queryHandle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glEndPerfQueryINTEL")]
            public static void EndPerfQuery(uint queryHandle)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetFirstPerfQueryIdINTEL")]
            public static void GetFirstPerfQueryI([OutAttribute] uint[] queryId)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetFirstPerfQueryIdINTEL")]
            public static void GetFirstPerfQueryI([OutAttribute] out uint queryId)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetNextPerfQueryIdINTEL")]
            public static uint GetNextPerfQueryI(uint queryId)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            /// <param name="nextQueryId">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetNextPerfQueryIdINTEL")]
            public static void GetNextPerfQueryI(uint queryId, [OutAttribute] uint[] nextQueryId)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            /// <param name="nextQueryId">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetNextPerfQueryIdINTEL")]
            public static void GetNextPerfQueryI(uint queryId, [OutAttribute] out uint nextQueryId)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            /// <param name="nextQueryId">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetNextPerfQueryIdINTEL")]
            public static unsafe void GetNextPerfQueryI(uint queryId, [OutAttribute] uint* nextQueryId)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            /// <param name="counterId">
            /// </param>
            /// <param name="counterNameLength">
            /// </param>
            /// <param name="counterName">
            /// [length: counterNameLength]
            /// </param>
            /// <param name="counterDescLength">
            /// </param>
            /// <param name="counterDesc">
            /// [length: counterDescLength]
            /// </param>
            /// <param name="counterOffset">
            /// </param>
            /// <param name="counterDataSize">
            /// </param>
            /// <param name="counterTypeEnum">
            /// </param>
            /// <param name="counterDataTypeEnum">
            /// </param>
            /// <param name="rawCounterMaxValue">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfCounterInfoINTEL")]
            public static void GetPerfCounterInfo(uint queryId, uint counterId, uint counterNameLength, [OutAttribute, CountAttribute(Parameter = "counterNameLength")] out String counterName, uint counterDescLength, [OutAttribute, CountAttribute(Parameter = "counterDescLength")] out String counterDesc, [OutAttribute] uint[] counterOffset, [OutAttribute] uint[] counterDataSize, [OutAttribute] uint[] counterTypeEnum, [OutAttribute] uint[] counterDataTypeEnum, [OutAttribute] ulong[] rawCounterMaxValue)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            /// <param name="counterId">
            /// </param>
            /// <param name="counterNameLength">
            /// </param>
            /// <param name="counterName">
            /// [length: counterNameLength]
            /// </param>
            /// <param name="counterDescLength">
            /// </param>
            /// <param name="counterDesc">
            /// [length: counterDescLength]
            /// </param>
            /// <param name="counterOffset">
            /// </param>
            /// <param name="counterDataSize">
            /// </param>
            /// <param name="counterTypeEnum">
            /// </param>
            /// <param name="counterDataTypeEnum">
            /// </param>
            /// <param name="rawCounterMaxValue">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfCounterInfoINTEL")]
            public static void GetPerfCounterInfo(uint queryId, uint counterId, uint counterNameLength, [OutAttribute, CountAttribute(Parameter = "counterNameLength")] out String counterName, uint counterDescLength, [OutAttribute, CountAttribute(Parameter = "counterDescLength")] out String counterDesc, [OutAttribute] out uint counterOffset, [OutAttribute] out uint counterDataSize, [OutAttribute] out uint counterTypeEnum, [OutAttribute] out uint counterDataTypeEnum, [OutAttribute] out ulong rawCounterMaxValue)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            /// <param name="counterId">
            /// </param>
            /// <param name="counterNameLength">
            /// </param>
            /// <param name="counterName">
            /// [length: counterNameLength]
            /// </param>
            /// <param name="counterDescLength">
            /// </param>
            /// <param name="counterDesc">
            /// [length: counterDescLength]
            /// </param>
            /// <param name="counterOffset">
            /// </param>
            /// <param name="counterDataSize">
            /// </param>
            /// <param name="counterTypeEnum">
            /// </param>
            /// <param name="counterDataTypeEnum">
            /// </param>
            /// <param name="rawCounterMaxValue">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfCounterInfoINTEL")]
            public static unsafe void GetPerfCounterInfo(uint queryId, uint counterId, uint counterNameLength, [OutAttribute, CountAttribute(Parameter = "counterNameLength")] out String counterName, uint counterDescLength, [OutAttribute, CountAttribute(Parameter = "counterDescLength")] out String counterDesc, [OutAttribute] uint* counterOffset, [OutAttribute] uint* counterDataSize, [OutAttribute] uint* counterTypeEnum, [OutAttribute] uint* counterDataTypeEnum, [OutAttribute] ulong* rawCounterMaxValue)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static void GetPerfQueryData(uint queryHandle, uint flags, int dataSize, [OutAttribute] IntPtr data, [OutAttribute] uint[] bytesWritten)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static void GetPerfQueryData(uint queryHandle, uint flags, int dataSize, [OutAttribute] IntPtr data, [OutAttribute] out uint bytesWritten)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static unsafe void GetPerfQueryData(uint queryHandle, uint flags, int dataSize, [OutAttribute] IntPtr data, [OutAttribute] uint* bytesWritten)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static void GetPerfQueryData<T3>(uint queryHandle, uint flags, int dataSize, [InAttribute, OutAttribute] T3[] data, [OutAttribute] uint[] bytesWritten)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static void GetPerfQueryData<T3>(uint queryHandle, uint flags, int dataSize, [InAttribute, OutAttribute] T3[] data, [OutAttribute] out uint bytesWritten)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static unsafe void GetPerfQueryData<T3>(uint queryHandle, uint flags, int dataSize, [InAttribute, OutAttribute] T3[] data, [OutAttribute] uint* bytesWritten)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static void GetPerfQueryData<T3>(uint queryHandle, uint flags, int dataSize, [InAttribute, OutAttribute] T3[,] data, [OutAttribute] uint[] bytesWritten)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static void GetPerfQueryData<T3>(uint queryHandle, uint flags, int dataSize, [InAttribute, OutAttribute] T3[,] data, [OutAttribute] out uint bytesWritten)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static unsafe void GetPerfQueryData<T3>(uint queryHandle, uint flags, int dataSize, [InAttribute, OutAttribute] T3[,] data, [OutAttribute] uint* bytesWritten)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static void GetPerfQueryData<T3>(uint queryHandle, uint flags, int dataSize, [InAttribute, OutAttribute] T3[,,] data, [OutAttribute] uint[] bytesWritten)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static void GetPerfQueryData<T3>(uint queryHandle, uint flags, int dataSize, [InAttribute, OutAttribute] T3[,,] data, [OutAttribute] out uint bytesWritten)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static unsafe void GetPerfQueryData<T3>(uint queryHandle, uint flags, int dataSize, [InAttribute, OutAttribute] T3[,,] data, [OutAttribute] uint* bytesWritten)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static void GetPerfQueryData<T3>(uint queryHandle, uint flags, int dataSize, [InAttribute, OutAttribute] ref T3 data, [OutAttribute] uint[] bytesWritten)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static void GetPerfQueryData<T3>(uint queryHandle, uint flags, int dataSize, [InAttribute, OutAttribute] ref T3 data, [OutAttribute] out uint bytesWritten)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryHandle">
            /// </param>
            /// <param name="flags">
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="data">
            /// </param>
            /// <param name="bytesWritten">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryDataINTEL")]
            public static unsafe void GetPerfQueryData<T3>(uint queryHandle, uint flags, int dataSize, [InAttribute, OutAttribute] ref T3 data, [OutAttribute] uint* bytesWritten)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryName">
            /// </param>
            /// <param name="queryId">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryIdByNameINTEL")]
            public static void GetPerfQueryIdByName(String queryName, [OutAttribute] uint[] queryId)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryName">
            /// </param>
            /// <param name="queryId">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryIdByNameINTEL")]
            public static void GetPerfQueryIdByName(String queryName, [OutAttribute] out uint queryId)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            /// <param name="queryNameLength">
            /// </param>
            /// <param name="queryName">
            /// [length: queryNameLength]
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="noCounters">
            /// </param>
            /// <param name="noInstances">
            /// </param>
            /// <param name="capsMask">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryInfoINTEL")]
            public static void GetPerfQueryInfo(uint queryId, uint queryNameLength, [OutAttribute, CountAttribute(Parameter = "queryNameLength")] out String queryName, [OutAttribute] uint[] dataSize, [OutAttribute] uint[] noCounters, [OutAttribute] uint[] noInstances, [OutAttribute] uint[] capsMask)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            /// <param name="queryNameLength">
            /// </param>
            /// <param name="queryName">
            /// [length: queryNameLength]
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="noCounters">
            /// </param>
            /// <param name="noInstances">
            /// </param>
            /// <param name="capsMask">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryInfoINTEL")]
            public static void GetPerfQueryInfo(uint queryId, uint queryNameLength, [OutAttribute, CountAttribute(Parameter = "queryNameLength")] out String queryName, [OutAttribute] out uint dataSize, [OutAttribute] out uint noCounters, [OutAttribute] out uint noInstances, [OutAttribute] out uint capsMask)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: INTEL_performance_query]
            /// </summary>
            /// <param name="queryId">
            /// </param>
            /// <param name="queryNameLength">
            /// </param>
            /// <param name="queryName">
            /// [length: queryNameLength]
            /// </param>
            /// <param name="dataSize">
            /// </param>
            /// <param name="noCounters">
            /// </param>
            /// <param name="noInstances">
            /// </param>
            /// <param name="capsMask">
            /// </param>
            [AutoGenerated(Category = "INTEL_performance_query", Version = "", EntryPoint = "glGetPerfQueryInfoINTEL")]
            public static unsafe void GetPerfQueryInfo(uint queryId, uint queryNameLength, [OutAttribute, CountAttribute(Parameter = "queryNameLength")] out String queryName, [OutAttribute] uint* dataSize, [OutAttribute] uint* noCounters, [OutAttribute] uint* noInstances, [OutAttribute] uint* capsMask)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(10)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glBeginPerfQueryINTEL(uint queryHandle);

            [Slot(101)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glCreatePerfQueryINTEL(uint queryId, [OutAttribute] uint* queryHandle);

            [Slot(120)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDeletePerfQueryINTEL(uint queryHandle);

            [Slot(192)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glEndPerfQueryINTEL(uint queryHandle);

            [Slot(273)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetFirstPerfQueryIdINTEL([OutAttribute] uint* queryId);

            [Slot(296)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetNextPerfQueryIdINTEL(uint queryId, [OutAttribute] uint* nextQueryId);

            [Slot(323)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetPerfCounterInfoINTEL(uint queryId, uint counterId, uint counterNameLength, [OutAttribute, CountAttribute(Parameter = "counterNameLength")] IntPtr counterName, uint counterDescLength, [OutAttribute, CountAttribute(Parameter = "counterDescLength")] IntPtr counterDesc, [OutAttribute] uint* counterOffset, [OutAttribute] uint* counterDataSize, [OutAttribute] uint* counterTypeEnum, [OutAttribute] uint* counterDataTypeEnum, [OutAttribute] ulong* rawCounterMaxValue);

            [Slot(330)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetPerfQueryDataINTEL(uint queryHandle, uint flags, int dataSize, [OutAttribute] IntPtr data, [OutAttribute] uint* bytesWritten);

            [Slot(331)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetPerfQueryIdByNameINTEL(IntPtr queryName, [OutAttribute] uint* queryId);

            [Slot(332)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetPerfQueryInfoINTEL(uint queryId, uint queryNameLength, [OutAttribute, CountAttribute(Parameter = "queryNameLength")] IntPtr queryName, [OutAttribute] uint* dataSize, [OutAttribute] uint* noCounters, [OutAttribute] uint* noInstances, [OutAttribute] uint* capsMask);
        }
    }
}
