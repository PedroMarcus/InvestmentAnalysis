using InvestmentAnalysis.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvestmentAnalysis.Application.Commands
{
    public class GetInvestimentAnalysisCommand : IRequest<GetInvestimentAnalysisResponse>
    {
        public decimal InitialValue { get; set; }
        public decimal FinalValue { get; set; }
        public int Period { get; set; }
    }
}
