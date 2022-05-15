using InvestmentAnalysis.Core.Repositories;
using InvestmentAnalysis.Infrastructure.Repositories;
using System;
using Xunit;

namespace InvestmentAnalysis.Test
{
    public class InvestmentAnalysisTest
    {
        private readonly InvestimentAnalysisRepository _investimentAnalysisRepository;  
        public InvestmentAnalysisTest()
        {
            _investimentAnalysisRepository = new InvestimentAnalysisRepository();  
        }

        [Fact]
        public void CalculateNotIsEqualZero()
        {
            var result = _investimentAnalysisRepository.GetResultInvestmentByPeriod(10m, 10m, 2); 
            
            Assert.NotEqual(0, result.gross);
            Assert.NotEqual(0, result.net);
        }

        [Fact]
        public void RateNotIsEqualZero()
        {
            var result = _investimentAnalysisRepository.GetRate(0);
            Assert.NotEqual(0, result);
        }

        [Fact]
        public void RateForMonth6()
        {
            var result = _investimentAnalysisRepository.GetRate(6);
            Assert.Equal(22.5m, result);
        }

        [Fact]
        public void RateForMonth12()
        {
            var result = _investimentAnalysisRepository.GetRate(12);
            Assert.Equal(20, result);
        }

        [Fact]
        public void RateForMonth24()
        {
            var result = _investimentAnalysisRepository.GetRate(24);
            Assert.Equal(17.5m, result);
        }

        [Fact]
        public void RateForMonthBiggerThat24()
        {
            var result = _investimentAnalysisRepository.GetRate(25);
            Assert.Equal(15, result);
        }
    }
}
