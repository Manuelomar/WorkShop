import { RouteConfig } from "vue-router";
const item = {
  path: "/administration/user",
  name:"user",
  component: () => import("../views/base.vue"),
  children: [
    {
      path: "",
      component: () => import("../views/administration/user/list.vue"),
    },
    {
      path: "add",
      component: () => import("../views/administration/user/add.vue")
    },
    {
        path: "edit/:id",
        component: () => import("../views/administration/user/edit.vue")
      }
  ],
} as RouteConfig;

export default item;