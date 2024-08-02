using System;
namespace CarBook.Application.Features.Mediator.Commands.AppUserCommands
{
	public class CreateAppUserCommand
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}

