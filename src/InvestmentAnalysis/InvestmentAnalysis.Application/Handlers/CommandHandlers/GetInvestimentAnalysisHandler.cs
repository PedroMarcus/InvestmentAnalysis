using InvestmentAnalysis.Application.Commands;
using InvestmentAnalysis.Application.Responses;
using InvestmentAnalysis.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentAnalysis.Application.Handlers.CommandHandlers
{
    public class GetInvestimentAnalysisHandler : RequestHandler<GetInvestimentAnalysisCommand, GetInvestimentAnalysisResponse>
    {
        private readonly IInvestimentAnalysisRepository _repositoryAnalysisInvestment;
        public GetInvestimentAnalysisHandler(IInvestimentAnalysisRepository repositoryAnalysisInvestment)
        {
            _repositoryAnalysisInvestment = repositoryAnalysisInvestment; 
        }

        protected override GetInvestimentAnalysisResponse Handle(GetInvestimentAnalysisCommand request)
        {
            var result = _repositoryAnalysisInvestment.GetResultInvestmentByPeriod(request.InitialValue, request.Period);


            var response = new GetInvestimentAnalysisResponse();
            response.NetProfitability = result.net.ToString("C");
            response.GrossProfitability = result.gross.ToString("C");

            return response; 
        }
    }
}
