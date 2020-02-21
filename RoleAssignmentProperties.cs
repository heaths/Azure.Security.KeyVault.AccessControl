namespace Azure.Security.KeyVault.AccessControl
{
    public class RoleAssignmentProperties
    {
        public RoleAssignmentProperties(string roleDefinitionId, string principalId)
        {
            RoleDefinitionId = roleDefinitionId;
            PrincipalId = principalId;
        }

        // Scope is not defined because it's not settable on a request-only model.
        public string RoleDefinitionId { get; }
        public string PrincipalId { get; }
    }
}