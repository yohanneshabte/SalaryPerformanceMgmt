<template>
<v-app-bar
      app
      color="primary"
      dark
    >
   
    <v-img src="./../../assets/federated-icon.png" height="50" max-width="220" contain/>

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
</template>
<script>
  export default {
    name: 'header',
    data () {
      return {

      }
    },
  }
</script>