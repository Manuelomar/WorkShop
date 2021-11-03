import { BaseEntity } from "./base.model";


export class Users extends BaseEntity {
    Name: string='';
    LastName: string='';
    Age: number=0;
    // debtorLoans: Loans[];
    // creditorLoans: Loans[];
}