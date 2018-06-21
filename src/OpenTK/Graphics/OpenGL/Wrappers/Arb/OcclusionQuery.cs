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
        /// Contains native bindings to functions in the category "OcclusionQuery" in the extension "Arb".
        /// </summary>
        public static partial class Arb
        {
            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Delimit the boundaries of a query object
            /// </summary>
            /// <param name="target">
            /// Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic constant must be one of SamplesPassed, AnySamplesPassed, AnySamplesPassedConservative, PrimitivesGenerated, TransformFeedbackPrimitivesWritten, or TimeElapsed.
            /// </param>
            /// <param name="id">
            /// Specifies the name of a query object.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glBeginQueryARB")]
            public static void BeginQuery(OpenTK.Graphics.OpenGL.ArbOcclusionQuery target, uint id)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Delete named query objects
            /// </summary>
            /// <param name="ids">
            /// [length: n]
            /// Specifies an array of query objects to be deleted.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glDeleteQueriesARB")]
            public static void DeleteQuery([CountAttribute(Parameter = "n")] uint ids)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Delete named query objects
            /// </summary>
            /// <param name="n">
            /// Specifies the number of query objects to be deleted.
            /// </param>
            /// <param name="ids">
            /// [length: n]
            /// Specifies an array of query objects to be deleted.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glDeleteQueriesARB")]
            public static void DeleteQueries(int n, [CountAttribute(Parameter = "n")] uint[] ids)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Delete named query objects
            /// </summary>
            /// <param name="n">
            /// Specifies the number of query objects to be deleted.
            /// </param>
            /// <param name="ids">
            /// [length: n]
            /// Specifies an array of query objects to be deleted.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glDeleteQueriesARB")]
            public static void DeleteQueries(int n, [CountAttribute(Parameter = "n")] ref uint ids)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Delete named query objects
            /// </summary>
            /// <param name="n">
            /// Specifies the number of query objects to be deleted.
            /// </param>
            /// <param name="ids">
            /// [length: n]
            /// Specifies an array of query objects to be deleted.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glDeleteQueriesARB")]
            public static unsafe void DeleteQueries(int n, [CountAttribute(Parameter = "n")] uint* ids)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// </summary>
            /// <param name="target">
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glEndQueryARB")]
            public static void EndQuery(OpenTK.Graphics.OpenGL.QueryTarget target)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Generate query object names
            /// </summary>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glGenQueriesARB")]
            public static uint GenQuery()
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Generate query object names
            /// </summary>
            /// <param name="n">
            /// Specifies the number of query object names to be generated.
            /// </param>
            /// <param name="ids">
            /// [length: n]
            /// Specifies an array in which the generated query object names are stored.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glGenQueriesARB")]
            public static void GenQueries(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint[] ids)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Generate query object names
            /// </summary>
            /// <param name="n">
            /// Specifies the number of query object names to be generated.
            /// </param>
            /// <param name="ids">
            /// [length: n]
            /// Specifies an array in which the generated query object names are stored.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glGenQueriesARB")]
            public static void GenQueries(int n, [OutAttribute, CountAttribute(Parameter = "n")] out uint ids)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Generate query object names
            /// </summary>
            /// <param name="n">
            /// Specifies the number of query object names to be generated.
            /// </param>
            /// <param name="ids">
            /// [length: n]
            /// Specifies an array in which the generated query object names are stored.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glGenQueriesARB")]
            public static unsafe void GenQueries(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint* ids)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Return parameters of a query object
            /// </summary>
            /// <param name="id">
            /// Specifies the name of a query object.
            /// </param>
            /// <param name="pname">
            /// Specifies the symbolic name of a query object parameter. Accepted values are QueryResult or QueryResultAvailable.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// If a buffer is bound to the QueryResultBuffer target, then params is treated as an offset to a location within that buffer's data store to receive the result of the query. If no buffer is bound to QueryResultBuffer, then params is treated as an address in client memory of a variable to receive the resulting data.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glGetQueryObjectivARB")]
            public static void GetQueryObject(uint id, OpenTK.Graphics.OpenGL.QueryObjectParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Return parameters of a query object
            /// </summary>
            /// <param name="id">
            /// Specifies the name of a query object.
            /// </param>
            /// <param name="pname">
            /// Specifies the symbolic name of a query object parameter. Accepted values are QueryResult or QueryResultAvailable.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// If a buffer is bound to the QueryResultBuffer target, then params is treated as an offset to a location within that buffer's data store to receive the result of the query. If no buffer is bound to QueryResultBuffer, then params is treated as an address in client memory of a variable to receive the resulting data.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glGetQueryObjectivARB")]
            public static void GetQueryObject(uint id, OpenTK.Graphics.OpenGL.QueryObjectParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] out int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Return parameters of a query object
            /// </summary>
            /// <param name="id">
            /// Specifies the name of a query object.
            /// </param>
            /// <param name="pname">
            /// Specifies the symbolic name of a query object parameter. Accepted values are QueryResult or QueryResultAvailable.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// If a buffer is bound to the QueryResultBuffer target, then params is treated as an offset to a location within that buffer's data store to receive the result of the query. If no buffer is bound to QueryResultBuffer, then params is treated as an address in client memory of a variable to receive the resulting data.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glGetQueryObjectivARB")]
            public static unsafe void GetQueryObject(uint id, OpenTK.Graphics.OpenGL.QueryObjectParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Return parameters of a query object
            /// </summary>
            /// <param name="id">
            /// Specifies the name of a query object.
            /// </param>
            /// <param name="pname">
            /// Specifies the symbolic name of a query object parameter. Accepted values are QueryResult or QueryResultAvailable.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// If a buffer is bound to the QueryResultBuffer target, then params is treated as an offset to a location within that buffer's data store to receive the result of the query. If no buffer is bound to QueryResultBuffer, then params is treated as an address in client memory of a variable to receive the resulting data.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glGetQueryObjectuivARB")]
            public static void GetQueryObject(uint id, OpenTK.Graphics.OpenGL.QueryObjectParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] uint[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Return parameters of a query object
            /// </summary>
            /// <param name="id">
            /// Specifies the name of a query object.
            /// </param>
            /// <param name="pname">
            /// Specifies the symbolic name of a query object parameter. Accepted values are QueryResult or QueryResultAvailable.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// If a buffer is bound to the QueryResultBuffer target, then params is treated as an offset to a location within that buffer's data store to receive the result of the query. If no buffer is bound to QueryResultBuffer, then params is treated as an address in client memory of a variable to receive the resulting data.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glGetQueryObjectuivARB")]
            public static void GetQueryObject(uint id, OpenTK.Graphics.OpenGL.QueryObjectParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] out uint @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Return parameters of a query object
            /// </summary>
            /// <param name="id">
            /// Specifies the name of a query object.
            /// </param>
            /// <param name="pname">
            /// Specifies the symbolic name of a query object parameter. Accepted values are QueryResult or QueryResultAvailable.
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// If a buffer is bound to the QueryResultBuffer target, then params is treated as an offset to a location within that buffer's data store to receive the result of the query. If no buffer is bound to QueryResultBuffer, then params is treated as an address in client memory of a variable to receive the resulting data.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glGetQueryObjectuivARB")]
            public static unsafe void GetQueryObject(uint id, OpenTK.Graphics.OpenGL.QueryObjectParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] uint* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glGetQueryivARB")]
            public static void GetQuery(OpenTK.Graphics.OpenGL.QueryTarget target, OpenTK.Graphics.OpenGL.QueryParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glGetQueryivARB")]
            public static void GetQuery(OpenTK.Graphics.OpenGL.QueryTarget target, OpenTK.Graphics.OpenGL.QueryParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] out int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glGetQueryivARB")]
            public static unsafe void GetQuery(OpenTK.Graphics.OpenGL.QueryTarget target, OpenTK.Graphics.OpenGL.QueryParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: ARB_occlusion_query]
            /// Determine if a name corresponds to a query object
            /// </summary>
            /// <param name="id">
            /// Specifies a value that may be the name of a query object.
            /// </param>
            [AutoGenerated(Category = "ARB_occlusion_query", Version = "", EntryPoint = "glIsQueryARB")]
            public static bool IsQuery(uint id)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(36)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glBeginQueryARB(OpenTK.Graphics.OpenGL.ArbOcclusionQuery target, uint id);

            [Slot(428)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glDeleteQueriesARB(int n, [CountAttribute(Parameter = "n")] uint* ids);

            [Slot(545)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glEndQueryARB(OpenTK.Graphics.OpenGL.QueryTarget target);

            [Slot(681)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGenQueriesARB(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint* ids);

            [Slot(1018)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetQueryObjectivARB(uint id, OpenTK.Graphics.OpenGL.QueryObjectParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params);

            [Slot(1022)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetQueryObjectuivARB(uint id, OpenTK.Graphics.OpenGL.QueryObjectParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] uint* @params);

            [Slot(1014)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetQueryivARB(OpenTK.Graphics.OpenGL.QueryTarget target, OpenTK.Graphics.OpenGL.QueryParameterName pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params);

            [Slot(1245)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern byte glIsQueryARB(uint id);
        }
    }
}
