using System;

[AutoBind]
public class RoleRepository : BaseRepository<Role, RoleDto>, IRoleRepository
{
	public RoleRepository(RolehelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}
}
