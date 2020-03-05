<template>
  <v-app>
    <v-content class="grey lighten-2">
      <Header />
      <Sidebar/>
      <Home />
    </v-content>
  </v-app>
</template>

<script>
import Header from './components/shared/header.vue';
import Home from './components/home.vue';
import Sidebar from './components/shared/sidebar.vue';


export default {
  name: 'App',

  components: {
    Header,
    Home,
    Sidebar,

    
  },

  data: () => ({
    //
  }),
};
</script>

<style>
body, html {
  height: 100%;
  width: 100%;
}
</style>