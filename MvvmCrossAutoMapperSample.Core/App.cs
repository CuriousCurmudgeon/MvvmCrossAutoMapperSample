using AutoMapper;
using Cirrious.CrossCore;
using Cirrious.CrossCore.IoC;
using MvvmCrossAutoMapperSample.Core.ViewModels.Tiles;

namespace MvvmCrossAutoMapperSample.Core
{
    public class App : Cirrious.MvvmCross.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            Mapper.Initialize(config => config.AddProfile<AutoMapperProfile>());

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            // Register each view model so that Mvx.Resolve will find them
            // when AutoMapper attempts to instantiate an instance of each.
            Mvx.RegisterType<DateTimeTileViewModel, DateTimeTileViewModel>();
            Mvx.RegisterType<EmailTileViewModel, EmailTileViewModel>();
            Mvx.RegisterType<TemperatureTileViewModel, TemperatureTileViewModel>();
            Mvx.RegisterType<TileViewModel, TileViewModel>();
	
            RegisterAppStart<ViewModels.DashboardViewModel>();
        }
    }
}