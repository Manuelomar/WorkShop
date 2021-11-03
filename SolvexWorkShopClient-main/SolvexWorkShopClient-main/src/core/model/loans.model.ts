import { BaseEntity } from "./base.model";
import { Term, Status } from "@/core/utils/enums";

 export class Loans extends BaseEntity {
    startDate: string = '';
    creationDate: string = '';
    amount: number=1;
    paymentMount: number=1;
    term: Term=Term.monthly;
    status: Status =Status.OnHold;
    debtorId: number=1;
    creditorId: number=1;
   
}