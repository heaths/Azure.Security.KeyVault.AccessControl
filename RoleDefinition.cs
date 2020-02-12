namespace Azure.Security.KeyVault.AccessControl
{
    public class RoleDefinition
    {
        internal RoleDefinition()
        {
        }

        public string Id { get; }
        public string Type { get; }

        public string Name => Properties.RoleName;
        public string Description => Properties.Description;
        public RoleDefinitionProperties Properties { get; }
    }
}