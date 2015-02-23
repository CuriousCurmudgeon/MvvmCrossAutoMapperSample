using MvvmCrossAutoMapperSample.Core.Models.Tiles;
using MvvmCrossAutoMapperSample.Core.ViewModels.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossAutoMapperSample.Core.Services
{
    public interface ITileService
    {
        Task<IEnumerable<Tile>> LoadTilesAsync();

        Task UpdateStateAsync(TileViewModel tile);
    }
}
