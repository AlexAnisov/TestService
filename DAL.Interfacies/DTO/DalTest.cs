﻿namespace DAL.Interface.DTO
{
    public class DalTest : IEntity
    {
        public int Id { get; set; }

        public int Number { get; set; }
        public string Name { get; set; }
        public long TimeToDo { get; set; }
    }
}
