
import { User } from "@/core/model";
import { UserRole } from "@/core/utils/enums";
import { Module } from "vuex";

const authModule: Module<any, any> = {
    state: {
        user: {
         
            userRole: UserRole.ADMIN
        } as User,
    },
    getters: {
        isCurrentUserAdmin(state) {
            return state.user.userRole === UserRole.ADMIN;
        }
    },
    mutations: {

    },
    actions: {
    }
};

export default authModule;