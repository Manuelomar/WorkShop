
import { BaseService, IBaseService } from "./base.service";
import { Pay } from "../model/pay.model";

export interface IPayService extends IBaseService<Pay> {
   
}

export class PayService extends BaseService<Pay> implements IPayService
 {
    constructor(controller: string) {
        super(controller)
    }
  
}
