using ResistorService.Concrete;
using ResistorService.Interface;
using StructureMap;

namespace StructureContainer
{
    public static class IocContainer
    {
        private static IContainer _container;

        public static IContainer Container
        {
            get
            {
                if (_container != null) return _container;
                _container = ConfigureDependencies();
                return _container;
            }
        }

        private static IContainer ConfigureDependencies()
        {
            if (_container != null) return _container;
            _container = new Container();
            _container.Configure(x => x.For<IResistorBand>().Use<ResistorBand>());
            _container.Configure(x => x.For<IOhmValueCalculator>().Use<OhmValueCalculator>());
            return _container;
        }
    }
}
