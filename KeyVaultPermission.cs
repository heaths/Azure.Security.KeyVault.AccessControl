using System.Collections.Generic;

namespace Azure.Security.KeyVault.AccessControl
{
    public class KeyVaultPermission
    {
        public KeyVaultPermission(IEnumerable<string> actions, IEnumerable<string> notActions, IEnumerable<string> dataActions, IEnumerable<string> notDataActions)
        {
        }

        public IReadOnlyCollection<string> Actions { get; }
        public IReadOnlyCollection<string> NotActions { get; }
        public IReadOnlyCollection<string> DataActions { get; }
        public IReadOnlyCollection<string> NotDataActions { get; }
    }
}