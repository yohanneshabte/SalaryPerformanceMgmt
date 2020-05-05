<template>
<v-app-bar
      app
      color="primary"
      dark
      v-show="auth"
    >
   
    <v-img src="./../../assets/federated-icon.png" height="50" max-width="220" contain/>

    <v-spacer></v-spacer>
      <v-avatar>
        <v-btn icon elevation="4" to="/employee">
          <v-img src="./../../assets/image-4.png" height="50" contain/>
        </v-btn>
        </v-avatar>
        <v-text class="black--text ml-1 mr-3">{{currentEmployee.firstName}}</v-text>
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
        <v-icon color="grey darken-4" @click="logout">mdi-logout</v-icon>
      </v-btn>   
    </v-app-bar>
</template>
<script>
import {mapGetters} from 'vuex';

  export default {
    name: 'header',
    props: ['currentEmployeeID','currentEmployee', 'allEmployees'],
    data () {
      return {
        auth: this.$route.path=='/auth'?false:true,
        employee: null,
      }
    },
    watch: {
    // call again the method if the route changes
      '$route': 'fetchData'
    },
    methods: {
      fetchData () {
        this.auth = this.$route.path=='/auth'?false:true;
      },
      logout: function () {
        if(confirm("Are you sure you want to logout?")) {
          this.$session.destroy();
          this.$store.dispatch('changeEmployee', null);
          this.$router.push('/auth');
        }
      }
    },
    computed: {
      ...mapGetters(['currentEmployeeID','currentEmployee', 'allEmployees']),
      
    }
  }
</script>