using System;
using System.Collections.Generic;
using System.Text;
using AspMan.Core.Models;

namespace AspMan.Core.Iterfaces
{
    //one to one логика внутри. верхние уровни не должны работать с input и output datas как с разными 
    public interface IOutputDataRepository : IRepository<OutputData>
    {
        //TODO
    }
}
