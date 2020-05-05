<template>
 <v-simple-table fixed-header height="250" class="emp-table" background-color="red lighten-2">
    <template v-slot:default>
      <thead>
        <tr class="white--text">
          <th class="white--text text-left body-2 font-weight-bold">Photo</th>
          <th class="white--text text-left body-2 font-weight-bold">Full Name</th>
          <th class="white--text text-left body-2 font-weight-bold">Title</th>
          <th class="white--text text-left body-2 font-weight-bold">Current PR</th>
          <th class="white--text text-left body-2 font-weight-bold">Current Salary</th>
          <th class="white--text text-left body-2 font-weight-bold">Projected PR</th>
          <th class="white--text text-left body-2 font-weight-bold">Salary Raised</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in employees" :key="item.name">
          <td><v-list-item-avatar color="grey"><img :src="require('./../../assets/' + item.employee.profilePic)"/></v-list-item-avatar></td>
          <td>{{item.employee.firstName + " "+ item.employee.middleName + ". "+ item.employee.lastName}}</td>
          <td></td>
          <td>item.CurrentPR</td>
          <td></td>
          <td></td>
          <td></td>
        </tr>
      </tbody>
    </template>
  </v-simple-table>
</template>
<script>
import {mapGetters} from 'vuex';

export default {
    name: 'Team',
     data () {
      return {
        employees: null
      }
    },
    computed: {
      ...mapGetters(['currentEmployeeID','currentEmployee', 'allEmployees', 'salary', 'pr']),
      
    },
    mounted() {
      this.employees = this.allEmployees
    }
}
</script>

<style scoped>
.emp-table thead tr th{
    background-color: #e53935 !important;
}
</style>