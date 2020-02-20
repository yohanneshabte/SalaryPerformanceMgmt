<template>
  <v-app>
    <v-app-bar
      app
      color="primary"
      dark
    >
    <img src="./assets/federated-icon.png" />


    <v-spacer></v-spacer>

      <v-btn icon class="teal">
        <v-icon>mdi-account</v-icon>
      </v-btn>
      <v-btn icon>
        <v-icon color="grey darken-4">mdi-cogs</v-icon>
      </v-btn>  
      <v-btn icon>
        <v-icon color="grey darken-4">mdi-bell</v-icon>
      </v-btn> 
      <v-btn icon>
        <v-icon color="grey darken-4">mdi-logout</v-icon>
      </v-btn>   
    </v-app-bar>

    <v-content>
      <Sidebar></Sidebar>
      <HelloWorld/>
    </v-content>
  </v-app>
</template>

<script>
import HelloWorld from './components/HelloWorld';
import Sidebar from './components/shared/sidebar.vue';


export default {
  name: 'App',

  components: {
    HelloWorld,
    Sidebar
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