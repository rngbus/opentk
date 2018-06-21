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

namespace OpenTK.Graphics.ES11
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "DriverControl" in the extension "Qcom".
        /// </summary>
        public static partial class Qcom
        {
            /// <summary>
            /// [requires: QCOM_driver_control]
            /// </summary>
            /// <param name="driverControl">
            /// </param>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glDisableDriverControlQCOM")]
            public static void DisableDriverControl(uint driverControl)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: QCOM_driver_control]
            /// </summary>
            /// <param name="driverControl">
            /// </param>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glEnableDriverControlQCOM")]
            public static void EnableDriverControl(uint driverControl)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: QCOM_driver_control]
            /// </summary>
            /// <param name="driverControl">
            /// </param>
            /// <param name="bufSize">
            /// </param>
            /// <param name="length">
            /// </param>
            /// <param name="driverControlString">
            /// [length: bufSize]
            /// </param>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            public static void GetDriverControlString(uint driverControl, int bufSize, [OutAttribute] int[] length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out String driverControlString)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: QCOM_driver_control]
            /// </summary>
            /// <param name="driverControl">
            /// </param>
            /// <param name="bufSize">
            /// </param>
            /// <param name="length">
            /// </param>
            /// <param name="driverControlString">
            /// [length: bufSize]
            /// </param>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            public static void GetDriverControlString(uint driverControl, int bufSize, [OutAttribute] out int length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out String driverControlString)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: QCOM_driver_control]
            /// </summary>
            /// <param name="driverControl">
            /// </param>
            /// <param name="bufSize">
            /// </param>
            /// <param name="length">
            /// </param>
            /// <param name="driverControlString">
            /// [length: bufSize]
            /// </param>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlStringQCOM")]
            public static unsafe void GetDriverControlString(uint driverControl, int bufSize, [OutAttribute] int* length, [OutAttribute, CountAttribute(Parameter = "bufSize")] out String driverControlString)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: QCOM_driver_control]
            /// </summary>
            /// <param name="num">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="driverControls">
            /// [length: size]
            /// </param>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            public static void GetDriverControl([OutAttribute] int[] num, int size, [OutAttribute, CountAttribute(Parameter = "size")] uint[] driverControls)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: QCOM_driver_control]
            /// </summary>
            /// <param name="num">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="driverControls">
            /// [length: size]
            /// </param>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            public static void GetDriverControl([OutAttribute] out int num, int size, [OutAttribute, CountAttribute(Parameter = "size")] out uint driverControls)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: QCOM_driver_control]
            /// </summary>
            /// <param name="num">
            /// </param>
            /// <param name="size">
            /// </param>
            /// <param name="driverControls">
            /// [length: size]
            /// </param>
            [AutoGenerated(Category = "QCOM_driver_control", Version = "", EntryPoint = "glGetDriverControlsQCOM")]
            public static unsafe void GetDriverControl([OutAttribute] int* num, int size, [OutAttribute, CountAttribute(Parameter = "size")] uint* driverControls)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(77)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glDisableDriverControlQCOM(uint driverControl);

            [Slot(93)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glEnableDriverControlQCOM(uint driverControl);

            [Slot(150)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetDriverControlStringQCOM(uint driverControl, int bufSize, [OutAttribute] int* length, [OutAttribute, CountAttribute(Parameter = "bufSize")] IntPtr driverControlString);

            [Slot(149)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetDriverControlsQCOM([OutAttribute] int* num, int size, [OutAttribute, CountAttribute(Parameter = "size")] uint* driverControls);
        }
    }
}
