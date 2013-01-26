#region Copyright 2009 Robert Konklewski
/*
 * CursesSharp
 * 
 * Copyright 2009 Robert Konklewski
 * 
 * This library is free software; you can redistribute it and/or modify it
 * under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation; either version 3 of the License, or (at your
 * option) any later version.
 *
 * This library is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
 * FITNESS FOR A PARTICULAR PURPOSE.  See the GNU Lesser General Public
 * License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * www.gnu.org/licenses/>.
 * 
 */
#endregion

using System;
using System.Runtime.InteropServices;

namespace CursesSharp.Internal
{
    internal static partial class CursesMethods
    {
        internal static void wdelch(IntPtr win)
        {
            int ret = wrap_wdelch(win);
            InternalException.Verify(ret, "wdelch");
        }

        internal static void mvwdelch(IntPtr win, int y, int x)
        {
            int ret = wrap_mvwdelch(win, y, x);
            InternalException.Verify(ret, "mvwdelch");
        }

        [DllImport("CursesWrapper")]
        private static extern int wrap_wdelch(IntPtr win);
        [DllImport("CursesWrapper")]
        private static extern int wrap_mvwdelch(IntPtr win, int y, int x);
    }
}
