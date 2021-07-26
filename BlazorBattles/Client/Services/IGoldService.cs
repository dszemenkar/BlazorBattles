using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
    public interface IGoldService
    {
        event Action OnChange;
        int Gold { get; set; }
        void ConsumeGold(int amount);
        Task AddGold(int amount);
        Task GetGold();
    }
}
