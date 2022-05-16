import { HttpClient, HttpClientModule, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ResponsePageAnalysis } from '../model/responsePageAnalysis.model';

@Injectable({
  providedIn: 'root'
})
export class AnalysisService {

  apiUrl = 'https://localhost:44380/api/Analysis'

  httpOptions = {
  headers: new HttpHeaders({
    'Content-TYpe': 'applicatuon/json'
  })
};

  constructor(private httpClient: HttpClient) { }

  public getAnalysis(initialValue: number, period: number):Observable<ResponsePageAnalysis>
  {
    return this.httpClient.get<ResponsePageAnalysis>(this.apiUrl + "?InitialValue=" + initialValue + "&&finalValue=1" +"&&period=" + period);
  }
}
