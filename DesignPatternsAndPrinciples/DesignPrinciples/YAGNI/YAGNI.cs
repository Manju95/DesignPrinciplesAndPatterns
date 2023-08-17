using System;
namespace DotnetTraining.DesignPrinciples
{
	public class YAGNI
	{
		// YAGNI principle says only keep the fields and methods whicg are required currently
		public void ShowAuthor()
		{
            Author author = new Author("Manjunath", "Somawagol");
			Console.Write(author.GetAuthorName());
        }
	}

	class Author
	{
		// added only first and last name, not the other like DOB, middlae name, age as they do not required to business
		private string firstName;
		private string lastName;

		public Author(string fname, string lname)
		{
			firstName = fname;
			lastName = lname;
		}

		public string GetAuthorName()
		{
			return $"{firstName} {lastName}";
		}
	}
}

