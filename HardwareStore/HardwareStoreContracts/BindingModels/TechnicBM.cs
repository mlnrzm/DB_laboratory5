namespace HardwareStoreContracts.BindingModels
{
    public class TechnicBM
    {
        public int? Id { get; set; }
        public int CategoryId { get; set; }
        public string TechnicName { get; set; }
        public string Production { get; set; }
        public string Warranty { get; set; }
    }
}
