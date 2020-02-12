namespace Azure.Security.KeyVault.AccessControl
{
    public class RoleAssignment
    {
        internal RoleAssignment()
        {
        }

        public string Id { get; }
        public string Name { get; }
        public string Type { get; }

        public string RoleDefinitionId => Properties.RoleDefinitionId;
        public string PrincipalId => Properties.PrincipalId;
        public RoleAssignmentProperties Properties { get; }
    }
}