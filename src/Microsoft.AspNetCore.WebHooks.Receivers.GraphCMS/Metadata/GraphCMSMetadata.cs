// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.WebHooks.Filters;

namespace Microsoft.AspNetCore.WebHooks.Metadata
{
    /// <summary>
    /// An <see cref="IWebHookMetadata"/> service containing metadata about the GraphCMS receiver.
    /// </summary>
    public class GraphCMSMetadata :
        WebHookMetadata,
        IWebHookEventMetadata,
        IWebHookFilterMetadata,
        IWebHookPingRequestMetadata
    {
        private readonly GraphCMSVerifySignatureFilter _verifySignatureFilter;

        /// <summary>
        /// Instantiates a new <see cref="GraphCMSMetadata"/> instance.
        /// </summary>
        /// <param name="verifySignatureFilter">The <see cref="GraphCMSVerifySignatureFilter"/>.</param>
        public GraphCMSMetadata(GraphCMSVerifySignatureFilter verifySignatureFilter)
            : base(GraphCMSConstants.ReceiverName)
        {
            _verifySignatureFilter = verifySignatureFilter;
        }

        // IWebHookBodyTypeMetadataService...

        /// <inheritdoc />
        public override WebHookBodyType BodyType => WebHookBodyType.Json;

        // IWebHookEventMetadata...

        /// <inheritdoc />
        public string ConstantValue => null;

        /// <inheritdoc />
        public string HeaderName => GraphCMSConstants.EventHeaderName;

        /// <inheritdoc />
        public string QueryParameterName => null;

        // IWebHookPingRequestMetadata...

        /// <inheritdoc />
        public string PingEventName => GraphCMSConstants.PingEventName;

        // IWebHookFilterMetadata...

        /// <inheritdoc />
        public void AddFilters(WebHookFilterMetadataContext context)
        {
            context.Results.Add(_verifySignatureFilter);
        }
    }
}
