using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerManager : IGamerService
    {
        ICheckService checkService;


        public GamerManager(ICheckService verificationService)
        {
            this.checkService = verificationService;
        }


        public void Add(Gamer gamer)
        {
            if (checkService.CheckIfRealPerson(gamer) == true)
            {
                Console.WriteLine("Sayın"+ " "+gamer.FirstName +" "+ "Kaydınız Başarıyla oluşturuldu");

            }
            else
            {
                Console.WriteLine("Kayıt işlemi başarısız ,bilgiler yanlış");
            }

            

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıdınız Silindi :( ");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Bilgileriniz Güncellendi!");
        }
    }
}
