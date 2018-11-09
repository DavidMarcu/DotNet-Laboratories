using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop
{
    public class Book : IValidatableObject
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public int AuthorId { get; private set; }
        public Author Author { get; private set; }

        private Book()
        {
            // EF
        }

        public Book(string title, Author author)
        {
            Title = title;
            Author = author;
        }

        public void Update(string title, Author author)
        {
            Title = title;
            Author = author;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Title.Length < 50)
            {
                yield return new ValidationResult("Title must be at least 50");
            }
        }
    }
}
