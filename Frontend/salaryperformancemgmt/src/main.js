import Vue from 'vue'
import App from './App.vue'
import vuetify from '@/plugins/vuetify'
import VueRouter from 'vue-router';
import VueGoogleCharts from 'vue-google-charts';
import VueSession from 'vue-session'

import routes from './routes';
import store from './store';


Vue.config.productionTip = false;
Vue.use(VueRouter);
Vue.use(VueGoogleCharts);
Vue.use(VueSession);

const router = new VueRouter({routes});

new Vue({
  vuetify,
  render: h => h(App),
  router,
  store
}).$mount('#app')
