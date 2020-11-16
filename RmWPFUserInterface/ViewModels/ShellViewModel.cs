using Caliburn.Micro;
using RmWPFUserInterface.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RmWPFUserInterface.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private IEventAggregator _events;
        private SalesViewModel _salesViewModel;
        private SimpleContainer _container;

        public ShellViewModel(IEventAggregator events, SalesViewModel salesViewModel, SimpleContainer container)
        {
            _events = events;
            _salesViewModel = salesViewModel;
            _container = container;

            _events.Subscribe(this);

            ActivateItem(_container.GetInstance<LoginViewModel>());
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesViewModel);
        }
    }
}
