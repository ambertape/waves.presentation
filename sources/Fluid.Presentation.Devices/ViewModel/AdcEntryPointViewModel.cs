﻿using Fluid.Core.Devices.Interfaces.Input.ADC;
using Fluid.Presentation.Base;

namespace Fluid.Presentation.Devices.ViewModel
{
    public class AdcEntryPointViewModel : PresentationViewModel
    {
        private IAdcEntryPoint _entryPoint;
        private bool _isUsing;

        /// <summary>
        ///     Новый экземпляр представления модели канала АЦП.
        /// </summary>
        /// <param name="entryPoint"></param>
        public AdcEntryPointViewModel(IAdcEntryPoint entryPoint)
        {
            EntryPoint = entryPoint;
        }

        /// <summary>
        ///     Используется ли данный канал.
        /// </summary>
        public bool IsUsing
        {
            get => _isUsing;
            set
            {
                if (value == _isUsing) return;
                _isUsing = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Канал.
        /// </summary>
        public IAdcEntryPoint EntryPoint
        {
            get => _entryPoint;
            private set
            {
                if (Equals(value, _entryPoint)) return;
                _entryPoint = value;
                OnPropertyChanged();
            }
        }

        /// <inheritdoc />
        public override void Initialize()
        {
        }
    }
}