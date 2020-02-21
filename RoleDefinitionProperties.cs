using System.Collections.ObjectModel;

namespace Azure.Security.KeyVault.AccessControl
{
    internal struct RoleDefinitionProperties
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public Collection<KeyVaultPermission> Permissions { get; }
        public Collection<string> AssignableScopes { get; }
    }
}