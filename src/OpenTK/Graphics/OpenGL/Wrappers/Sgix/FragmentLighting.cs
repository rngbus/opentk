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
        /// Contains native bindings to functions in the category "FragmentLighting" in the extension "Sgix".
        /// </summary>
        public static partial class Sgix
        {
            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="mode">
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentColorMaterialSGIX")]
            public static void FragmentColorMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter mode)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="pname">
            /// </param>
            /// <param name="param">
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightModelfSGIX")]
            public static void FragmentLightModel(OpenTK.Graphics.OpenGL.FragmentLightModelParameterSgix pname, float param)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightModelfvSGIX")]
            public static void FragmentLightModel(OpenTK.Graphics.OpenGL.FragmentLightModelParameterSgix pname, [CountAttribute(Computed = "pname")] float[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightModelfvSGIX")]
            public static void FragmentLightModel(OpenTK.Graphics.OpenGL.FragmentLightModelParameterSgix pname, [CountAttribute(Computed = "pname")] ref float @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightModelfvSGIX")]
            public static unsafe void FragmentLightModel(OpenTK.Graphics.OpenGL.FragmentLightModelParameterSgix pname, [CountAttribute(Computed = "pname")] float* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="pname">
            /// </param>
            /// <param name="param">
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightModeliSGIX")]
            public static void FragmentLightModel(OpenTK.Graphics.OpenGL.FragmentLightModelParameterSgix pname, int param)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightModelivSGIX")]
            public static void FragmentLightModel(OpenTK.Graphics.OpenGL.FragmentLightModelParameterSgix pname, [CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightModelivSGIX")]
            public static void FragmentLightModel(OpenTK.Graphics.OpenGL.FragmentLightModelParameterSgix pname, [CountAttribute(Computed = "pname")] ref int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightModelivSGIX")]
            public static unsafe void FragmentLightModel(OpenTK.Graphics.OpenGL.FragmentLightModelParameterSgix pname, [CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="light">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="param">
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightfSGIX")]
            public static void FragmentLight(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, float param)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="light">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightfvSGIX")]
            public static void FragmentLight(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [CountAttribute(Computed = "pname")] float[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="light">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightfvSGIX")]
            public static void FragmentLight(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [CountAttribute(Computed = "pname")] ref float @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="light">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightfvSGIX")]
            public static unsafe void FragmentLight(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [CountAttribute(Computed = "pname")] float* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="light">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="param">
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightiSGIX")]
            public static void FragmentLight(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, int param)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="light">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightivSGIX")]
            public static void FragmentLight(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="light">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightivSGIX")]
            public static void FragmentLight(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [CountAttribute(Computed = "pname")] ref int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="light">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentLightivSGIX")]
            public static unsafe void FragmentLight(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="param">
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentMaterialfSGIX")]
            public static void FragmentMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, float param)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentMaterialfvSGIX")]
            public static void FragmentMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [CountAttribute(Computed = "pname")] float[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentMaterialfvSGIX")]
            public static void FragmentMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [CountAttribute(Computed = "pname")] ref float @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentMaterialfvSGIX")]
            public static unsafe void FragmentMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [CountAttribute(Computed = "pname")] float* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="param">
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentMaterialiSGIX")]
            public static void FragmentMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, int param)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentMaterialivSGIX")]
            public static void FragmentMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentMaterialivSGIX")]
            public static void FragmentMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [CountAttribute(Computed = "pname")] ref int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glFragmentMaterialivSGIX")]
            public static unsafe void FragmentMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="light">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glGetFragmentLightfvSGIX")]
            public static void GetFragmentLight(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [OutAttribute, CountAttribute(Computed = "pname")] float[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="light">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glGetFragmentLightfvSGIX")]
            public static void GetFragmentLight(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [OutAttribute, CountAttribute(Computed = "pname")] out float @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="light">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glGetFragmentLightfvSGIX")]
            public static unsafe void GetFragmentLight(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [OutAttribute, CountAttribute(Computed = "pname")] float* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="light">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glGetFragmentLightivSGIX")]
            public static void GetFragmentLight(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [OutAttribute, CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="light">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glGetFragmentLightivSGIX")]
            public static void GetFragmentLight(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [OutAttribute, CountAttribute(Computed = "pname")] out int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="light">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glGetFragmentLightivSGIX")]
            public static unsafe void GetFragmentLight(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glGetFragmentMaterialfvSGIX")]
            public static void GetFragmentMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] float[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glGetFragmentMaterialfvSGIX")]
            public static void GetFragmentMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] out float @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glGetFragmentMaterialfvSGIX")]
            public static unsafe void GetFragmentMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] float* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glGetFragmentMaterialivSGIX")]
            public static void GetFragmentMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] int[] @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glGetFragmentMaterialivSGIX")]
            public static void GetFragmentMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] out int @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="face">
            /// </param>
            /// <param name="pname">
            /// </param>
            /// <param name="@params">
            /// [length: COMPSIZE(pname)]
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glGetFragmentMaterialivSGIX")]
            public static unsafe void GetFragmentMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: SGIX_fragment_lighting]
            /// </summary>
            /// <param name="pname">
            /// </param>
            /// <param name="param">
            /// </param>
            [AutoGenerated(Category = "SGIX_fragment_lighting", Version = "", EntryPoint = "glLightEnviSGIX")]
            public static void LightEnv(OpenTK.Graphics.OpenGL.LightEnvParameterSgix pname, int param)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(613)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFragmentColorMaterialSGIX(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter mode);

            [Slot(619)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFragmentLightModelfSGIX(OpenTK.Graphics.OpenGL.FragmentLightModelParameterSgix pname, float param);

            [Slot(620)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glFragmentLightModelfvSGIX(OpenTK.Graphics.OpenGL.FragmentLightModelParameterSgix pname, [CountAttribute(Computed = "pname")] float* @params);

            [Slot(621)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFragmentLightModeliSGIX(OpenTK.Graphics.OpenGL.FragmentLightModelParameterSgix pname, int param);

            [Slot(622)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glFragmentLightModelivSGIX(OpenTK.Graphics.OpenGL.FragmentLightModelParameterSgix pname, [CountAttribute(Computed = "pname")] int* @params);

            [Slot(615)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFragmentLightfSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, float param);

            [Slot(616)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glFragmentLightfvSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [CountAttribute(Computed = "pname")] float* @params);

            [Slot(617)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFragmentLightiSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, int param);

            [Slot(618)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glFragmentLightivSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [CountAttribute(Computed = "pname")] int* @params);

            [Slot(623)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFragmentMaterialfSGIX(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, float param);

            [Slot(624)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glFragmentMaterialfvSGIX(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [CountAttribute(Computed = "pname")] float* @params);

            [Slot(625)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFragmentMaterialiSGIX(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, int param);

            [Slot(626)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glFragmentMaterialivSGIX(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [CountAttribute(Computed = "pname")] int* @params);

            [Slot(780)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetFragmentLightfvSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [OutAttribute, CountAttribute(Computed = "pname")] float* @params);

            [Slot(781)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetFragmentLightivSGIX(OpenTK.Graphics.OpenGL.SgixFragmentLighting light, OpenTK.Graphics.OpenGL.SgixFragmentLighting pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params);

            [Slot(782)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetFragmentMaterialfvSGIX(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] float* @params);

            [Slot(783)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetFragmentMaterialivSGIX(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, [OutAttribute, CountAttribute(Computed = "pname")] int* @params);

            [Slot(1267)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glLightEnviSGIX(OpenTK.Graphics.OpenGL.LightEnvParameterSgix pname, int param);
        }
    }
}
