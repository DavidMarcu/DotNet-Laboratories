using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop
{
    public class Author : IValidatableObject
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public List<Book> Books { get; private set; }

        private Author()
        {
            // EF
        }

        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Books = new List<Book>();
        }

        public void Update(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (FirstName.Length < 50)
            {
                yield return new ValidationResult("FirstName must be at least 50");
            }
        }
    }
}
