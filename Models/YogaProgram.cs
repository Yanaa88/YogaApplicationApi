using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YogaApplicationApi.Models
{
    public class YogaProgram
    {
        public string? Type { get; set; } 

        public string? Description { get; set; } 

        public Date Date { get; set; }

        public string? ImageUrl { get; set; } 

        public bool isCompleted { get; set; }
    }
}
