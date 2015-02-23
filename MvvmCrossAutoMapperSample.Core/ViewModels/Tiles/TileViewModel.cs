using Cirrious.MvvmCross.ViewModels;
using MvvmCrossAutoMapperSample.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossAutoMapperSample.Core.ViewModels.Tiles
{
    public class TileViewModel : MvxViewModel
    {
        private readonly ITileService _tileService;

        public TileViewModel(ITileService tileService)
        {
            _tileService = tileService;
        }

        private string _color;
        public string Color
        {
            get { return _color; }
            set { _color = value; RaisePropertyChanged(() => Color); } 
        }

        public IMvxCommand UpdateState
        {
            get
            {
                return new MvxCommand(async () =>
                {
                    await _tileService.UpdateStateAsync(this);
                });
            }
        }
    }
}
