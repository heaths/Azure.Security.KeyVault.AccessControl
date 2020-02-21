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

        // These are flattened from RoleAssignmentProperties.
        // Being a class, we probably don't want to nest it even as a field but can reuse parsing logic.
        public string Scope { get; }
        public string RoleDefinitionId { get; }
        public string PrincipalId { get; }
    }
}