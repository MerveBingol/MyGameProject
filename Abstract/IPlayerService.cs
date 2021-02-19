using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    public interface IPlayerService // operasyonlar için
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
