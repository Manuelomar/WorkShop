
import { BaseService, IBaseService } from "./base.service";
import { Loans } from "../model/loans.model";

export interface ILoansService extends IBaseService<Loans> {
   
}

export class LoansService extends BaseService<Loans> implements ILoansService
 {
    constructor(controller: string) {
        super(controller)
    }
  
}
