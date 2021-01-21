﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT License.
// See the LICENSE file in the project root for more information.

//
// Revision history:
//
// ER - October 2013 - Created this file.
//

using Reaqtor.Remoting.Metadata;

namespace Reaqtor.Remoting.Platform
{
    internal sealed class AppDomainMetadataService : ReactiveServiceBase, IReactiveMetadataService
    {
        public AppDomainMetadataService()
#pragma warning disable CA2000 // Dispose objects before losing scope. (Ownership transfer.)
            : base(new AppDomainRunnable("MetadataService", typeof(StorageConnection)), ReactiveServiceType.MetadataService)
#pragma warning restore CA2000
        {
        }
    }
}
