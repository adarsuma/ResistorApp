namespace ResistorWebApp.ViewModel
{
    public class ResistorViewModel
    {
        public string SelectedBand1 { get; set; }
        public string SelectedBand2 { get; set; }
        public string SelectedMultiplier { get; set; }
        public string SelectedTolerance { get; set; }
        public string OhmsValue { get; set; }
        public string ResistanceLowerValue { get; set; }
        public string ResistanceUpperValue { get; set; }
        public bool ShowResult { get; set; }
        public ResistorViewModel()
        {
            
        }
    }

}