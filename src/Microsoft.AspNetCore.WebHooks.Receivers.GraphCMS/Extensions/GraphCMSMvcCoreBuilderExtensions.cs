// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.ComponentModel;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods for setting up GraphCMS WebHooks in an <see cref="IMvcCoreBuilder" />.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class GraphCMSMvcCoreBuilderExtensions
    {
        /// <summary>
        /// <para>
        /// Add GraphCMS WebHook configuration and services to the specified <paramref name="builder"/>. See
        /// <see href="https://developer.GraphCMS.com/webhooks/"/> for additional details about GraphCMS WebHook requests.
        /// </para>
        /// <para>
        /// The '<c>WebHooks:GraphCMS:SecretKey:default</c>' configuration value contains the secret key for GraphCMS
        /// WebHook URIs of the form '<c>https://{host}/api/webhooks/incoming/GraphCMS</c>'.
        /// '<c>WebHooks:GraphCMS:SecretKey:{id}</c>' configuration values contain secret keys for GraphCMS WebHook URIs of
        /// the form '<c>https://{host}/api/webhooks/incoming/GraphCMS/{id}</c>'.
        /// </para>
        /// </summary>
        /// <param name="builder">The <see cref="IMvcCoreBuilder" /> to configure.</param>
        /// <returns>The <paramref name="builder"/>.</returns>
        public static IMvcCoreBuilder AddGraphCMSWebHooks(this IMvcCoreBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            GraphCMSServiceCollectionSetup.AddGraphCMSServices(builder.Services);

            return builder
                .AddJsonFormatters()
                .AddWebHooks();
        }
    }
}
