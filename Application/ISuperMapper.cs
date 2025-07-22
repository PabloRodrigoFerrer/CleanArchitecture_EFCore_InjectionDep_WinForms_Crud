using ApplicationBusiness.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public interface ISuperMapper<Tin1,Tin2, Tout>
    {
        public Tout Map(Tin1 input1, Tin2 input2);
    }
}
