using BusinessLayer.Business;
using DataAccessLayer.DataAccess;
using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public class Master : IMaster
    {
        IDataMaster iDataMaster;

        public Master()
        {  iDataMaster = new DataMaster();
        }

       
        public void insert()
        {
            iDataMaster.InsrertDataMaster();
        }
    }
}
