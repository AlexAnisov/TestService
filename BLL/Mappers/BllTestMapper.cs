using BLL.Interfacies.Entities;
using DAL.Interface.DTO;

namespace BLL.Mappers
{
    public static class BllTestMapper
    {
        public static DalTest ToDalTest(this TestEntity test)
        {
            if (test == null)
                return null;
            return new DalTest()
            {
                Id = test.Id,
                Name=test.Name,
                Number=test.Number,
                TimeToDo=test.TimeToDo
            };
        }
        public static TestEntity ToBllTest(this DalTest test)
        {
            if (test == null)
                return null;
            return new TestEntity()
            {
                Id = test.Id,
                Name = test.Name,
                Number = test.Number,
                TimeToDo = test.TimeToDo
            };
        }
    }
}
