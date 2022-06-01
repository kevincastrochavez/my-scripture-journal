using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string Book { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
        public string Notes { get; set; } = string.Empty;
    }
}