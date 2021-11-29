using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{//!!!interfaceleri birbirlerinin alternatifi olan ama kod içeriği farklı ola n durumlarda kullanırız

    interface IKrediManager
    {//tek başın bu class anlam ifade etmiyor. 
        //imzanın aynı olduğu  ancak içeriğin farklı durumlarda İNTERFACE kullanırız
        void Hesapla();
        void BiseyYap();
        
          
    }
}


//interface, birisi bunu kullanırsa void metodunu içermek orunda
