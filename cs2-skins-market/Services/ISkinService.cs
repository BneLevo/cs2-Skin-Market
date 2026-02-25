using System;
using System.Collections.Generic;
using System.Text;
using cs2_skins_market.Models;

namespace cs2_skins_market.Services
{
    interface ISkinService
    {
        List<Skin> GetAllSkins();
        //List<Skin> GetByCountry(string category);
    }
}
