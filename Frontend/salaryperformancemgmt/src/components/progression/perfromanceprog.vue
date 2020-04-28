<template>
    
</template>

<script>
  export default {
    name: 'sidebar',
    data () {
      return {
        items: [
          { title: 'Dashboard', icon: 'mdi-view-dashboard', link: '/dashboard' },
          { title: 'Salary Budget', icon: 'mdi-chart-areaspline', link: '/budget' },
          { title: 'Forms', icon: 'mdi-format-line-weight', link: '/forms' },
          { title: 'Performance', icon: 'mdi-account-multiple', link: '/performance' },
          { title: 'Salary', icon: 'mdi-cash', link: '/salary' },
        ],
      }
    },
  }
</script>