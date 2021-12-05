using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CheckManager : ICheckService
    {
       
        public bool CheckIfRealPerson(Gamer gamer)
        {
            int sayi = gamer.NationalityId.Length;

            if (sayi == 9) 
            {
                return true;
           
            }
            else
            {
                return false;   
            }

            

        }
    }
}
