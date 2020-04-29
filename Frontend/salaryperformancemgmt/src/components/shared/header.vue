<template>
<v-app-bar
      app
      color="primary"
      dark
    >
   
    <v-img src="./../../assets/federated-icon.png" height="50" max-width="220" contain/>

    <v-spacer></v-spacer>

      <v-btn icon elevation="4" to="/employee">
        <v-img src="./../../assets/image-4.png" height="50" contain/>
      </v-btn>
      <v-btn icon>
        <v-icon color="grey darken-4">mdi-cogs</v-icon>
      </v-btn>  
      <v-btn icon>
        <v-badge
        color="error"
        content="4"
        overlap
        >
          <v-icon color="grey darken-4">mdi-bell</v-icon>
        </v-badge>
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