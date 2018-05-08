// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.ComponentModel;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extension methods for setting up AWS WebHooks in an <see cref="IMvcBuilder" />.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class AWSMvcBuilderExtensions
    {
        /// <summary>
        /// <para>
        /// Add AWS WebHook configuration and services to the specified <paramref name="builder"/>. See
        /// <see href="https://developer.AWS.com/webhooks/"/> for additional details about AWS WebHook requests.
        /// </para>
        /// <para>
        /// The '<c>WebHooks:AWS:SecretKey:default</c>' configuration value contains the secret key for AWS
        /// WebHook URIs of the form '<c>https://{host}/api/webhooks/incoming/AWS</c>'.
        /// '<c>WebHooks:AWS:SecretKey:{id}</c>' configuration values contain secret keys for AWS WebHook URIs of
        /// the form '<c>https://{host}/api/webhooks/incoming/AWS/{id}</c>'.
        /// </para>
        /// </summary>
        /// <param name="builder">The <see cref="IMvcBuilder" /> to configure.</param>
        /// <returns>The <paramref name="builder"/>.</returns>
        public static IMvcBuilder AddAWSWebHooks(this IMvcBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            AWSServiceCollectionSetup.AddAWSServices(builder.Services);

            return builder.AddWebHooks();
        }
    }
}
