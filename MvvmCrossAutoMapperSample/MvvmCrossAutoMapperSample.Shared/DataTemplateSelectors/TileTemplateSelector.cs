using MvvmCrossAutoMapperSample.Core.ViewModels.Tiles;
using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MvvmCrossAutoMapperSample.DataTemplateSelectors
{
    public class TileTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate SelectTemplateCore(object item)
        {
            if (item != null)
            {
                if (item is DateTimeTileViewModel)
                {
                    return DateTimeTileTemplate;
                }
                else if (item is EmailTileViewModel)
                {
                    return EmailTileTemplate;
                }
                else if (item is TemperatureTileViewModel)
                {
                    return TemperatureTileTemplate;
                }
                else
                {
                    return TileTemplate;
                }
            }

            return null;
        }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var element = container as FrameworkElement;
            if (element != null)
            {
                return SelectTemplateCore(item);
            }

            return null;
        }

        public DataTemplate DateTimeTileTemplate { get; set; }
        public DataTemplate EmailTileTemplate { get; set; }
        public DataTemplate TemperatureTileTemplate { get; set; }
        public DataTemplate TileTemplate { get; set; }
    }
}
