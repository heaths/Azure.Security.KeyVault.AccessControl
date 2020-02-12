namespace Azure.Security.KeyVault.AccessControl
{
    public readonly struct RoleAssignmentFilter
    {
        public RoleAssignmentFilter(string principalId)
        {
            PrincipalId = principalId;
        }

        public string PrincipalId { get; }

        // Not allowed with 
        public static RoleAssignmentFilter AtScope() => default;

        public override string ToString() => null;
    }
}