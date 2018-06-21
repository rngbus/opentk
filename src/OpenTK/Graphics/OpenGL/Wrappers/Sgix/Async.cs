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
        /// Contains native bindings to functions in the category "Async" in the extension "Sgix".
        /// </summary>
        public static partial class Sgix
        {
            /// <summary>
            /// [requires: SGIX_async]
            /// </summary>
            /// <param name="marker">
            /// </param>
            [AutoGenerated(Category = "SGIX_async", Version = "", EntryPoint = "glAsyncMarkerSGIX")]
            public static void AsyncMarker(uint marker)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_async]
            /// </summary>
            /// <param name="marker">
            /// </param>
            /// <param name="range">
            /// </param>
            [AutoGenerated(Category = "SGIX_async", Version = "", EntryPoint = "glDeleteAsyncMarkersSGIX")]
            public static void DeleteAsyncMarkers(uint marker, int range)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_async]
            /// </summary>
            /// <param name="markerp">
            /// [length: 1]
            /// </param>
            [AutoGenerated(Category = "SGIX_async", Version = "", EntryPoint = "glFinishAsyncSGIX")]
            public static int FinishAsync([OutAttribute, CountAttribute(Count = 1)] out uint markerp)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_async]
            /// </summary>
            /// <param name="range">
            /// </param>
            [AutoGenerated(Category = "SGIX_async", Version = "", EntryPoint = "glGenAsyncMarkersSGIX")]
            public static uint GenAsyncMarkers(int range)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_async]
            /// </summary>
            /// <param name="marker">
            /// </param>
            [AutoGenerated(Category = "SGIX_async", Version = "", EntryPoint = "glIsAsyncMarkerSGIX")]
            public static bool IsAsyncMarker(uint marker)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_async]
            /// </summary>
            /// <param name="markerp">
            /// [length: 1]
            /// </param>
            [AutoGenerated(Category = "SGIX_async", Version = "", EntryPoint = "glPollAsyncSGIX")]
            public static int PollAsync([OutAttribute, CountAttribute(Count = 1)] out uint markerp)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(24)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glAsyncMarkerSGIX(uint marker);

            [Slot(404)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDeleteAsyncMarkersSGIX(uint marker, int range);

            [Slot(577)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe int glFinishAsyncSGIX([OutAttribute, CountAttribute(Count = 1)] uint* markerp);

            [Slot(658)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern uint glGenAsyncMarkersSGIX(int range);

            [Slot(1215)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern byte glIsAsyncMarkerSGIX(uint marker);

            [Slot(1712)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe int glPollAsyncSGIX([OutAttribute, CountAttribute(Count = 1)] uint* markerp);
        }
    }
}
