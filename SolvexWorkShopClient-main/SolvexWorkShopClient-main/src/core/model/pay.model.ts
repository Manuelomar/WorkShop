import { BaseEntity } from "./base.model";

export class Pay extends BaseEntity {
    voucher: string='';
    realizationDate: Date | null | string = null;
    rstablished: Date | null | string = null;
    // payLoansEntity: PayL[];
}