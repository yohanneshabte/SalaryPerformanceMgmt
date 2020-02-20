<template>
  <v-navigation-drawer permanent absolute class="grey darken-4">
      <v-list-item dense>
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
      >
        <v-list-item
          v-for="item in items"
          :key="item.title"
          link
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
        items: [
          { title: 'Dashboard', icon: 'mdi-view-dashboard' },
          { title: 'Email', icon: 'mdi-email' },
          { title: 'Calendar', icon: 'mdi-calendar' },
          { title: 'Analytics', icon: 'mdi-chart-areaspline' },
          { title: 'Forms', icon: 'mdi-format-line-weight' },
          { title: 'Management', icon: 'mdi-account-multiple' },
          { title: 'Project Management', icon: 'mdi-poll' },
        ],
      }
    },
  }
</script>