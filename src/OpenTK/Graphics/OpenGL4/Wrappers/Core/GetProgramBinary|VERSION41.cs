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
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Return a binary representation of a program object's compiled and linked executable source
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object whose binary representation to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer whose address is given by binary.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable to receive the number of bytes written into binary.
        /// </param>
        /// <param name="binaryFormat">
        /// [length: 1]
        /// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
        /// </param>
        /// <param name="binary">
        /// [length: bufSize]
        /// Specifies the address an array into which the GL will return program's binary representation.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glGetProgramBinary")]
        public static void GetProgramBinary(uint program, int bufSize, [OutAttribute, CountAttribute(Count = 1)] out int length, [OutAttribute, CountAttribute(Count = 1)] out OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, [OutAttribute, CountAttribute(Parameter = "bufSize")] IntPtr binary)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Return a binary representation of a program object's compiled and linked executable source
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object whose binary representation to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer whose address is given by binary.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable to receive the number of bytes written into binary.
        /// </param>
        /// <param name="binaryFormat">
        /// [length: 1]
        /// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
        /// </param>
        /// <param name="binary">
        /// [length: bufSize]
        /// Specifies the address an array into which the GL will return program's binary representation.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glGetProgramBinary")]
        public static void GetProgramBinary<T4>(uint program, int bufSize, [OutAttribute, CountAttribute(Count = 1)] out int length, [OutAttribute, CountAttribute(Count = 1)] out OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, [InAttribute, OutAttribute, CountAttribute(Parameter = "bufSize")] T4[] binary)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Return a binary representation of a program object's compiled and linked executable source
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object whose binary representation to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer whose address is given by binary.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable to receive the number of bytes written into binary.
        /// </param>
        /// <param name="binaryFormat">
        /// [length: 1]
        /// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
        /// </param>
        /// <param name="binary">
        /// [length: bufSize]
        /// Specifies the address an array into which the GL will return program's binary representation.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glGetProgramBinary")]
        public static void GetProgramBinary<T4>(uint program, int bufSize, [OutAttribute, CountAttribute(Count = 1)] out int length, [OutAttribute, CountAttribute(Count = 1)] out OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, [InAttribute, OutAttribute, CountAttribute(Parameter = "bufSize")] T4[,] binary)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Return a binary representation of a program object's compiled and linked executable source
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object whose binary representation to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer whose address is given by binary.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable to receive the number of bytes written into binary.
        /// </param>
        /// <param name="binaryFormat">
        /// [length: 1]
        /// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
        /// </param>
        /// <param name="binary">
        /// [length: bufSize]
        /// Specifies the address an array into which the GL will return program's binary representation.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glGetProgramBinary")]
        public static void GetProgramBinary<T4>(uint program, int bufSize, [OutAttribute, CountAttribute(Count = 1)] out int length, [OutAttribute, CountAttribute(Count = 1)] out OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, [InAttribute, OutAttribute, CountAttribute(Parameter = "bufSize")] T4[,,] binary)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Return a binary representation of a program object's compiled and linked executable source
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object whose binary representation to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer whose address is given by binary.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable to receive the number of bytes written into binary.
        /// </param>
        /// <param name="binaryFormat">
        /// [length: 1]
        /// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
        /// </param>
        /// <param name="binary">
        /// [length: bufSize]
        /// Specifies the address an array into which the GL will return program's binary representation.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glGetProgramBinary")]
        public static void GetProgramBinary<T4>(uint program, int bufSize, [OutAttribute, CountAttribute(Count = 1)] out int length, [OutAttribute, CountAttribute(Count = 1)] out OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, [InAttribute, OutAttribute, CountAttribute(Parameter = "bufSize")] ref T4 binary)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Return a binary representation of a program object's compiled and linked executable source
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object whose binary representation to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer whose address is given by binary.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable to receive the number of bytes written into binary.
        /// </param>
        /// <param name="binaryFormat">
        /// [length: 1]
        /// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
        /// </param>
        /// <param name="binary">
        /// [length: bufSize]
        /// Specifies the address an array into which the GL will return program's binary representation.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glGetProgramBinary")]
        public static unsafe void GetProgramBinary(uint program, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Count = 1)] OpenTK.Graphics.OpenGL4.BinaryFormat* binaryFormat, [OutAttribute, CountAttribute(Parameter = "bufSize")] IntPtr binary)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Return a binary representation of a program object's compiled and linked executable source
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object whose binary representation to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer whose address is given by binary.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable to receive the number of bytes written into binary.
        /// </param>
        /// <param name="binaryFormat">
        /// [length: 1]
        /// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
        /// </param>
        /// <param name="binary">
        /// [length: bufSize]
        /// Specifies the address an array into which the GL will return program's binary representation.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glGetProgramBinary")]
        public static unsafe void GetProgramBinary<T4>(uint program, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Count = 1)] OpenTK.Graphics.OpenGL4.BinaryFormat* binaryFormat, [InAttribute, OutAttribute, CountAttribute(Parameter = "bufSize")] T4[] binary)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Return a binary representation of a program object's compiled and linked executable source
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object whose binary representation to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer whose address is given by binary.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable to receive the number of bytes written into binary.
        /// </param>
        /// <param name="binaryFormat">
        /// [length: 1]
        /// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
        /// </param>
        /// <param name="binary">
        /// [length: bufSize]
        /// Specifies the address an array into which the GL will return program's binary representation.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glGetProgramBinary")]
        public static unsafe void GetProgramBinary<T4>(uint program, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Count = 1)] OpenTK.Graphics.OpenGL4.BinaryFormat* binaryFormat, [InAttribute, OutAttribute, CountAttribute(Parameter = "bufSize")] T4[,] binary)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Return a binary representation of a program object's compiled and linked executable source
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object whose binary representation to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer whose address is given by binary.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable to receive the number of bytes written into binary.
        /// </param>
        /// <param name="binaryFormat">
        /// [length: 1]
        /// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
        /// </param>
        /// <param name="binary">
        /// [length: bufSize]
        /// Specifies the address an array into which the GL will return program's binary representation.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glGetProgramBinary")]
        public static unsafe void GetProgramBinary<T4>(uint program, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Count = 1)] OpenTK.Graphics.OpenGL4.BinaryFormat* binaryFormat, [InAttribute, OutAttribute, CountAttribute(Parameter = "bufSize")] T4[,,] binary)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Return a binary representation of a program object's compiled and linked executable source
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object whose binary representation to retrieve.
        /// </param>
        /// <param name="bufSize">
        /// Specifies the size of the buffer whose address is given by binary.
        /// </param>
        /// <param name="length">
        /// [length: 1]
        /// Specifies the address of a variable to receive the number of bytes written into binary.
        /// </param>
        /// <param name="binaryFormat">
        /// [length: 1]
        /// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
        /// </param>
        /// <param name="binary">
        /// [length: bufSize]
        /// Specifies the address an array into which the GL will return program's binary representation.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glGetProgramBinary")]
        public static unsafe void GetProgramBinary<T4>(uint program, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Count = 1)] OpenTK.Graphics.OpenGL4.BinaryFormat* binaryFormat, [InAttribute, OutAttribute, CountAttribute(Parameter = "bufSize")] ref T4 binary)
            where T4 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Load a program object with a program binary
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object into which to load a program binary.
        /// </param>
        /// <param name="binaryFormat">
        /// Specifies the format of the binary data in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address an array containing the binary to be loaded into program.
        /// </param>
        /// <param name="length">
        /// Specifies the number of bytes contained in binary.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glProgramBinary")]
        public static void ProgramBinary(uint program, OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, [CountAttribute(Parameter = "length")] IntPtr binary, int length)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Load a program object with a program binary
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object into which to load a program binary.
        /// </param>
        /// <param name="binaryFormat">
        /// Specifies the format of the binary data in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address an array containing the binary to be loaded into program.
        /// </param>
        /// <param name="length">
        /// Specifies the number of bytes contained in binary.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glProgramBinary")]
        public static void ProgramBinary<T2>(uint program, OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] T2[] binary, int length)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Load a program object with a program binary
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object into which to load a program binary.
        /// </param>
        /// <param name="binaryFormat">
        /// Specifies the format of the binary data in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address an array containing the binary to be loaded into program.
        /// </param>
        /// <param name="length">
        /// Specifies the number of bytes contained in binary.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glProgramBinary")]
        public static void ProgramBinary<T2>(uint program, OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] T2[,] binary, int length)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Load a program object with a program binary
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object into which to load a program binary.
        /// </param>
        /// <param name="binaryFormat">
        /// Specifies the format of the binary data in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address an array containing the binary to be loaded into program.
        /// </param>
        /// <param name="length">
        /// Specifies the number of bytes contained in binary.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glProgramBinary")]
        public static void ProgramBinary<T2>(uint program, OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] T2[,,] binary, int length)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.1 or ARB_get_program_binary|VERSION_4_1]
        /// Load a program object with a program binary
        /// </summary>
        /// <param name="program">
        /// Specifies the name of a program object into which to load a program binary.
        /// </param>
        /// <param name="binaryFormat">
        /// Specifies the format of the binary data in binary.
        /// </param>
        /// <param name="binary">
        /// [length: length]
        /// Specifies the address an array containing the binary to be loaded into program.
        /// </param>
        /// <param name="length">
        /// Specifies the number of bytes contained in binary.
        /// </param>
        [AutoGenerated(Category = "ARB_get_program_binary|VERSION_4_1", Version = "4.1", EntryPoint = "glProgramBinary")]
        public static void ProgramBinary<T2>(uint program, OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, [InAttribute, OutAttribute, CountAttribute(Parameter = "length")] ref T2 binary, int length)
            where T2 : struct
        {
            throw new BindingsNotRewrittenException();
        }

        [Slot(499)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGetProgramBinary(uint program, int bufSize, [OutAttribute, CountAttribute(Count = 1)] int* length, [OutAttribute, CountAttribute(Count = 1)] OpenTK.Graphics.OpenGL4.BinaryFormat* binaryFormat, [OutAttribute, CountAttribute(Parameter = "bufSize")] IntPtr binary);

        [Slot(834)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramBinary(uint program, OpenTK.Graphics.OpenGL4.BinaryFormat binaryFormat, [CountAttribute(Parameter = "length")] IntPtr binary, int length);
    }
}
