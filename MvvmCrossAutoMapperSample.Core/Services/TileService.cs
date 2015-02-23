using MvvmCrossAutoMapperSample.Core.Models.Tiles;
using MvvmCrossAutoMapperSample.Core.ViewModels.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossAutoMapperSample.Core.Services
{
    public class TileService : ITileService
    {
        public async Task<IEnumerable<Tile>> LoadTilesAsync()
        {
            var tiles = new List<Tile>()
            {
                new DateTimeTile() { DateTime = DateTime.Now, Color = "#B3052E" },
                new EmailTile() { UnreadCount = 42, Color = "#158F3A" },
                new TemperatureTile() { Temperature = 74, Color = "#051AB3" },
            };
            return await Task.FromResult(tiles);
        }

        public async Task UpdateStateAsync(TileViewModel tile)
        {
            await Task.FromResult(false);
        }
    }
}
