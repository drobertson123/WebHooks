// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.WebHooks.Filters;
using Microsoft.AspNetCore.WebHooks.Metadata;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Methods to add services for the Zoom receiver.
    /// </summary>
    internal static class ZoomServiceCollectionSetup
    {
        /// <summary>
        /// Add services for the Zoom receiver.
        /// </summary>
        /// <param name="services">The <see cref="IServiceCollection"/> to update.</param>
        public static void AddZoomServices(IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            WebHookMetadata.Register<ZoomMetadata>(services);
            services.TryAddSingleton<ZoomVerifySignatureFilter>();
        }
    }
}
