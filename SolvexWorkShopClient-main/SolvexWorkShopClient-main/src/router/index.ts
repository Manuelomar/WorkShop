import Vue from 'vue'
import VueRouter, { RouteConfig } from 'vue-router'
import Home from '../views/Home.vue'
import User from './user.router'
import Workshop from './workshop.router'


Vue.use(VueRouter)

const routes: Array<RouteConfig> = [
  {
    path: '/',
    name: 'Home',
    component: Home,
  },
  {
    path: '/about',
    name: 'About',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
  },
  User,
  Workshop,
  {
    path: '/user/profile',
    name: 'Profile',
    component: () => import(/* webpackChunkName: "profile" */ '../views/user/profile.vue')
  },
  {
    path: '/user/workshops',
    name: 'WorkShops',
    component: () => import(/* webpackChunkName: "profile" */ '../views/user/workshops.vue')
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
