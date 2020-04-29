<template>
  <v-navigation-drawer permanent fixed expand-on-hover  mini-variant
          mini-variant-width="65" class="grey darken-4" style="top: 64px" v-show="dashboard">
      <v-list-item dense to="/">
        <v-list-item-content>
          <v-list-item-title class="title">
            <v-list-item-icon>
            <v-icon color="grey lighten-5" size="36">mdi-home</v-icon>
          </v-list-item-icon>
          </v-list-item-title>
        </v-list-item-content>
      </v-list-item>

      <v-list
        dense
        nav
        class="pa-0"
        tile
      >
        <v-list-item
          v-for="item in items"
          :key="item.title"
          :to="item.link"
          active-class="red lighten-2 black--text"
          class="red--text"
        >
          <v-list-item-icon>
            <v-icon color="grey lighten-5">{{ item.icon }}</v-icon>
          </v-list-item-icon>

          <v-list-item-content>
            <v-list-item-title><span class="white--text">{{ item.title }}</span></v-list-item-title>
          </v-list-item-content>
        </v-list-item>
      </v-list>
      
      
    </v-navigation-drawer>
</template>

<script>
  export default {
    name: 'sidebar',
    data () {
      return {
        dashboard: this.$route.path=='/dashboard'?false:true,
        items: [
          { title: 'Dashboard', icon: 'mdi-view-dashboard', link: '/dashboard' },
          { title: 'Salary Budget', icon: 'mdi-chart-areaspline', link: '/budget' },
          { title: 'Forms', icon: 'mdi-format-line-weight', link: '/forms' },
          { title: 'Performance', icon: 'mdi-account-multiple', link: '/performance' },
          { title: 'Salary', icon: 'mdi-cash', link: '/salary' },
          { title: 'Team', icon: 'mdi-microsoft-teams', link: '/teams' },
        ],
      }
    },
    watch: {
    // call again the method if the route changes
      '$route': 'fetchData'
    },
    methods: {
      fetchData () {
        this.dashboard = this.$route.path=='/dashboard'?false:true;
      }
    }
  }
</script>