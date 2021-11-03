import { RouteConfig } from "vue-router";
const item = {
  path: "/admin/user",
  name:"Users",
  component: () => import("../views/base.vue"),
  children: [
    {
      path: "",
      component: () => import("../views/admin/user/list.vue"),
    },
    {
      path: "add",
      component: () => import("../views/admin/user/add.vue")
    },
    {
        path: "edit/:id",
        component: () => import("../views/admin/user/edit.vue")
      }
  ],
} as RouteConfig;

export default item;