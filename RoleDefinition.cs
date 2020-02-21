using System.Collections.ObjectModel;

namespace Azure.Security.KeyVault.AccessControl
{
    public class RoleDefinition
    {
        internal RoleDefinitionProperties _properties;

        // Read-only model for now.
        protected RoleDefinition()
        {
        }

        public string Id { get; }

        // These are flattened from RoleDefinitionProperties.
        public string Name => _properties.RoleName;
        public string Description => _properties.Description;
        public string Type => _properties.Type;
        public Collection<KeyVaultPermission> Permissions => _properties.Permissions;
        public Collection<string> AssignableScopes => _properties.AssignableScopes;
    }
}