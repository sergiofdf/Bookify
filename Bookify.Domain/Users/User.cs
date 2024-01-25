using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Users;

public sealed class User : Entity
{
	private User(Guid id, FirstName firstname, LastName lastName, Email email) : base(id)
	{
		FirstName = firstname;
		LastName = lastName;
		Email = email;
	}

	public FirstName FirstName { get; private set; }
	public LastName LastName { get; private set; }
	public Email Email { get; private set; }

	public static User Create(FirstName firstname, LastName lastName, Email email)
	{
		var user = new User(Guid.NewGuid(), firstname, lastName, email);

		return user;
	}
}
