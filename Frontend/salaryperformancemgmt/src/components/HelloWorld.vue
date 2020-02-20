<template>
  <v-container class="py-0" style="margin-left: 256px; margin-top: 100px">



    <EmployeeList></EmployeeList>  

    

  </v-container>
</template>

<script>

  import EmployeeList from './profile/EmployeeList.vue';

  export default {
    name: 'HelloWorld',
    data: () => ({

      
    }),
    components: {
     EmployeeList
    }
  }
</script>
