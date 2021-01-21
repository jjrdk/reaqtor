﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT License.
// See the LICENSE file in the project root for more information.

using Reaqtive.Expressions;

namespace Reaqtor.Reliable
{
    public interface IReliableSubscribable<out T> : IQubscribable<T>
    {
    }
}
