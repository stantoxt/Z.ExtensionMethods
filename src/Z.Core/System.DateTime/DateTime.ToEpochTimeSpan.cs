// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     A DateTime extension method that converts the @this to an epoch time span.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>@this as a TimeSpan.</returns>
    public static TimeSpan ToEpochTimeSpan(this DateTime @this)
    {
        return @this.Subtract(new DateTime(1970, 1, 1));
    }
}