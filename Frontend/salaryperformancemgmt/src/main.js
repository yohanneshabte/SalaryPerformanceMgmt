import Vue from 'vue'
import App from './App.vue'
import vuetify from '@/plugins/vuetify'
import VueRouter from 'vue-router';
import VueGoogleCharts from 'vue-google-charts';

import routes from './routes';



Vue.config.productionTip = false;
Vue.use(VueRouter);
Vue.use(VueGoogleCharts);

const router = new VueRouter({routes});

new Vue({
  vuetify,
  render: h => h(App),
  router
}).$mount('#app')
