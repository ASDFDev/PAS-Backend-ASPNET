using System;
namespace Setsuna.Models
{
	public class User
	{

		public string Username; // Username for authentication
		public string Saltine; // Unique salt for authentication
		public string Type; // Student, Lecturer, or Administrator
		public string ValidTimes; // Json of all valid class code and times
		public string ClassCode; // Assigned after lecturer calls StartClass
		public string UniqueSecret; // Assigned after lecturer calls StartClass

	}
}
