using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;

namespace MyScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyScriptureJournalContext>>()))
            {
                if (context == null || context.Scripture == null)
                {
                    throw new ArgumentNullException("Null MyScriptureJournalContext");
                }

                // Look for any movies.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Book = "1 Nephi 3:7",
                        EntryDate = DateTime.Parse("1989-2-12"),
                        Notes = "This is just a filler text for the Notes field in the MyScriptureJorunal application for the .NET class taught in C# in the Spring semester, 2022"
                    },

                    new Scripture
                    {
                        Book = "Ether 12:6 ",
                        EntryDate = DateTime.Parse("1984-3-13"),
                        Notes = "This is just a filler text for the Notes field in the MyScriptureJorunal application for the .NET class taught in C# in the Spring semester, 2022"
                    },

                    new Scripture
                    {
                        Book = "3 Nephi 27:27",
                        EntryDate = DateTime.Parse("1986-2-23"),
                        Notes = "This is just a filler text for the Notes field in the MyScriptureJorunal application for the .NET class taught in C# in the Spring semester, 2022"
                    },

                    new Scripture
                    {
                        Book = "Moroni 10:3-5",
                        EntryDate = DateTime.Parse("1959-4-15"),
                        Notes = "This is just a filler text for the Notes field in the MyScriptureJorunal application for the .NET class taught in C# in the Spring semester, 2022"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}