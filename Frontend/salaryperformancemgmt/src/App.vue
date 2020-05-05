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
//import _ from "lodash";
import {mapState} from 'vuex';

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
  computed: {
    ...mapState(['currentEmployee', 'allEmployees'])
  },
  mounted () {
    this.$store.dispatch("fetchEmployee");
    this.$store.dispatch("fetchAllEmployees");
  }
};
</script>

<style>
body, html {
  height: 100%;
  width: 100%;
}
</style>