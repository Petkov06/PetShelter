using System;

[AutoBind]
public class UserRepository : BaseRepository<User, UserDto>, IUserRepository
{
	public UserRepository(UserhelterDbContext context, IMapper mapper) : base(context, mapper)
	{
	}
}
