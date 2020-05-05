<template>
  <v-app>
    <v-content class="grey lighten-2">
      <Header/>
      <Sidebar/>
      <Home/>
    </v-content>
  </v-app>
</template>

<script>
import Header from './components/shared/header.vue';
import Home from './components/home.vue';
import Sidebar from './components/shared/sidebar.vue';
//import _ from "lodash";
import {mapGetters} from 'vuex';

export default {
  name: 'App',

  components: {
    Header,
    Home,
    Sidebar,

    
  },
  data () {
    return {
     
    }
  },
  computed: {
    //...mapState(['currentEmployeeID','currentEmployee', 'allEmployees'])
    ...mapGetters(['currentEmployeeID','currentEmployee', 'allEmployees']),
    
  },
  mounted () {
    this.$store.dispatch("fetchEmployee");
    this.$store.dispatch("fetchAllEmployees");
    this.checkLogin();
  },
  watch: {
    // call again the method if the route changes
      '$route': 'checkLogin'
  },
  beforeCreate: function () {
    if (!this.$session.exists()) {
      this.$router.push('/auth')
    } 
  },
  methods: {
    checkLogin() {
      if(this.currentEmployeeID == null && !this.$session.exists())
        this.$router.push('/auth');
      else if(this.currentEmployeeID == null && this.$session.exists()) {
        this.$store.dispatch('changeEmployee', parseInt(this.$session.get('empID')));
        this.$router.push('/');
        alert("2:  "+this.currentEmployeeID);
      }
      else if(this.currentEmployeeID != null && !this.$session.exists()) {
        this.$session.start();
        this.$session.set('email', this.email);
        this.$session.set('empID', this.empID);   
        this.$router.push('/');
        alert("3:  "+this.currentEmployeeID);
      }
      else if(this.currentEmployeeID != this.$session.get('empID')) {
        this.$session.set('empID', this.currentEmployeeID);  
        alert("4:  "+this.currentEmployeeID);
      }
    }   

  }
};
</script>

<style>
body, html {
  height: 100%;
  width: 100%;
}
</style>