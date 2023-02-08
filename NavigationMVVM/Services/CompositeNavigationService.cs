using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationMVVM.Services
{
    public class CompositeNavigationService : INavigationService
    {
        private readonly IEnumerable<INavigationService> _services;
        public CompositeNavigationService(params INavigationService[] navigationServices)
        {
            _services = navigationServices;
        }
        public void Navigate()
        {
            foreach(var navigationService in _services)
            {
                navigationService.Navigate();
            }
        }
    }
}
