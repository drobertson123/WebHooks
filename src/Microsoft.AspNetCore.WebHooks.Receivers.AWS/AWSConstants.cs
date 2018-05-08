// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.WebHooks
{
    /// <summary>
    /// Well-known names and values used in AWS receivers and handlers.
    /// </summary>
    public static class AWSConstants
    {
        /// <summary>
        /// Gets the name of the AWS WebHook receiver.
        /// </summary>
        public static string ReceiverName => "AWS";
    }
}
