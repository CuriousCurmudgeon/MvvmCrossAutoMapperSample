using AutoMapper;
using Cirrious.CrossCore;
using MvvmCrossAutoMapperSample.Core.Models.Tiles;
using MvvmCrossAutoMapperSample.Core.ViewModels.Tiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCrossAutoMapperSample.Core
{
    public class AutoMapperProfile : Profile
    {

        protected override void Configure()
        {
            base.Configure();

            // Tell AutoMapper to resolve dependencies using MvvmCross's service locator.
            Mapper.Configuration.ConstructServicesUsing(Mvx.Resolve);

            // Map each type of tile and tell AutoMapper to use the
            // service locator we set above.
            Mapper.CreateMap<DateTimeTile, DateTimeTileViewModel>()
                .ConstructUsingServiceLocator();
            Mapper.CreateMap<EmailTile, EmailTileViewModel>()
                .ConstructUsingServiceLocator();
            Mapper.CreateMap<TemperatureTile, TemperatureTileViewModel>()
                .ConstructUsingServiceLocator();

            // When mapping a a list of tiles, map to child classes
            // when possible.
            Mapper.CreateMap<Tile, TileViewModel>()
                .Include<DateTimeTile, DateTimeTileViewModel>()
                .Include<EmailTile, EmailTileViewModel>()
                .Include<TemperatureTile, TemperatureTileViewModel>();
        }

    }
}
