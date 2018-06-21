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
        /// [requires: v1.4 or ARB_imaging|VERSION_1_4]
        /// Set the blend color
        /// </summary>
        /// <param name="red">
        /// specify the components of BlendColor
        /// </param>
        /// <param name="green">
        /// specify the components of BlendColor
        /// </param>
        /// <param name="blue">
        /// specify the components of BlendColor
        /// </param>
        /// <param name="alpha">
        /// specify the components of BlendColor
        /// </param>
        [AutoGenerated(Category = "ARB_imaging|VERSION_1_4", Version = "1.4", EntryPoint = "glBlendColor")]
        public static void BlendColor(float red, float green, float blue, float alpha)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v1.4 or ARB_imaging|VERSION_1_4]
        /// Specify the equation used for both the RGB blend equation and the Alpha blend equation
        /// </summary>
        /// <param name="mode">
        /// specifies how source and destination colors are combined. It must be FuncAdd, FuncSubtract, FuncReverseSubtract, Min, Max.
        /// </param>
        [AutoGenerated(Category = "ARB_imaging|VERSION_1_4", Version = "1.4", EntryPoint = "glBlendEquation")]
        public static void BlendEquation(OpenTK.Graphics.OpenGL4.BlendEquationMode mode)
        {
            throw new BindingsNotRewrittenException();
        }

        [Slot(39)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBlendColor(float red, float green, float blue, float alpha);

        [Slot(40)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBlendEquation(OpenTK.Graphics.OpenGL4.BlendEquationMode mode);
    }
}
