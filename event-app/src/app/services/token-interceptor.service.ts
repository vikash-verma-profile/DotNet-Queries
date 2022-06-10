import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from "@angular/common/http";
import { Injector } from "@angular/core";
import { Observable } from "rxjs";
import { AuthService } from "./auth.service";
import { Injectable } from '@angular/core';

@Injectable()
export class TokenInterceptorService implements HttpInterceptor{
 
    constructor(private injector:Injector) {}
    intercept(req: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        let authService=this.injector.get(AuthService);
        let tokenizedReq=req.clone({
            headers:req.headers.set('Authorization','bearer '+authService.getToken())
        })
        return next.handle(tokenizedReq)
    }
}