using DAL.Interface.DTO;
using ORM;

namespace DAL.Mappers
{
    public static class DalTestMapper
    {
        public static DalTest ToDalTest(this Test test)
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
        public static Test ToTest(this DalTest test)
        {
            if (test == null)
                return null;
            return new Test()
            {
                //Id = test.Id,
                Name = test.Name,
                Number = test.Number,
                TimeToDo = test.TimeToDo
            };
        }
        public static Test ToTestWithId(this DalTest test)
        {
            if (test == null)
                return null;
            return new Test()
            {
                Id = test.Id,
                Name = test.Name,
                Number = test.Number,
                TimeToDo = test.TimeToDo
            };
        }
    }
}
