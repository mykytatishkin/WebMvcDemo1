﻿namespace WebMvcDemo1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
         public String Group { get; set; }
        public double Rate { get; set; }
        public int GroupID { get; set; }
        public Group group { get; set; }
    }
}
