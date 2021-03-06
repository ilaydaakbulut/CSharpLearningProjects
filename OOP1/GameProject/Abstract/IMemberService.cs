using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;


namespace GameProject.Abstract
{
    public interface IMemberService
    {
        void Add(Member member);
        void Delete(Member member);
        void Update(Member member);
    }
}
