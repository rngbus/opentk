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

namespace OpenTK.Graphics.ES30
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AngleFramebufferBlit
    {
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_BINDING_ANGLE = 0x8CA6
        /// </summary>
        DrawFramebufferBindingAngle = 0x8ca6,

        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_ANGLE = 0x8CA8
        /// </summary>
        ReadFramebufferAngle = 0x8ca8,

        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_ANGLE = 0x8CA9
        /// </summary>
        DrawFramebufferAngle = 0x8ca9,

        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_BINDING_ANGLE = 0x8CAA
        /// </summary>
        ReadFramebufferBindingAngle = 0x8caa
    }
}
