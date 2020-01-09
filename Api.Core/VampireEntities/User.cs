using System.Collections.Generic;

namespace Api.Core.VampireEntities
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public ICollection<Character> Characters { get; set; }
    }

    public class UserDTO
    {
	    public int UserId { get; set; }
	    public string Name { get; set; }
	    public string Password { get; set; }
	    public int Role { get; set; }
	    public List<Character> Characters { get; set; }
    }
}