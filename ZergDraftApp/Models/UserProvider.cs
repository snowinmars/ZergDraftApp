using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZergDraftApp.Models
{
	public enum UserRole
	{
		None = 0,
		User = 1,
		Admin = 2,
	}

	public static class UserProvider
	{
		public static UserRole Role { get; set; }
	}
}