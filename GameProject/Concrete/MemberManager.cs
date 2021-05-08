using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class MemberManager : IMemberService
    {
        public void Add(Member member)
        {
            Console.WriteLine("added member");
        }

        public void Delete(Member member)
        {
            Console.WriteLine("deleted member");
        }

        public void Update(Member member)
        {
            Console.WriteLine("updated member");
        }
        private IMemberCheckService memberCheckService;
        public void Save(Member member)
        {
            if (memberCheckService.CheckIfRealPerson(member))
            {
                Console.WriteLine("Contact added");
            }
            else
            {
                Console.WriteLine("Contact Information is incorrect");
            }
        }
    }
}
