using System.Collections.Generic;

namespace Azure.Security.KeyVault.AccessControl
{
    public class RoleDefinitionProperties
    {
        internal RoleDefinitionProperties()
        {
        }

        public string RoleName { get; }
        public string Description { get; }
        public string Type { get; }

        // These should be read-write if we want to later support (perhaps for ARM) updating permissions and scopes.
        // We could always require modifications to be done via construction of another instance, though.
        public IReadOnlyCollection<KeyVaultPermission> Permissions { get; }
        public IReadOnlyCollection<string> AssignableScopes { get; }
    }
}