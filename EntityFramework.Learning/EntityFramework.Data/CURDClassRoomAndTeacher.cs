using EntityFramework.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Data
{
    public class CURDClassRoomAndTeacher
    {
        DemoDbContext demoDbContext = new DemoDbContext();

        public void InsertTeacher(Teachers teacher)
        {
            demoDbContext.Teachers.Add(teacher);
            demoDbContext.SaveChanges();
        }

        public void InsertClassRoom(ClassRoom classRoom)
        {
            demoDbContext.classRooms.Add(classRoom);
            demoDbContext.SaveChanges();
        }

        //public void InsertClassRoomAndTeacher(ClassRoom classRoom, Teachers teacher)
        //{
        //    //classRoom.Teachers = teacher;
        //    demoDbContext.classRooms.Add(classRoom);
        //    demoDbContext.Teachers.Add(teacher);
        //    demoDbContext.SaveChanges();
        //}
        public void InsertClassRoomAndTeacher(ClassRoom classRoom, List<Teachers> teachers)

        {

            var objClassRoom = new ClassRoom

            {

                Name = classRoom.Name,

                Teachers = teachers

            };

            demoDbContext.classRooms.Add(objClassRoom);

            demoDbContext.SaveChanges();

        }
    }
}
