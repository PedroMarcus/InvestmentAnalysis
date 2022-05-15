using InvestmentAnalysis.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentAnalysis.Infrastructure.Repositories
{
    public class InvestimentAnalysisRepository : IInvestimentAnalysisRepository
    {
        public (decimal gross, decimal net) GetResultInvestmentByPeriod(decimal initialValue, decimal finalValue, int period)
        {
            return CalculateInvestment(initialValue, period);
        }

        private (decimal gross, decimal net) CalculateInvestment(decimal initialValue, int period)
        {
            #region Base Information
            decimal tb = 108;
            decimal cdi = 0.9m;

            decimal currentValueInvestment = initialValue;
            decimal yield = currentValueInvestment;
            #endregion

            decimal grossValue = 0;
            decimal netValue = 0;
            decimal lastMonth = 0; 

            for (var month = 0; month < period; month++)
            {
                currentValueInvestment = yield * (1 + (cdi * tb));

                if (month == 0)
                    yield = (currentValueInvestment - initialValue);
                else
                    yield = (lastMonth - currentValueInvestment); 


                lastMonth = currentValueInvestment;
                grossValue = currentValueInvestment;
            }

            decimal rateValue = (currentValueInvestment / 100) * GetRate(period);
            netValue = currentValueInvestment - rateValue;

            return (grossValue, netValue);
        }

        public decimal GetRate(int month)
        {
            if (month <= 6)
                return 22.5m;
            else if (month <= 12)
                return 20m;
            else if (month <= 24)
                return 17.5m;
            else
                return 15m;
        }
    }
}
