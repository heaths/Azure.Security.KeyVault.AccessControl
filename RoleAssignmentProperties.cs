namespace Azure.Security.KeyVault.AccessControl
{
    public class RoleAssignmentProperties
    {
        public RoleAssignmentProperties(string roleDefinitionId, string principalId)
        {
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
        }

        public string Scope { get; }
        public string RoleDefinitionId { get; }
        public string PrincipalId { get; }
    }
}