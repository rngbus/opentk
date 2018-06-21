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

namespace OpenTK.Graphics.ES20
{
    /// <summary>
    /// Used in GL.Apple.GetSync
    /// </summary>
    public enum SyncParameterName
    {
        /// <summary>
        /// Original was GL_OBJECT_TYPE = 0x9112
        /// </summary>
        ObjectType = 0x9112,

        /// <summary>
        /// Original was GL_OBJECT_TYPE_APPLE = 0x9112
        /// </summary>
        ObjectTypeApple = 0x9112,

        /// <summary>
        /// Original was GL_SYNC_CONDITION = 0x9113
        /// </summary>
        SyncCondition = 0x9113,

        /// <summary>
        /// Original was GL_SYNC_CONDITION_APPLE = 0x9113
        /// </summary>
        SyncConditionApple = 0x9113,

        /// <summary>
        /// Original was GL_SYNC_STATUS = 0x9114
        /// </summary>
        SyncStatus = 0x9114,

        /// <summary>
        /// Original was GL_SYNC_STATUS_APPLE = 0x9114
        /// </summary>
        SyncStatusApple = 0x9114,

        /// <summary>
        /// Original was GL_SYNC_FLAGS = 0x9115
        /// </summary>
        SyncFlags = 0x9115,

        /// <summary>
        /// Original was GL_SYNC_FLAGS_APPLE = 0x9115
        /// </summary>
        SyncFlagsApple = 0x9115
    }
}
