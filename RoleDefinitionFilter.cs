namespace Azure.Security.KeyVault.AccessControl
{
    public readonly struct RoleDefinitionFilter
    {
        public RoleDefinitionFilter(string roleName)
        {
            RoleName = roleName;
        }

        public string RoleName { get; }

        public static RoleDefinitionFilter AtScopeAndBelow() => default;

        public override string ToString() => null;
    }
}