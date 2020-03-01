<template>
  <v-container class="py-0" style="margin-left: 256px; margin-top: 100px">
   <v-row>
    <v-col cols="10">
    <router-view />
    </v-col>
   </v-row>
  </v-container>
</template>

<script>

  //import EmployeeList from './profile/EmployeeList.vue';
  //import Heirarchy from './profile/Heirarchy.vue';
  //import PrOverall from './profile/PrOverall.vue';
  //import PerformanceReview from './performance/performanceReview.vue';

  export default {
    name: 'Home',
    data: () => ({

      
    }),
    components: {
     //EmployeeList,
     //Heirarchy,
     //PrOverall,
     //PerformanceReview
    }
  }
</script>
