// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.ComponentModel;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods for setting up Zoom WebHooks in an <see cref="IMvcBuilder" />.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ZoomMvcBuilderExtensions
    {
        /// <summary>
        /// <para>
        /// Add Zoom WebHook configuration and services to the specified <paramref name="builder"/>. See
        /// <see href="https://developer.Zoom.com/webhooks/"/> for additional details about Zoom WebHook requests.
        /// </para>
        /// <para>
        /// The '<c>WebHooks:Zoom:SecretKey:default</c>' configuration value contains the secret key for Zoom
        /// WebHook URIs of the form '<c>https://{host}/api/webhooks/incoming/Zoom</c>'.
        /// '<c>WebHooks:Zoom:SecretKey:{id}</c>' configuration values contain secret keys for Zoom WebHook URIs of
        /// the form '<c>https://{host}/api/webhooks/incoming/Zoom/{id}</c>'.
        /// </para>
        /// </summary>
        /// <param name="builder">The <see cref="IMvcBuilder" /> to configure.</param>
        /// <returns>The <paramref name="builder"/>.</returns>
        public static IMvcBuilder AddZoomWebHooks(this IMvcBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            ZoomServiceCollectionSetup.AddZoomServices(builder.Services);

            return builder.AddWebHooks();
        }
    }
}
