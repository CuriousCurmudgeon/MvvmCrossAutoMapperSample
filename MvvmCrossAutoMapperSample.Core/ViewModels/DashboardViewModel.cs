using AutoMapper;
using Cirrious.MvvmCross.ViewModels;
using MvvmCrossAutoMapperSample.Core.Services;
using MvvmCrossAutoMapperSample.Core.ViewModels.Tiles;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MvvmCrossAutoMapperSample.Core.ViewModels
{
    public class DashboardViewModel : MvxViewModel
    {
        private readonly ITileService _tileService;

        public DashboardViewModel(ITileService tileService)
        {
            _tileService = tileService;
            Tiles = new ObservableCollection<TileViewModel>();
        }

        public async Task Init()
        {
            var tiles = await _tileService.LoadTilesAsync();
            var tileViewModels = Mapper.Map<IList<TileViewModel>>(tiles);
            foreach (var viewModel in tileViewModels)
            {
                Tiles.Add(viewModel);
            }
        }

        public ObservableCollection<TileViewModel> Tiles { get; private set; }
    }
}
