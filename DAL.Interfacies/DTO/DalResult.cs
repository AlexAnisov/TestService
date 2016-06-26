using System;

namespace DAL.Interface.DTO
{
    public class DalResult
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TestId { get; set; }
        public int Mark { get; set; }
        public DateTime Date { get; set; }
    }
}
