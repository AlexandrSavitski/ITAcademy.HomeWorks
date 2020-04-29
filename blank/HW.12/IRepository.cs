using System;
using System.Collections.Generic;
using System.Text;

namespace HW._12
{
    interface IRepository
    {
        void GetMotorcycleByID();
        void GetMotorcycles();
        void CreateMotorcycle();
        void UpdateMotorcycle();
        void DeleteMotorcycle();
    }
}
