using MvvmCrossAutoMapperSample.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossAutoMapperSample.Core.ViewModels.Tiles
{
    public class TemperatureTileViewModel : TileViewModel
    {
        public TemperatureTileViewModel(ITileService tileService)
            : base(tileService) { }

        private double _temperature;
        public double Temperature
        {
            get { return _temperature; }
            set { _temperature = value; RaisePropertyChanged(() => Temperature); }
        }
    }
}
