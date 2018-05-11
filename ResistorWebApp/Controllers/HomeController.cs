using ResistorService.Interface;
using ResistorWebApp.ViewModel;
using System.Web.Mvc;

namespace ResistorWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOhmValueCalculator _ohmService;

        public HomeController(IOhmValueCalculator ohmService)
        {
            _ohmService = ohmService;
        }

        public ActionResult Index()
        {
            var vm = new ResistorViewModel() { ShowResult = false };
            return View(vm);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(ResistorViewModel vm)
        {
            var ohmsvalue = _ohmService.CalculateOhmValue(vm.SelectedBand1, vm.SelectedBand2, vm.SelectedMultiplier);
            var tolerances = _ohmService.CalculateTolerance(vm.SelectedTolerance, ohmsvalue);

            var newvm = new ResistorViewModel() { ShowResult = true };
            newvm.OhmsValue = ohmsvalue.ToString();
            newvm.ResistanceLowerValue = tolerances[0].ToString();
            newvm.ResistanceUpperValue = tolerances[1].ToString();            
            return View(newvm);
        }
        
    }
}