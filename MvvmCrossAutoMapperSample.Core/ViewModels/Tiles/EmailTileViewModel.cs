using MvvmCrossAutoMapperSample.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossAutoMapperSample.Core.ViewModels.Tiles
{
    public class EmailTileViewModel : TileViewModel
    {
        public EmailTileViewModel(ITileService tileService)
            : base(tileService) { }

        private int _unreadCount;
        public int UnreadCount
        {
            get { return _unreadCount; }
            set { _unreadCount = value; RaisePropertyChanged(() => UnreadCount); }
        }
    }
}
