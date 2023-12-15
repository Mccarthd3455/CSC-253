using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    public class TeamLeader : ProductionWorker
    {
        public double MonthlyBonus { get; set; }
        public double AmountTrainingNeeded { get; set; }
        public double AmountTrainingObtained { get; set; }
        public TeamLeader()
        {
            MonthlyBonus = 0.0;
            AmountTrainingNeeded = 0.0;
            AmountTrainingObtained = 0.0;
        }
        
        private void createObjectButton_Click(object sender, EventArgs e)
        {
            TeamLeader teamleader = new TeamLeader();

        }
        private void GetTeamLeader(TeamLeader teamleader)
        {
            
        }
    }
    
}
