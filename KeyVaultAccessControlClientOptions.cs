using System;
using Azure.Core;

namespace Azure.Security.KeyVault.AccessControl
{
    public class KeyVaultAccessControlClientOptions : ClientOptions
    {
        internal const ServiceVersion LatestVersion = ServiceVersion.V7_2_Preview;

        public enum ServiceVersion
        {
            V7_2_Preview = 0,
        }

        public ServiceVersion Version { get; }

        public KeyVaultAccessControlClientOptions(ServiceVersion version = ServiceVersion.V7_2_Preview)
        {
            Version = version;
        }

        internal string GetVersionString() => Version switch
        {
            ServiceVersion.V7_2_Preview => "7.2-preview",
            _ => throw new ArgumentException(Version.ToString()),
        };
    }
}