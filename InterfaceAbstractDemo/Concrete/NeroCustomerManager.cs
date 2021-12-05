using System;
using InterfaceAbstractDemo.Adapters;
using InterfaceAndAbstractDemo.Abstract;
using InterfaceAndAbstractDemo.Entities;
namespace InterfaceAbstractDemo.Concerete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        public MernisAdapterService mernisAdapterService;
        

        public NeroCustomerManager(MernisAdapterService mernisServiceAdapter)
        {
            this.mernisAdapterService = mernisServiceAdapter;
        }

       
    }
}
