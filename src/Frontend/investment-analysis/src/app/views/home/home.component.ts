import { Component, VERSION, ViewChild, ElementRef, OnInit } from "@angular/core";
import { AnalysisService } from 'src/app/shared/service/analysis.service';
import { ResponsePageAnalysis } from 'src/app/shared/model/responsePageAnalysis.model'
 
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  analysisPrevious: ResponsePageAnalysis; 
  constructor(public analysisService: AnalysisService) { }

  ngOnInit(): void {
  }
  

  getAnalysis()
  {
   var inputInitialValue = (<HTMLInputElement>document.getElementById("initialValue")).value;
   var inputPeriod = (<HTMLInputElement>document.getElementById("period")).value;
 
   this.analysisService.getAnalysis(inputInitialValue, inputPeriod).subscribe(data => {
   this.analysisPrevious = data; 
   console.log(data.GrossProfitability, data.NetProfitability);
  })
  }
}