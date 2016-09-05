using System.Collections.Generic;

namespace EndToEndCoding
{
    public class Costs
    {
        public string monthlyCostDisplay { get; set; }
        public string monthlyCostNote { get; set; }
        public string firstYearCostDisplay { get; set; }
        public string lineRentalDisplay { get; set; }
        public string installationCostDisplay { get; set; }
        public string deliveryCostDisplay { get; set; }
        public List<CostBreakdown> costBreakdown { get; set; }
    }
}