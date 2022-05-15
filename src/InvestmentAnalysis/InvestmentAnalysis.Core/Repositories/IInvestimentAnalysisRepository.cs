using InvestmentAnalysis.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentAnalysis.Core.Repositories
{
    public interface IInvestimentAnalysisRepository 
    {
        (decimal gross, decimal net) GetResultInvestmentByPeriod(decimal initialValue, decimal finalValue, int period); 
    }
}
