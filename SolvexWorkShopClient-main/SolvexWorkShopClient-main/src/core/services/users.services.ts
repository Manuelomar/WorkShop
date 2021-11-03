import axios, { AxiosResponse } from "axios";
import { BaseService, IBaseService } from "./base.service";
import { Users } from "../model/users.model";

export interface IUsersService extends IBaseService<Users> {
   
}

export class UserService extends BaseService<Users> implements IUsersService
 {
    constructor(controller: string) {
        super(controller)
    }
  
}
