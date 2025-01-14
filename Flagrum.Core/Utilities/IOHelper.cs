﻿using System;
using System.IO;

namespace Flagrum.Core.Utilities;

public static class IOHelper
{
    public static string GetExecutingDirectory()
    {
        return Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
    }

    public static string GetWebRoot()
    {
        return $"{GetExecutingDirectory()}\\wwwroot";
    }
}