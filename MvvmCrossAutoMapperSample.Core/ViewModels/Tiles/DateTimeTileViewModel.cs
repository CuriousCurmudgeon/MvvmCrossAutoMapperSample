using MvvmCrossAutoMapperSample.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossAutoMapperSample.Core.ViewModels.Tiles
{
    public class DateTimeTileViewModel : TileViewModel
    {
        public DateTimeTileViewModel(ITileService tileService)
            : base(tileService) { }

        private DateTime _dateTime;
        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; RaisePropertyChanged(() => DateTime); }
        }
    }
}
