using System.Collections.ObjectModel;

namespace Azure.Security.KeyVault.AccessControl
{
    public class KeyVaultPermission
    {
        public KeyVaultPermission()
        {
        }

        // These properties will eventually be read-write so define them as such now so it's not a breaking change later.
        public Collection<string> Actions { get; }
        public Collection<string> NotActions { get; }
        public Collection<string> DataActions { get; }
        public Collection<string> NotDataActions { get; }
    }
}