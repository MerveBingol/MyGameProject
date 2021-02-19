using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    public  class Player:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalyId { get; set; }
        public int Birthyear { get; set; }

       
    }
}
