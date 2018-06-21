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
        /// Contains native bindings to functions in the category "PresentVideo" in the extension "NV".
        /// </summary>
        public static partial class NV
        {
            /// <summary>
            /// [requires: NV_present_video]
            /// </summary>
            /// <param name="video_slot">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "NV_present_video", Version = "", EntryPoint = "glGetVideoi64vNV")]
            public static void GetVideo(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] long[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_present_video]
            /// </summary>
            /// <param name="video_slot">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "NV_present_video", Version = "", EntryPoint = "glGetVideoi64vNV")]
            public static void GetVideo(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] out long @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_present_video]
            /// </summary>
            /// <param name="video_slot">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "NV_present_video", Version = "", EntryPoint = "glGetVideoi64vNV")]
            public static unsafe void GetVideo(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] long* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_present_video]
            /// </summary>
            /// <param name="video_slot">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "NV_present_video", Version = "", EntryPoint = "glGetVideoivNV")]
            public static void GetVideo(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_present_video]
            /// </summary>
            /// <param name="video_slot">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "NV_present_video", Version = "", EntryPoint = "glGetVideoivNV")]
            public static void GetVideo(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] out int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_present_video]
            /// </summary>
            /// <param name="video_slot">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "NV_present_video", Version = "", EntryPoint = "glGetVideoivNV")]
            public static unsafe void GetVideo(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_present_video]
            /// </summary>
            /// <param name="video_slot">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "NV_present_video", Version = "", EntryPoint = "glGetVideoui64vNV")]
            public static void GetVideo(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] ulong[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_present_video]
            /// </summary>
            /// <param name="video_slot">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "NV_present_video", Version = "", EntryPoint = "glGetVideoui64vNV")]
            public static void GetVideo(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] out ulong @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_present_video]
            /// </summary>
            /// <param name="video_slot">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "NV_present_video", Version = "", EntryPoint = "glGetVideoui64vNV")]
            public static unsafe void GetVideo(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] ulong* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_present_video]
            /// </summary>
            /// <param name="video_slot">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "NV_present_video", Version = "", EntryPoint = "glGetVideouivNV")]
            public static void GetVideo(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] uint[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_present_video]
            /// </summary>
            /// <param name="video_slot">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "NV_present_video", Version = "", EntryPoint = "glGetVideouivNV")]
            public static void GetVideo(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] out uint @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_present_video]
            /// </summary>
            /// <param name="video_slot">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "NV_present_video", Version = "", EntryPoint = "glGetVideouivNV")]
            public static unsafe void GetVideo(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] uint* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_present_video]
            /// </summary>
            /// <param name="video_slot">
            /// </param>
            /// <param name="minPresentTime">
            /// </param>
            /// <param name="beginPresentTimeId">
            /// </param>
            /// <param name="presentDurationId">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="target0">
            /// </param>
            /// <param name="fill0">
            /// </param>
            /// <param name="target1">
            /// </param>
            /// <param name="fill1">
            /// </param>
            /// <param name="target2">
            /// </param>
            /// <param name="fill2">
            /// </param>
            /// <param name="target3">
            /// </param>
            /// <param name="fill3">
            /// </param>
            [AutoGenerated(Category = "NV_present_video", Version = "", EntryPoint = "glPresentFrameDualFillNV")]
            public static void PresentFrameDualFill(uint video_slot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, OpenTK.Graphics.OpenGL.NvPresentVideo type, OpenTK.Graphics.OpenGL.NvPresentVideo target0, uint fill0, OpenTK.Graphics.OpenGL.NvPresentVideo target1, uint fill1, OpenTK.Graphics.OpenGL.NvPresentVideo target2, uint fill2, OpenTK.Graphics.OpenGL.NvPresentVideo target3, uint fill3)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_present_video]
            /// </summary>
            /// <param name="video_slot">
            /// </param>
            /// <param name="minPresentTime">
            /// </param>
            /// <param name="beginPresentTimeId">
            /// </param>
            /// <param name="presentDurationId">
            /// </param>
            /// <param name="type">
            /// </param>
            /// <param name="target0">
            /// </param>
            /// <param name="fill0">
            /// </param>
            /// <param name="key0">
            /// </param>
            /// <param name="target1">
            /// </param>
            /// <param name="fill1">
            /// </param>
            /// <param name="key1">
            /// </param>
            [AutoGenerated(Category = "NV_present_video", Version = "", EntryPoint = "glPresentFrameKeyedNV")]
            public static void PresentFrameKeye(uint video_slot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, OpenTK.Graphics.OpenGL.NvPresentVideo type, OpenTK.Graphics.OpenGL.NvPresentVideo target0, uint fill0, uint key0, OpenTK.Graphics.OpenGL.NvPresentVideo target1, uint fill1, uint key1)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(1153)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetVideoi64vNV(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] long* @params);

            [Slot(1154)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetVideoivNV(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params);

            [Slot(1155)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetVideoui64vNV(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] ulong* @params);

            [Slot(1156)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetVideouivNV(uint video_slot, OpenTK.Graphics.OpenGL.NvPresentVideo pname, [OutAttribute, CountAttribute(Computed = "pname")] uint* @params);

            [Slot(1728)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glPresentFrameDualFillNV(uint video_slot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, OpenTK.Graphics.OpenGL.NvPresentVideo type, OpenTK.Graphics.OpenGL.NvPresentVideo target0, uint fill0, OpenTK.Graphics.OpenGL.NvPresentVideo target1, uint fill1, OpenTK.Graphics.OpenGL.NvPresentVideo target2, uint fill2, OpenTK.Graphics.OpenGL.NvPresentVideo target3, uint fill3);

            [Slot(1729)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glPresentFrameKeyedNV(uint video_slot, ulong minPresentTime, uint beginPresentTimeId, uint presentDurationId, OpenTK.Graphics.OpenGL.NvPresentVideo type, OpenTK.Graphics.OpenGL.NvPresentVideo target0, uint fill0, uint key0, OpenTK.Graphics.OpenGL.NvPresentVideo target1, uint fill1, uint key1);
        }
    }
}
